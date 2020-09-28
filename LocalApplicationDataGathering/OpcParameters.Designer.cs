namespace LocalApplicationDataGathering
{
    partial class Opc_parameters_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.OpcTimeOut_value = new System.Windows.Forms.TextBox();
            this.close = new System.Windows.Forms.Button();
            this.SessionId_box = new System.Windows.Forms.TextBox();
            this.SessionId = new System.Windows.Forms.Label();
            this.SessionName_box = new System.Windows.Forms.TextBox();
            this.SessionName = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opc Timeout";
            // 
            // OpcTimeOut_value
            // 
            this.OpcTimeOut_value.Location = new System.Drawing.Point(145, 39);
            this.OpcTimeOut_value.Name = "OpcTimeOut_value";
            this.OpcTimeOut_value.Size = new System.Drawing.Size(100, 22);
            this.OpcTimeOut_value.TabIndex = 1;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(713, 415);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 2;
            this.close.Text = "button1";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // SessionId_box
            // 
            this.SessionId_box.Location = new System.Drawing.Point(145, 77);
            this.SessionId_box.Name = "SessionId_box";
            this.SessionId_box.Size = new System.Drawing.Size(100, 22);
            this.SessionId_box.TabIndex = 4;
            // 
            // SessionId
            // 
            this.SessionId.AutoSize = true;
            this.SessionId.Location = new System.Drawing.Point(41, 77);
            this.SessionId.Name = "SessionId";
            this.SessionId.Size = new System.Drawing.Size(75, 17);
            this.SessionId.TabIndex = 3;
            this.SessionId.Text = "Session ID";
            // 
            // SessionName_box
            // 
            this.SessionName_box.Location = new System.Drawing.Point(145, 116);
            this.SessionName_box.Name = "SessionName_box";
            this.SessionName_box.Size = new System.Drawing.Size(100, 22);
            this.SessionName_box.TabIndex = 6;
            // 
            // SessionName
            // 
            this.SessionName.AutoSize = true;
            this.SessionName.Location = new System.Drawing.Point(41, 116);
            this.SessionName.Name = "SessionName";
            this.SessionName.Size = new System.Drawing.Size(99, 17);
            this.SessionName.TabIndex = 5;
            this.SessionName.Text = "Session Name";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(145, 155);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Opc Timeout";
            // 
            // Opc_parameters_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 651);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SessionName_box);
            this.Controls.Add(this.SessionName);
            this.Controls.Add(this.SessionId_box);
            this.Controls.Add(this.SessionId);
            this.Controls.Add(this.close);
            this.Controls.Add(this.OpcTimeOut_value);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Opc_parameters_form";
            this.Text = "form_3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OpcTimeOut_value;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.TextBox SessionId_box;
        private System.Windows.Forms.Label SessionId;
        private System.Windows.Forms.TextBox SessionName_box;
        private System.Windows.Forms.Label SessionName;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
    }
}