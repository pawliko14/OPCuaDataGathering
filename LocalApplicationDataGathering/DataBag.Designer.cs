namespace LocalApplicationDataGathering
{
    partial class DataBags
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataBags_gridview = new System.Windows.Forms.DataGridView();
            this.valuesInBag_gridview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataBags_gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valuesInBag_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // DataBags_gridview
            // 
            this.DataBags_gridview.AllowUserToAddRows = false;
            this.DataBags_gridview.AllowUserToDeleteRows = false;
            this.DataBags_gridview.AllowUserToOrderColumns = true;
            this.DataBags_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataBags_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataBags_gridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataBags_gridview.Location = new System.Drawing.Point(37, 27);
            this.DataBags_gridview.Name = "DataBags_gridview";
            this.DataBags_gridview.ReadOnly = true;
            this.DataBags_gridview.RowTemplate.Height = 24;
            this.DataBags_gridview.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DataBags_gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataBags_gridview.Size = new System.Drawing.Size(494, 210);
            this.DataBags_gridview.TabIndex = 0;
            this.DataBags_gridview.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataBags_gridview_CellMouseClick);
            // 
            // valuesInBag_gridview
            // 
            this.valuesInBag_gridview.AllowUserToAddRows = false;
            this.valuesInBag_gridview.AllowUserToDeleteRows = false;
            this.valuesInBag_gridview.AllowUserToOrderColumns = true;
            this.valuesInBag_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.valuesInBag_gridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.valuesInBag_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.valuesInBag_gridview.Location = new System.Drawing.Point(37, 261);
            this.valuesInBag_gridview.MultiSelect = false;
            this.valuesInBag_gridview.Name = "valuesInBag_gridview";
            this.valuesInBag_gridview.ReadOnly = true;
            this.valuesInBag_gridview.RowTemplate.Height = 24;
            this.valuesInBag_gridview.Size = new System.Drawing.Size(940, 346);
            this.valuesInBag_gridview.TabIndex = 1;
            // 
            // DataBags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1020, 651);
            this.Controls.Add(this.valuesInBag_gridview);
            this.Controls.Add(this.DataBags_gridview);
            this.Name = "DataBags";
            this.Text = "DataBags";
            this.Controls.SetChildIndex(this.DataBags_gridview, 0);
            this.Controls.SetChildIndex(this.valuesInBag_gridview, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DataBags_gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valuesInBag_gridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataBags_gridview;
        private System.Windows.Forms.DataGridView valuesInBag_gridview;
    }
}