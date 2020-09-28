namespace LocalApplicationDataGathering
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
            this.label_status = new System.Windows.Forms.Label();
            this.status_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timerBox = new System.Windows.Forms.TextBox();
            this.Ping_status = new System.Windows.Forms.TextBox();
            this.connection_status_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.parametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPCParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGatheringParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPLCParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEADMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.branchingexpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.branch1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.branch2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.databaseConnection_button = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timerBox2 = new System.Windows.Forms.TextBox();
            this.testing_add_record = new System.Windows.Forms.Button();
            this.stop_bag_gathering = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(83, 38);
            this.label_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(63, 17);
            this.label_status.TabIndex = 0;
            this.label_status.Text = "STATUS";
            // 
            // status_textbox
            // 
            this.status_textbox.Location = new System.Drawing.Point(192, 50);
            this.status_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.status_textbox.Name = "status_textbox";
            this.status_textbox.Size = new System.Drawing.Size(281, 22);
            this.status_textbox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(560, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(560, 91);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // timerBox
            // 
            this.timerBox.Location = new System.Drawing.Point(893, 38);
            this.timerBox.Margin = new System.Windows.Forms.Padding(4);
            this.timerBox.Name = "timerBox";
            this.timerBox.Size = new System.Drawing.Size(132, 22);
            this.timerBox.TabIndex = 4;
            this.timerBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Ping_status
            // 
            this.Ping_status.Location = new System.Drawing.Point(783, 171);
            this.Ping_status.Margin = new System.Windows.Forms.Padding(4);
            this.Ping_status.Name = "Ping_status";
            this.Ping_status.Size = new System.Drawing.Size(215, 22);
            this.Ping_status.TabIndex = 6;
            // 
            // connection_status_textbox
            // 
            this.connection_status_textbox.Location = new System.Drawing.Point(783, 279);
            this.connection_status_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.connection_status_textbox.Name = "connection_status_textbox";
            this.connection_status_textbox.Size = new System.Drawing.Size(215, 22);
            this.connection_status_textbox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(593, 283);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "COnnection status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametersToolStripMenuItem,
            this.connectionsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.branchingexpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // parametersToolStripMenuItem
            // 
            this.parametersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allParametersToolStripMenuItem,
            this.oPCParametersToolStripMenuItem,
            this.dataGatheringParametersToolStripMenuItem,
            this.addPLCParametersToolStripMenuItem});
            this.parametersToolStripMenuItem.Name = "parametersToolStripMenuItem";
            this.parametersToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.parametersToolStripMenuItem.Text = "Parameters";
            // 
            // allParametersToolStripMenuItem
            // 
            this.allParametersToolStripMenuItem.Name = "allParametersToolStripMenuItem";
            this.allParametersToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.allParametersToolStripMenuItem.Text = "All parameters";
            // 
            // oPCParametersToolStripMenuItem
            // 
            this.oPCParametersToolStripMenuItem.Name = "oPCParametersToolStripMenuItem";
            this.oPCParametersToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.oPCParametersToolStripMenuItem.Text = "OPC parameters";
            this.oPCParametersToolStripMenuItem.Click += new System.EventHandler(this.oPCParametersToolStripMenuItem_Click);
            // 
            // dataGatheringParametersToolStripMenuItem
            // 
            this.dataGatheringParametersToolStripMenuItem.Name = "dataGatheringParametersToolStripMenuItem";
            this.dataGatheringParametersToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.dataGatheringParametersToolStripMenuItem.Text = "Data Gathering parameters";
            this.dataGatheringParametersToolStripMenuItem.Click += new System.EventHandler(this.dataGatheringParametersToolStripMenuItem_Click);
            // 
            // addPLCParametersToolStripMenuItem
            // 
            this.addPLCParametersToolStripMenuItem.Name = "addPLCParametersToolStripMenuItem";
            this.addPLCParametersToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.addPLCParametersToolStripMenuItem.Text = "Add PLC/NC Parameters";
            this.addPLCParametersToolStripMenuItem.Click += new System.EventHandler(this.addPLCParametersToolStripMenuItem_Click);
            // 
            // connectionsToolStripMenuItem
            // 
            this.connectionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionStatusToolStripMenuItem,
            this.connectionSettingsToolStripMenuItem});
            this.connectionsToolStripMenuItem.Name = "connectionsToolStripMenuItem";
            this.connectionsToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.connectionsToolStripMenuItem.Text = "Connections";
            // 
            // connectionStatusToolStripMenuItem
            // 
            this.connectionStatusToolStripMenuItem.Name = "connectionStatusToolStripMenuItem";
            this.connectionStatusToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.connectionStatusToolStripMenuItem.Text = "Connection status";
            // 
            // connectionSettingsToolStripMenuItem
            // 
            this.connectionSettingsToolStripMenuItem.Name = "connectionSettingsToolStripMenuItem";
            this.connectionSettingsToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.connectionSettingsToolStripMenuItem.Text = "Connection settings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEADMEToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // rEADMEToolStripMenuItem
            // 
            this.rEADMEToolStripMenuItem.Name = "rEADMEToolStripMenuItem";
            this.rEADMEToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.rEADMEToolStripMenuItem.Text = "README";
            // 
            // branchingexpToolStripMenuItem
            // 
            this.branchingexpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.branch1ToolStripMenuItem,
            this.branch2ToolStripMenuItem});
            this.branchingexpToolStripMenuItem.Name = "branchingexpToolStripMenuItem";
            this.branchingexpToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.branchingexpToolStripMenuItem.Text = "Branching-exp";
            // 
            // branch1ToolStripMenuItem
            // 
            this.branch1ToolStripMenuItem.Name = "branch1ToolStripMenuItem";
            this.branch1ToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.branch1ToolStripMenuItem.Text = "branch1";
            this.branch1ToolStripMenuItem.Click += new System.EventHandler(this.branch1ToolStripMenuItem_Click);
            // 
            // branch2ToolStripMenuItem
            // 
            this.branch2ToolStripMenuItem.Name = "branch2ToolStripMenuItem";
            this.branch2ToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.branch2ToolStripMenuItem.Text = "branch2";
            this.branch2ToolStripMenuItem.Click += new System.EventHandler(this.branch2ToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(927, 500);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 10;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // databaseConnection_button
            // 
            this.databaseConnection_button.Location = new System.Drawing.Point(439, 500);
            this.databaseConnection_button.Margin = new System.Windows.Forms.Padding(4);
            this.databaseConnection_button.Name = "databaseConnection_button";
            this.databaseConnection_button.Size = new System.Drawing.Size(197, 28);
            this.databaseConnection_button.TabIndex = 11;
            this.databaseConnection_button.Text = "addRecordtoDatabase";
            this.databaseConnection_button.UseVisualStyleBackColor = true;
            this.databaseConnection_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(673, 500);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(193, 28);
            this.button4.TabIndex = 12;
            this.button4.Text = "Show readable variables";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick_1);
            // 
            // timerBox2
            // 
            this.timerBox2.Location = new System.Drawing.Point(893, 68);
            this.timerBox2.Margin = new System.Windows.Forms.Padding(4);
            this.timerBox2.Name = "timerBox2";
            this.timerBox2.Size = new System.Drawing.Size(132, 22);
            this.timerBox2.TabIndex = 13;
            // 
            // testing_add_record
            // 
            this.testing_add_record.Location = new System.Drawing.Point(220, 500);
            this.testing_add_record.Margin = new System.Windows.Forms.Padding(4);
            this.testing_add_record.Name = "testing_add_record";
            this.testing_add_record.Size = new System.Drawing.Size(197, 28);
            this.testing_add_record.TabIndex = 14;
            this.testing_add_record.Text = "add Bag to dataase";
            this.testing_add_record.UseVisualStyleBackColor = true;
            this.testing_add_record.Click += new System.EventHandler(this.testing_add_record_Click);
            // 
            // stop_bag_gathering
            // 
            this.stop_bag_gathering.Location = new System.Drawing.Point(220, 449);
            this.stop_bag_gathering.Margin = new System.Windows.Forms.Padding(4);
            this.stop_bag_gathering.Name = "stop_bag_gathering";
            this.stop_bag_gathering.Size = new System.Drawing.Size(197, 28);
            this.stop_bag_gathering.TabIndex = 15;
            this.stop_bag_gathering.Text = "STOP bag gather";
            this.stop_bag_gathering.UseVisualStyleBackColor = true;
            this.stop_bag_gathering.Click += new System.EventHandler(this.stop_bag_gathering_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.stop_bag_gathering);
            this.Controls.Add(this.testing_add_record);
            this.Controls.Add(this.timerBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.databaseConnection_button);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connection_status_textbox);
            this.Controls.Add(this.Ping_status);
            this.Controls.Add(this.timerBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.status_textbox);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.TextBox status_textbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox timerBox;
        private System.Windows.Forms.TextBox Ping_status;
        private System.Windows.Forms.TextBox connection_status_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem parametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allParametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPCParametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataGatheringParametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEADMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPLCParametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem branchingexpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem branch1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem branch2ToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button databaseConnection_button;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox timerBox2;
        private System.Windows.Forms.Button testing_add_record;
        private System.Windows.Forms.Button stop_bag_gathering;
    }
}

