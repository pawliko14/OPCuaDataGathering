using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalApplicationDataGathering
{
    public partial class base_child_form : Form
    {
        

        public base_child_form()
        {
            InitializeComponent();

          //  this.Size = new Size(300, 300);

            //this.ClientSize = new System.Drawing.Size(200, 50);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
