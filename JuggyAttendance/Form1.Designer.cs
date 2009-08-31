namespace JuggyAttendance
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtLeaving = new System.Windows.Forms.TextBox();
            this.lblLeaving = new System.Windows.Forms.Label();
            this.txtLate = new System.Windows.Forms.TextBox();
            this.lblLate = new System.Windows.Forms.Label();
            this.lvAttendance = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.images = new System.Windows.Forms.ImageList(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtInitial = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInitial = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtLoot = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.minuteTicker = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateJuggyCompareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoStopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 584);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(646, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(646, 560);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.lblCount);
            this.tabPage1.Controls.Add(this.txtLeaving);
            this.tabPage1.Controls.Add(this.lblLeaving);
            this.tabPage1.Controls.Add(this.txtLate);
            this.tabPage1.Controls.Add(this.lblLate);
            this.tabPage1.Controls.Add(this.lvAttendance);
            this.tabPage1.Controls.Add(this.btnStop);
            this.tabPage1.Controls.Add(this.btnStart);
            this.tabPage1.Controls.Add(this.txtInitial);
            this.tabPage1.Controls.Add(this.lblInitial);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(638, 534);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Attendance";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCount.BackColor = System.Drawing.SystemColors.Window;
            this.lblCount.Location = new System.Drawing.Point(182, 505);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(448, 23);
            this.lblCount.TabIndex = 7;
            this.lblCount.Text = "28 members / 0 inactive";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLeaving
            // 
            this.txtLeaving.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtLeaving.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtLeaving.Location = new System.Drawing.Point(11, 81);
            this.txtLeaving.Name = "txtLeaving";
            this.txtLeaving.Size = new System.Drawing.Size(165, 20);
            this.txtLeaving.TabIndex = 3;
            this.txtLeaving.Visible = false;
            this.txtLeaving.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLeaving_KeyDown);
            // 
            // lblLeaving
            // 
            this.lblLeaving.AutoSize = true;
            this.lblLeaving.Location = new System.Drawing.Point(8, 65);
            this.lblLeaving.Name = "lblLeaving";
            this.lblLeaving.Size = new System.Drawing.Size(139, 13);
            this.lblLeaving.TabIndex = 2;
            this.lblLeaving.Text = "Add Attendee Leaving &Early";
            this.lblLeaving.Visible = false;
            // 
            // txtLate
            // 
            this.txtLate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtLate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtLate.Location = new System.Drawing.Point(11, 19);
            this.txtLate.Name = "txtLate";
            this.txtLate.Size = new System.Drawing.Size(165, 20);
            this.txtLate.TabIndex = 1;
            this.txtLate.Visible = false;
            this.txtLate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLate_KeyDown);
            // 
            // lblLate
            // 
            this.lblLate.AutoSize = true;
            this.lblLate.Location = new System.Drawing.Point(8, 3);
            this.lblLate.Name = "lblLate";
            this.lblLate.Size = new System.Drawing.Size(96, 13);
            this.lblLate.TabIndex = 0;
            this.lblLate.Text = "Add &Late Attendee";
            this.lblLate.Visible = false;
            // 
            // lvAttendance
            // 
            this.lvAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvAttendance.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvAttendance.FullRowSelect = true;
            this.lvAttendance.GridLines = true;
            this.lvAttendance.Location = new System.Drawing.Point(182, 19);
            this.lvAttendance.Name = "lvAttendance";
            this.lvAttendance.Size = new System.Drawing.Size(448, 480);
            this.lvAttendance.SmallImageList = this.images;
            this.lvAttendance.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvAttendance.TabIndex = 4;
            this.lvAttendance.UseCompatibleStateImageBehavior = false;
            this.lvAttendance.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Member";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Minutes";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 100;
            // 
            // images
            // 
            this.images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images.ImageStream")));
            this.images.TransparentColor = System.Drawing.Color.Transparent;
            this.images.Images.SetKeyName(0, "clock_red.png");
            this.images.Images.SetKeyName(1, "clock.png");
            this.images.Images.SetKeyName(2, "stop.png");
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStop.Location = new System.Drawing.Point(11, 505);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(165, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Sto&p Raid";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.Location = new System.Drawing.Point(11, 505);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(165, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Star&t Raid";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtInitial
            // 
            this.txtInitial.AcceptsReturn = true;
            this.txtInitial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.txtInitial.ContextMenuStrip = this.contextMenuStrip1;
            this.txtInitial.Location = new System.Drawing.Point(11, 19);
            this.txtInitial.Multiline = true;
            this.txtInitial.Name = "txtInitial";
            this.txtInitial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInitial.Size = new System.Drawing.Size(165, 480);
            this.txtInitial.TabIndex = 0;
            this.txtInitial.TextChanged += new System.EventHandler(this.txtInitial_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.forceSaveToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 48);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // forceSaveToolStripMenuItem
            // 
            this.forceSaveToolStripMenuItem.Name = "forceSaveToolStripMenuItem";
            this.forceSaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.forceSaveToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.forceSaveToolStripMenuItem.Text = "Force Save";
            this.forceSaveToolStripMenuItem.Click += new System.EventHandler(this.forceSaveToolStripMenuItem_Click);
            // 
            // lblInitial
            // 
            this.lblInitial.AutoSize = true;
            this.lblInitial.Location = new System.Drawing.Point(8, 3);
            this.lblInitial.Name = "lblInitial";
            this.lblInitial.Size = new System.Drawing.Size(89, 13);
            this.lblInitial.TabIndex = 0;
            this.lblInitial.Text = "Initial Attendance";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtLoot);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(638, 534);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Loot";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtLoot
            // 
            this.txtLoot.ContextMenuStrip = this.contextMenuStrip1;
            this.txtLoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLoot.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoot.Location = new System.Drawing.Point(3, 3);
            this.txtLoot.Multiline = true;
            this.txtLoot.Name = "txtLoot";
            this.txtLoot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLoot.Size = new System.Drawing.Size(632, 528);
            this.txtLoot.TabIndex = 0;
            this.txtLoot.TextChanged += new System.EventHandler(this.txtLoot_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.txtOutput);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(638, 534);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Output";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.SystemColors.Window;
            this.txtOutput.ContextMenuStrip = this.contextMenuStrip1;
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(3, 3);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(632, 528);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // time
            // 
            this.time.Interval = 1000;
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // minuteTicker
            // 
            this.minuteTicker.Interval = 60000;
            this.minuteTicker.Tick += new System.EventHandler(this.minuteTicker_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(646, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateJuggyCompareToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // updateJuggyCompareToolStripMenuItem
            // 
            this.updateJuggyCompareToolStripMenuItem.Name = "updateJuggyCompareToolStripMenuItem";
            this.updateJuggyCompareToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.updateJuggyCompareToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.updateJuggyCompareToolStripMenuItem.Text = "Update JuggyCompare";
            this.updateJuggyCompareToolStripMenuItem.Click += new System.EventHandler(this.updateJuggyCompareToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoStopToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // autoStopToolStripMenuItem
            // 
            this.autoStopToolStripMenuItem.Checked = true;
            this.autoStopToolStripMenuItem.CheckOnClick = true;
            this.autoStopToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoStopToolStripMenuItem.Name = "autoStopToolStripMenuItem";
            this.autoStopToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.autoStopToolStripMenuItem.Text = "Stop at 23:30 CST";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 606);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1000, 200);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "JuggyAttendance";
            this.Activated += new System.EventHandler(this.Form1_Enter);
            this.Enter += new System.EventHandler(this.Form1_Enter);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.Timer minuteTicker;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ListView lvAttendance;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox txtLeaving;
        private System.Windows.Forms.Label lblLeaving;
        private System.Windows.Forms.TextBox txtLate;
        private System.Windows.Forms.Label lblLate;
        private System.Windows.Forms.TextBox txtInitial;
        private System.Windows.Forms.Label lblInitial;
        private System.Windows.Forms.ImageList images;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtLoot;
        private System.Windows.Forms.ToolStripMenuItem forceSaveToolStripMenuItem;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoStopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateJuggyCompareToolStripMenuItem;

    }
}

