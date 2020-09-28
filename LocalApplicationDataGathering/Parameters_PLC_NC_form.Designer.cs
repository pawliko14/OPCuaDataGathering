namespace LocalApplicationDataGathering
{
    partial class Parameters_PLC_NC_form
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
            this.Check_if_variable_exists = new System.Windows.Forms.Button();
            this.variable_name = new System.Windows.Forms.TextBox();
            this.prefix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.save_to_database = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Check_if_variable_exists
            // 
            this.Check_if_variable_exists.Location = new System.Drawing.Point(461, 60);
            this.Check_if_variable_exists.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Check_if_variable_exists.Name = "Check_if_variable_exists";
            this.Check_if_variable_exists.Size = new System.Drawing.Size(75, 23);
            this.Check_if_variable_exists.TabIndex = 0;
            this.Check_if_variable_exists.Text = "Check";
            this.Check_if_variable_exists.UseVisualStyleBackColor = true;
            this.Check_if_variable_exists.Click += new System.EventHandler(this.button1_Click);
            // 
            // variable_name
            // 
            this.variable_name.Location = new System.Drawing.Point(203, 60);
            this.variable_name.Margin = new System.Windows.Forms.Padding(4);
            this.variable_name.Name = "variable_name";
            this.variable_name.Size = new System.Drawing.Size(231, 22);
            this.variable_name.TabIndex = 1;
            // 
            // prefix
            // 
            this.prefix.Location = new System.Drawing.Point(16, 60);
            this.prefix.Margin = new System.Windows.Forms.Padding(4);
            this.prefix.Name = "prefix";
            this.prefix.Size = new System.Drawing.Size(157, 22);
            this.prefix.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Location prefix";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "PLC/NC variable name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "current NC/PLC variables";
            // 
            // save_to_database
            // 
            this.save_to_database.Location = new System.Drawing.Point(622, 395);
            this.save_to_database.Margin = new System.Windows.Forms.Padding(4);
            this.save_to_database.Name = "save_to_database";
            this.save_to_database.Size = new System.Drawing.Size(165, 23);
            this.save_to_database.TabIndex = 9;
            this.save_to_database.Text = "Save to Database";
            this.save_to_database.UseVisualStyleBackColor = true;
            this.save_to_database.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 395);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(418, 250);
            this.dataGridView1.TabIndex = 11;
            // 
            // Parameters_PLC_NC_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.save_to_database);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prefix);
            this.Controls.Add(this.variable_name);
            this.Controls.Add(this.Check_if_variable_exists);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Parameters_PLC_NC_form";
            this.Text = "Parameters_PLC_NC_form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Check_if_variable_exists;
        private System.Windows.Forms.TextBox variable_name;
        private System.Windows.Forms.TextBox prefix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button save_to_database;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}