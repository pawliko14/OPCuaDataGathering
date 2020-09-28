namespace LocalApplicationDataGathering
{
    partial class base_child_form
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
            this.quit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // quit_button
            // 
            this.quit_button.Location = new System.Drawing.Point(924, 12);
            this.quit_button.Name = "quit_button";
            this.quit_button.Size = new System.Drawing.Size(84, 29);
            this.quit_button.TabIndex = 1;
            this.quit_button.Text = "Exit";
            this.quit_button.UseVisualStyleBackColor = true;
            this.quit_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // base_child_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1020, 651);
            this.Controls.Add(this.quit_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "base_child_form";
            this.Text = "base_child_form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button quit_button;
    }
}