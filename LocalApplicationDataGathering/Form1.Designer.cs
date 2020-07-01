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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(62, 31);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(50, 13);
            this.label_status.TabIndex = 0;
            this.label_status.Text = "STATUS";
            this.label_status.Click += new System.EventHandler(this.label1_Click);
            // 
            // status_textbox
            // 
            this.status_textbox.Location = new System.Drawing.Point(141, 56);
            this.status_textbox.Name = "status_textbox";
            this.status_textbox.Size = new System.Drawing.Size(212, 20);
            this.status_textbox.TabIndex = 1;
            this.status_textbox.TextChanged += new System.EventHandler(this.status_textbox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(420, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(670, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Ping_status
            // 
            this.Ping_status.Location = new System.Drawing.Point(587, 139);
            this.Ping_status.Name = "Ping_status";
            this.Ping_status.Size = new System.Drawing.Size(162, 20);
            this.Ping_status.TabIndex = 6;
            this.Ping_status.TextChanged += new System.EventHandler(this.Ping_status_TextChanged);
            // 
            // connection_status_textbox
            // 
            this.connection_status_textbox.Location = new System.Drawing.Point(587, 227);
            this.connection_status_textbox.Name = "connection_status_textbox";
            this.connection_status_textbox.Size = new System.Drawing.Size(162, 20);
            this.connection_status_textbox.TabIndex = 7;
            this.connection_status_textbox.TextChanged += new System.EventHandler(this.connection_status_textbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "COnnection status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametersToolStripMenuItem,
            this.connectionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
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
            this.parametersToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.parametersToolStripMenuItem.Text = "Parameters";
            // 
            // allParametersToolStripMenuItem
            // 
            this.allParametersToolStripMenuItem.Name = "allParametersToolStripMenuItem";
            this.allParametersToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.allParametersToolStripMenuItem.Text = "All parameters";
            this.allParametersToolStripMenuItem.Click += new System.EventHandler(this.allParametersToolStripMenuItem_Click);
            // 
            // oPCParametersToolStripMenuItem
            // 
            this.oPCParametersToolStripMenuItem.Name = "oPCParametersToolStripMenuItem";
            this.oPCParametersToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.oPCParametersToolStripMenuItem.Text = "OPC parameters";
            // 
            // dataGatheringParametersToolStripMenuItem
            // 
            this.dataGatheringParametersToolStripMenuItem.Name = "dataGatheringParametersToolStripMenuItem";
            this.dataGatheringParametersToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.dataGatheringParametersToolStripMenuItem.Text = "Data Gathering parameters";
            this.dataGatheringParametersToolStripMenuItem.Click += new System.EventHandler(this.dataGatheringParametersToolStripMenuItem_Click);
            // 
            // addPLCParametersToolStripMenuItem
            // 
            this.addPLCParametersToolStripMenuItem.Name = "addPLCParametersToolStripMenuItem";
            this.addPLCParametersToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.addPLCParametersToolStripMenuItem.Text = "Add PLC/NC Parameters";
            this.addPLCParametersToolStripMenuItem.Click += new System.EventHandler(this.addPLCParametersToolStripMenuItem_Click);
            // 
            // connectionsToolStripMenuItem
            // 
            this.connectionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionStatusToolStripMenuItem,
            this.connectionSettingsToolStripMenuItem});
            this.connectionsToolStripMenuItem.Name = "connectionsToolStripMenuItem";
            this.connectionsToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.connectionsToolStripMenuItem.Text = "Connections";
            // 
            // connectionStatusToolStripMenuItem
            // 
            this.connectionStatusToolStripMenuItem.Name = "connectionStatusToolStripMenuItem";
            this.connectionStatusToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.connectionStatusToolStripMenuItem.Text = "Connection status";
            // 
            // connectionSettingsToolStripMenuItem
            // 
            this.connectionSettingsToolStripMenuItem.Name = "connectionSettingsToolStripMenuItem";
            this.connectionSettingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.connectionSettingsToolStripMenuItem.Text = "Connection settings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEADMEToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // rEADMEToolStripMenuItem
            // 
            this.rEADMEToolStripMenuItem.Name = "rEADMEToolStripMenuItem";
            this.rEADMEToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.rEADMEToolStripMenuItem.Text = "README";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

