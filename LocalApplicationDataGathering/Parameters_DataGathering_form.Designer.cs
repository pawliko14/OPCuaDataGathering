namespace LocalApplicationDataGathering
{
    partial class Parameters_DataGathering_form
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
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.Parameter_label = new System.Windows.Forms.Label();
            this.InstallationDate_label = new System.Windows.Forms.Label();
            this.RecordsInDatbase_label = new System.Windows.Forms.Label();
            this.CurrentValue_label = new System.Windows.Forms.Label();
            this.Parameter_value = new System.Windows.Forms.Label();
            this.Installation_value = new System.Windows.Forms.Label();
            this.RecordsInDatabase_value = new System.Windows.Forms.Label();
            this.CurrentValue_value = new System.Windows.Forms.Label();
            this.ConnectionStatus_value = new System.Windows.Forms.Label();
            this.ConnectionStatus_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(9, 24);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(359, 320);
            this.vScrollBar1.TabIndex = 1;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // Parameter_label
            // 
            this.Parameter_label.AutoSize = true;
            this.Parameter_label.Location = new System.Drawing.Point(456, 53);
            this.Parameter_label.Name = "Parameter_label";
            this.Parameter_label.Size = new System.Drawing.Size(55, 13);
            this.Parameter_label.TabIndex = 3;
            this.Parameter_label.Text = "Parameter";
            this.Parameter_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // InstallationDate_label
            // 
            this.InstallationDate_label.AutoSize = true;
            this.InstallationDate_label.Location = new System.Drawing.Point(456, 90);
            this.InstallationDate_label.Name = "InstallationDate_label";
            this.InstallationDate_label.Size = new System.Drawing.Size(81, 13);
            this.InstallationDate_label.TabIndex = 4;
            this.InstallationDate_label.Text = "Installation date";
            // 
            // RecordsInDatbase_label
            // 
            this.RecordsInDatbase_label.AutoSize = true;
            this.RecordsInDatbase_label.Location = new System.Drawing.Point(456, 132);
            this.RecordsInDatbase_label.Name = "RecordsInDatbase_label";
            this.RecordsInDatbase_label.Size = new System.Drawing.Size(105, 13);
            this.RecordsInDatbase_label.TabIndex = 5;
            this.RecordsInDatbase_label.Text = "Records in database";
            // 
            // CurrentValue_label
            // 
            this.CurrentValue_label.AutoSize = true;
            this.CurrentValue_label.Location = new System.Drawing.Point(456, 169);
            this.CurrentValue_label.Name = "CurrentValue_label";
            this.CurrentValue_label.Size = new System.Drawing.Size(71, 13);
            this.CurrentValue_label.TabIndex = 6;
            this.CurrentValue_label.Text = "Current Value";
            // 
            // Parameter_value
            // 
            this.Parameter_value.AutoSize = true;
            this.Parameter_value.Location = new System.Drawing.Point(607, 57);
            this.Parameter_value.Name = "Parameter_value";
            this.Parameter_value.Size = new System.Drawing.Size(87, 13);
            this.Parameter_value.TabIndex = 8;
            this.Parameter_value.Text = "Parameter_value";
            // 
            // Installation_value
            // 
            this.Installation_value.AutoSize = true;
            this.Installation_value.Location = new System.Drawing.Point(607, 90);
            this.Installation_value.Name = "Installation_value";
            this.Installation_value.Size = new System.Drawing.Size(89, 13);
            this.Installation_value.TabIndex = 9;
            this.Installation_value.Text = "Installation_value";
            // 
            // RecordsInDatabase_value
            // 
            this.RecordsInDatabase_value.AutoSize = true;
            this.RecordsInDatabase_value.Location = new System.Drawing.Point(607, 132);
            this.RecordsInDatabase_value.Name = "RecordsInDatabase_value";
            this.RecordsInDatabase_value.Size = new System.Drawing.Size(134, 13);
            this.RecordsInDatabase_value.TabIndex = 10;
            this.RecordsInDatabase_value.Text = "RecordsInDatabase_value";
            // 
            // CurrentValue_value
            // 
            this.CurrentValue_value.AutoSize = true;
            this.CurrentValue_value.Location = new System.Drawing.Point(607, 169);
            this.CurrentValue_value.Name = "CurrentValue_value";
            this.CurrentValue_value.Size = new System.Drawing.Size(100, 13);
            this.CurrentValue_value.TabIndex = 11;
            this.CurrentValue_value.Text = "CurrentValue_value";
            // 
            // ConnectionStatus_value
            // 
            this.ConnectionStatus_value.AutoSize = true;
            this.ConnectionStatus_value.Location = new System.Drawing.Point(607, 402);
            this.ConnectionStatus_value.Name = "ConnectionStatus_value";
            this.ConnectionStatus_value.Size = new System.Drawing.Size(123, 13);
            this.ConnectionStatus_value.TabIndex = 12;
            this.ConnectionStatus_value.Text = "ConnectionStatus_value";
            // 
            // ConnectionStatus_label
            // 
            this.ConnectionStatus_label.AutoSize = true;
            this.ConnectionStatus_label.Location = new System.Drawing.Point(456, 402);
            this.ConnectionStatus_label.Name = "ConnectionStatus_label";
            this.ConnectionStatus_label.Size = new System.Drawing.Size(119, 13);
            this.ConnectionStatus_label.TabIndex = 13;
            this.ConnectionStatus_label.Text = "ConnectionStatus_label";
            this.ConnectionStatus_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Parameters_DataGathering_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConnectionStatus_label);
            this.Controls.Add(this.ConnectionStatus_value);
            this.Controls.Add(this.CurrentValue_value);
            this.Controls.Add(this.RecordsInDatabase_value);
            this.Controls.Add(this.Installation_value);
            this.Controls.Add(this.Parameter_value);
            this.Controls.Add(this.CurrentValue_label);
            this.Controls.Add(this.RecordsInDatbase_label);
            this.Controls.Add(this.InstallationDate_label);
            this.Controls.Add(this.Parameter_label);
            this.Controls.Add(this.vScrollBar1);
            this.Name = "Parameters_DataGathering_form";
            this.Text = "Parameters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label Parameter_label;
        private System.Windows.Forms.Label InstallationDate_label;
        private System.Windows.Forms.Label RecordsInDatbase_label;
        private System.Windows.Forms.Label CurrentValue_label;
        private System.Windows.Forms.Label Parameter_value;
        private System.Windows.Forms.Label Installation_value;
        private System.Windows.Forms.Label RecordsInDatabase_value;
        private System.Windows.Forms.Label CurrentValue_value;
        private System.Windows.Forms.Label ConnectionStatus_value;
        private System.Windows.Forms.Label ConnectionStatus_label;
    }
}