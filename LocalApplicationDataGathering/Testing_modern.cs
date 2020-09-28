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
    public partial class Testing_modern : Form
    {
        public Testing_modern()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

 

        private void button_connections_Click(object sender, EventArgs e)
        {
            Backlight.Height = button_connections.Height;
            Backlight.Top = button_connections.Top;
        }

        private void button_help_Click(object sender, EventArgs e)
        {
            Backlight.Height = button_help.Height;
            Backlight.Top = button_help.Top;
        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            Backlight.Height = button_quit.Height;
            Backlight.Top = button_quit.Top;
        }

        private void button_params_Click(object sender, EventArgs e)
        {
            Backlight.Height = button_params.Height;
            Backlight.Top = button_params.Top;
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            Backlight.Height = button_home.Height;
            Backlight.Top = button_home.Top;
        }
    }
}
