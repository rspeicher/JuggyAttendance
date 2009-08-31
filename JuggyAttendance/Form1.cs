using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;
using System.Net;

namespace JuggyAttendance
{
    public partial class Form1 : Form
    {
        private Attendees attendees = new Attendees();

        private DateTime startupTime = DateTime.Now;
        private string randomString = "";
        private bool running = false;

        public Form1()
        {
            InitializeComponent();

            lblCount.Text = "";

            time.Start();
            txtInitial.Focus();

            #if DEBUG
            minuteTicker.Interval = 5000;
            #endif
        }

        ~Form1()
        {
            minuteTicker.Stop();
            time.Stop();
        }

        #region Output --------------------------------------------------------
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            txtOutput.Text = GetOutput();
        }

        private string GetOutput()
        {
            string retval = "";

            retval += String.Format("[b][u][size=3]Attendance[/size][/u][/b] ({0} minutes total)\r\n\r\n", attendees.TotalMinutes);

            foreach (Attendee att in attendees)
            {
                retval += String.Format("{0},{1:N},{2}\r\n", att.Name, attendees.GetPercentage(att), att.NumMinutes);
            }

            retval += "\r\n\r\n";
            retval += "[b][u][size=3]Drops[/size][/u][/b]\r\n\r\n";
            retval += LootTags(txtLoot.Text);

            return retval;
        }

        private string LootTags(string loot)
        {
            loot = loot + "\r\n";
            return Regex.Replace(loot, @"^(?<buyer>.+) - (?<item>.+)(?<id>\|\d+)\r$", "${buyer} - [item]${item}[/item]${id}", RegexOptions.Multiline);
        }

        private void WriteFile()
        {
            #if !DEBUG
            string path = String.Format("{0}\\JuggyAttendance\\{1}-{2}-{3}-{4}.txt", Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
                startupTime.Year, startupTime.Month, startupTime.Day, randomString);
            TextWriter tw = new StreamWriter(path);

            tw.Write(GetOutput());

            tw.Close();
            #endif
        }
        #endregion

        #region Tick, Tock ----------------------------------------------------
        private void time_Tick(object sender, EventArgs e)
        {
            lblStatus.Text = String.Format("{0:t}", DateTime.Now);

            if (lblStatus.Text == "12:30 AM" && autoStopToolStripMenuItem.Checked)
            {
                btnStop.PerformClick();
            }
        }

        private void minuteTicker_Tick(object sender, EventArgs e)
        {
            // Increment the total number of raid minutes
            attendees.Increment();

            if (attendees.TotalMinutes % 10 == 0 && this.running)
            {
                WriteFile();
            }

            if (Form1.ActiveForm != null)
            {
                UpdateTable();
            }
        }
        #endregion

        private void UpdateTable()
        {
            if (Form1.ActiveForm == null)
            {
                return;
            }

            foreach (Attendee att in attendees)
            {
                AddOrUpdateListItem(att);
            }

            UpdateCounts();
        }

