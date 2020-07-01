using Opc.Ua;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocalApplicationDataGathering.Pinging;

namespace LocalApplicationDataGathering
{
    public partial class Form1 : Form
    {
        //  private bool disconnected = false;
      private bool _disconnected;
      public bool disconneced
        {
            get { return _disconnected;  }
            set
            {
                _disconnected = value;
                if(_disconnected == true)
                {
                    Console.WriteLine("disconnected!");
                    OpcUastartup.Instance.disconnect();
                    OpcUastartup.Instance.SetStatus(false);

                }
            }
        }
        private System.Windows.Forms.Timer timer1;
        private int counter = 300; // changes only to tests

        

        public TextBox GetTextbox()
        {
               return textBox1;
        }
        public Form1()
        {
            InitializeComponent();

            TimeCounter counter = new TimeCounter();
            this.Startcounting();

            if (OpcUastartup.Instance.GetStatus() == true)
            {
                
                    List<string> nodesToRead = new List<string>();
                    List<string> results = new List<string>();

                    nodesToRead.Add(new NodeId("/Channel/ProgramInfo/selectedWorkPProg[u1,1]", 2).ToString());

                    results = OpcUastartup.Instance.get_m_server().ReadValues(nodesToRead);

                
                   status_textbox.Text = results[0];

            

            }
            else if (OpcUastartup.Instance.GetStatus() == false)
             {
                status_textbox.Text = "dfgdgdg";
              }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void status_textbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ComplexPing.getPingStatus() == true)
            {
                if (OpcUastartup.Instance.CheckServerConnection() == true)
                {
                    List<string> nodesToRead = new List<string>();
                    List<string> results = new List<string>();

                    nodesToRead.Add(new NodeId("/Channel/ProgramInfo/selectedWorkPProg[u1,1]", 2).ToString());

                    results = OpcUastartup.Instance.get_m_server().ReadValues(nodesToRead);


                    status_textbox.Text = results[0];


                }
                else
                {
                    Console.WriteLine("nie mozna odczytac1");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ComplexPing.getPingStatus() == true)
            {
                if (OpcUastartup.Instance.CheckServerConnection() == true)
                {
                    List<string> nodesToRead = new List<string>();
                    List<string> results = new List<string>();

                    nodesToRead.Add(new NodeId("/Plc/IB0", 2).ToString());

                    results = OpcUastartup.Instance.get_m_server().ReadValues(nodesToRead);

                    status_textbox.Text = results[0];
                }
                else
                {
                    Console.WriteLine("Cannot be readed");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("SImple change to test Branching");

        }



        /////////////////////// TIMER

        private  void Startcounting()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
            textBox1.Text = counter.ToString();

        }

        private bool bitWystawiony = false;
        private  void timer1_Tick(object sender, EventArgs e)
        {
          
           
            counter--;
            if (counter == 0)
            {
                //timer1.Stop();
                counter = 10;

            }

            ComplexPing.Ping_function();
            Ping_status.Text = ComplexPing.getPingStatus().ToString();

            bool status = OpcUastartup.Instance.GetStatus();
            Console.WriteLine("current state of OPC connection" + status);
            connection_status_textbox.Text = status.ToString();


            // if opc is commented or its was not started pararerly with whole application
            if (OpcUastartup.Instance.getServerConnection() == true)
            {
                if (ComplexPing.getPingStatus() == false && disconneced == false)
                {
                    disconneced = true;
                }
                else if (ComplexPing.getPingStatus() == true && disconneced == true && bitWystawiony == false && OpcUastartup.Instance.GetStatus() == false)
                {
                    bitWystawiony = true;
                    OpcUastartup.Instance.reconnect();
                    Console.WriteLine("------------------------------WYSTAWIONO POLACZENIE!---------------------");
                    bitWystawiony = false;
                }

                if (disconneced == true)
                {
                    // check opc statusm, if false try to reconnect
                }

            }
            textBox1.Text = counter.ToString();
        }

        private void Ping_button_Click(object sender, EventArgs e)
        {
        }

        private void connection_status_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ping_status_TextChanged(object sender, EventArgs e)
        {

        }

        private void allParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
        }

        private void dataGatheringParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parameters_DataGathering_form DataGathering_form = new Parameters_DataGathering_form();
            DataGathering_form.ShowDialog();
        }

        private void addPLCParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parameters_PLC_NC_form PLC_NC_form = new Parameters_PLC_NC_form();
            PLC_NC_form.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //////////////////////////////////

    }
}
