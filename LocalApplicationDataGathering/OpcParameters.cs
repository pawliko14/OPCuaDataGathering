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
    public partial class Opc_parameters_form : Form
    {
        public delegate void formCLoser();

        private static System.Timers.Timer DummyTimer = null;
        public Opc_parameters_form()
        {
            InitializeComponent();

            Shown += Opc_parameters_form_shown;

        }

        private void Opc_parameters_form_shown(object sender, EventArgs e)
        {
           // MessageBox.Show("sohnw!", "existing forms");

            this.Startcounting();

        }

        private void timer_tick(object sender, EventArgs e)
        {

            OpcTimeOut_value.BeginInvoke(new Action(delegate ()
            {
               OpcTimeOut_value.Text = OpcUastartup.Instance.getOpcTimeout().ToString();
               
            }));

            SessionId_box.BeginInvoke(new Action(delegate ()
            {
                SessionId_box.Text = OpcUastartup.Instance.getSessionName();
            }));

        }

        private void Startcounting()
        {
            DummyTimer = new System.Timers.Timer(500 * 1); // 5 sec interval
            DummyTimer.Enabled = true;
            DummyTimer.Elapsed += new System.Timers.ElapsedEventHandler(timer_tick);
            DummyTimer.AutoReset = true;

            DummyTimer.Start();
            OpcTimeOut_value.Text = OpcUastartup.Instance.getOpcTimeout().ToString();

        }

        public  void close_all()
        {
            DummyTimer.Stop();
            this.Dispose();
            this.Close();
           
        }

        private void close_Click(object sender, EventArgs e)
        {
            DummyTimer.Stop();
            this.Dispose();
            this.Close();
        }

   
    }
}