        private void UpdateCounts()
        {
            int cInactive = 0;
            int cActive = 0;
            foreach (Attendee att in attendees)
            {
                if (att.Running)
                {
                    cActive++;
                }
                else
                {
                    cInactive++;
                }
            }

            lblCount.Text = String.Format("{0} total / {1} inactive", cActive + cInactive, cInactive);
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtInitial.Focused)
            {
                txtInitial.SelectAll();
            }
            else if (txtLoot.Focused)
            {
                txtLoot.SelectAll();
            }
            else if (txtOutput.Focused)
            {
                txtOutput.SelectAll();
            }
        }

        private void forceSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteFile();
        }

        #region Enter Late/Leaving Early
        private void txtLate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                AddLateAttendee(txtLate.Text);
                AddAutoCompleteValue(txtLate.Text);
                txtLate.Text = "";
            }
        }

        private void txtLeaving_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                AddDepartedAttendee(txtLeaving.Text);
                AddAutoCompleteValue(txtLeaving.Text);
                txtLeaving.Text = "";
            }
        }
        #endregion

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.running = true;
            attendees.Clear();
            minuteTicker.Start();

            btnStop.Visible = true;
            lvAttendance.Visible = true;
            lblLate.Visible = true;
            lblLeaving.Visible = true;
            txtLate.Visible = true;
            txtLeaving.Visible = true;

            btnStart.Visible = false;
            lblInitial.Visible = false;
            txtInitial.Visible = false;

            lvAttendance.Items.Clear();

            randomString = RandomString(6, true);

            Console.WriteLine("Outputting to " + randomString);

            AddInitialAttendance();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.running = false;
            minuteTicker.Stop();
            WriteFile(); // Force a file output

            btnStop.Visible = false;
            //lvAttendance.Visible = false;
            lblLate.Visible = false;
            lblLeaving.Visible = false;
            txtLate.Visible = false;
            txtLeaving.Visible = false;

            btnStart.Visible = true;
            lblInitial.Visible = true;
            txtInitial.Visible = true;
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            // Update our ListView control after the form regains focus, so we're not updating it when the user isn't looking at it, using CPU
            UpdateTable();
        }

        private void AddInitialAttendance()
        {
            Attendee attendee;
            string[] init = txtInitial.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string att in init)
            {
                attendee = attendees.Get(att.Trim());
                attendee.Running = true;
                attendees.Add(attendee);

                AddAutoCompleteValue(attendee.Name);

                AddOrUpdateListItem(attendee);
            }

            UpdateCounts();
        }
        private void AddLateAttendee(string name)
        {
            if (name.Trim() == "")
            {
                return;
            }

            Attendee attendee = attendees.Get(name, true);
            attendee.Running = true;
            attendees.Add(attendee);

            AddOrUpdateListItem(attendee);
            UpdateCounts();
        }
        private void AddDepartedAttendee(string name)
        {
            if (name.Trim() == "")
            {
                return;
            }

            Attendee attendee = attendees.Get(name, true);
            attendee.Running = false;
            attendees.Add(attendee);

            AddOrUpdateListItem(attendee);
            UpdateCounts();
        }

        private void AddOrUpdateListItem(Attendee att)
        {
            ListViewItem item;
            for (int i = 0; i < lvAttendance.Items.Count; i++)
            {
                item = lvAttendance.Items[i];
                if (item.Text == att.Name)
                {
                    item.SubItems[1].Text = att.NumMinutes.ToString();
                    item.ImageIndex = att.ImageIndex;
                    lvAttendance.Items[i] = item;
                    return;
                }
            }

            item = new ListViewItem(att.Name);
            item.SubItems.Add(att.NumMinutes.ToString());
            item.ImageIndex = att.ImageIndex;
            lvAttendance.Items.Add(item);
            return;
        }

        private void AddAutoCompleteValue(string val)
        {
            txtLate.AutoCompleteCustomSource.Add(val);
            txtLeaving.AutoCompleteCustomSource.Add(val);
        }

        /// <summary>
        /// Generates a random string with the given length
        /// </summary>
        /// <param name="size">Size of the string</param>
        /// <param name="lowerCase">If true, generate lowercase string</param>
        /// <returns>Random string</returns>
        private string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                txtLoot.Focus();
                txtLoot.SelectionStart = txtLoot.Text.Length;
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                txtOutput.Focus();
            }
        }

        private void txtLoot_TextChanged(object sender, EventArgs e)
        {
            txtLoot.Text = txtLoot.Text.Replace("\r\n", "\n").Replace("\r", "\n").Replace("\n", "\r\n");
        }

        private void txtInitial_TextChanged(object sender, EventArgs e)
        {
            txtInitial.Text = txtInitial.Text.Replace("\r\n", "\n").Replace("\r", "\n").Replace("\n", "\r\n");
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text.Replace("\r\n", "\n").Replace("\r", "\n").Replace("\n", "\r\n");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!running || MessageBox.Show("A raid is in progress. Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void updateJuggyCompareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Program Files (x86)\\World of Warcraft\\Interface\\AddOns\\JuggyCompare\\JuggyCompare_Data.lua";
            Stream localFile = File.Create(filePath);
            WebClient client;

            StreamReader reader = new StreamReader("key.txt");
            string key = reader.ReadToEnd().Trim();

            Uri remoteUri = new Uri("http://lf.juggernautguild.com/members.lua?api_key=" + key);

            try
            {
                Console.WriteLine("Updating JuggyCompare_Data.lua...");
                client = new WebClient();
                Stream input = client.OpenRead(remoteUri);

                byte[] buf = new byte[1024];
                int read;
                int size = Int32.Parse(client.ResponseHeaders.Get("Content-Length"));

                do
                {
                    read = input.Read(buf, 0, buf.Length);

                    if (read > 0)
                    {
                        localFile.Write(buf, 0, read);
                    }
                }
                while (read > 0);

                input.Close();
                localFile.Flush();
                localFile.Close();
                Console.WriteLine("Finished updating JuggyCompare_Data.lua");
            }
            catch (WebException ex)
            {
                Console.WriteLine("WebException: " + ex.ToString());
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("FileNotFound: " + ex.FileName + " / " + ex.StackTrace);
            }
        }
    }

    internal class Attendee
    {
        private string name = "";
        private int numMinutes = 0;
        private bool running = false;

        /// <summary>
        /// Name of the attendee.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Number of minutes the attendee has been in the raid.
        /// </summary>
        public int NumMinutes
        {
            get { return numMinutes; }
            set { this.numMinutes = value; }
        }

        /// <summary>
        /// Whether or not to continue incrementing the attendee's <code>NumMinutes</code> value.
        /// </summary>
        public bool Running
        {
            get { return running; }
            set { this.running = value; }
        }

        public int ImageIndex
        {
            get { return (running) ? 1 : 0; }
        }

        public Attendee()
        {
        }

        public Attendee(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    internal class Attendees : IEnumerable
    {
        private ArrayList a = new ArrayList(100);
        private int totalMinutes = 0;

        public int TotalMinutes
        {
            get { return totalMinutes; }
        }

        public int Increment()
        {
            foreach (Attendee att in a)
            {
                if (att.Running)
                {
                    att.NumMinutes++;
                }
            }

            totalMinutes++;
            return totalMinutes;
        }

        public void Add(Attendee att)
        {
            bool found = false;
            for (int i = 0; i < a.Count; i++)
            {
                if (((Attendee)a[i]).Name.ToLower() == att.Name.ToLower())
                {
                    found = true;
                    a[i] = att;
                }
            }

            if (!found)
            {
                a.Add(att);
            }
        }

        public Attendee Add(string name)
        {
            Attendee att = Get(name);
            Add(att);

            return att;
        }

        public Attendee Get(string name)
        {
            return Get(name, true);
        }

        public Attendee Get(string name, bool makeNew)
        {
            foreach (Attendee att in a)
            {
                if (att.Name.ToLower() == name.ToLower())
                {
                    return att;
                }
            }

            if (makeNew)
            {
                return new Attendee(name);
            }

            return null;
        }

        public double GetPercentage(Attendee att)
        {
            // This would make more sense to have in the Attendee class, but each record has no clean way of knowing totalMinutes.
            return ((double)att.NumMinutes / (double)totalMinutes);
        }

        public double GetPercentage(string name)
        {
            return GetPercentage(Get(name));
        }

        public void Clear()
        {
            totalMinutes = 0;
            a.Clear();
        }

        #region IEnumerable Members
        public IEnumerator GetEnumerator()
        {
            return a.GetEnumerator();
        }
        #endregion
    }
}