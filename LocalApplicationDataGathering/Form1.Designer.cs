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
            this.label_status = new System.Windows.Forms.Label();
            this.status_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.databaseConnection = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            this.label_status.Click += new System.EventHandler(this.label1_Click);
            // 
            // status_textbox
            // 
            this.status_textbox.Location = new System.Drawing.Point(192, 50);
            this.status_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.status_textbox.Name = "status_textbox";
            this.status_textbox.Size = new System.Drawing.Size(281, 22);
            this.status_textbox.TabIndex = 1;
            this.status_textbox.TextChanged += new System.EventHandler(this.status_textbox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(560, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(560, 91);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(893, 38);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Ping_status
            // 
            this.Ping_status.Location = new System.Drawing.Point(783, 171);
            this.Ping_status.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ping_status.Name = "Ping_status";
            this.Ping_status.Size = new System.Drawing.Size(215, 22);
            this.Ping_status.TabIndex = 6;
            this.Ping_status.TextChanged += new System.EventHandler(this.Ping_status_TextChanged);
            // 
            // connection_status_textbox
            // 
            this.connection_status_textbox.Location = new System.Drawing.Point(783, 279);
            this.connection_status_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connection_status_textbox.Name = "connection_status_textbox";
            this.connection_status_textbox.Size = new System.Drawing.Size(215, 22);
            this.connection_status_textbox.TabIndex = 7;
            this.connection_status_textbox.TextChanged += new System.EventHandler(this.connection_status_textbox_TextChanged);
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
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            this.allParametersToolStripMenuItem.Click += new System.EventHandler(this.allParametersToolStripMenuItem_Click);
            // 
            // oPCParametersToolStripMenuItem
            // 
            this.oPCParametersToolStripMenuItem.Name = "oPCParametersToolStripMenuItem";
            this.oPCParametersToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.oPCParametersToolStripMenuItem.Text = "OPC parameters";
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
            // 
            // branch2ToolStripMenuItem
            // 
            this.branch2ToolStripMenuItem.Name = "branch2ToolStripMenuItem";
            this.branch2ToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.branch2ToolStripMenuItem.Text = "branch2";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(927, 500);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 10;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // databaseConnection
            // 
            this.databaseConnection.Location = new System.Drawing.Point(439, 500);
            this.databaseConnection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.databaseConnection.Name = "databaseConnection";
            this.databaseConnection.Size = new System.Drawing.Size(197, 28);
            this.databaseConnection.TabIndex = 11;
            this.databaseConnection.Text = "addRecordtoDatabase";
            this.databaseConnection.UseVisualStyleBackColor = true;
            this.databaseConnection.Click += new System.EventHandler(this.button4_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(673, 500);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 28);
            this.button4.TabIndex = 12;
            this.button4.Text = "push_data_to_database";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.databaseConnection);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connection_status_textbox);
            this.Controls.Add(this.Ping_status);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.status_textbox);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.Button databaseConnection;
        private System.Windows.Forms.Button button4;
    }
}

