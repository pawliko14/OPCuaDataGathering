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
using LocalApplicationDataGathering.App_start;
using Npgsql;
using System.Threading;
using LocalApplicationDataGathering.Opc;

namespace LocalApplicationDataGathering
{
    public partial class Form1 : Form
    {
        //  private bool disconnected = false;
        private bool _disconnected;
        private static System.Timers.Timer DummyTimer = null;
        private int counter = 300; // changes only to tests
        private bool database_connection = false;
        private OpcVairables opcVariables;

        // TEMPORARY TO DELETE LATER 
        private string value_to_READ = null;

        public  bool  disconneced
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

                opcVariables = new OpcVairables();
                status_textbox.Text = opcVariables.getRecordFromResults(0);
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
            DummyTimer = new System.Timers.Timer(1000 * 1); // 5 sec interval
            DummyTimer.Enabled = true;
            DummyTimer.Elapsed += new System.Timers.ElapsedEventHandler(timer1_Tick);
            DummyTimer.AutoReset = true;

            DummyTimer.Start();
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
         //   Ping_status.Text = ComplexPing.getPingStatus().ToString();

            Ping_status.Invoke(new Action(delegate ()
            {
                Ping_status.Text = ComplexPing.getPingStatus().ToString();
            }));

                    bool status = OpcUastartup.Instance.GetStatus();
                    Console.WriteLine("current state of OPC connection" + status);



            
            connection_status_textbox.Invoke(new Action(delegate ()
            {
                connection_status_textbox.Text = status.ToString();
            }));


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
            GatherData_save_to_databse();

           


            textBox1.Invoke(new Action(delegate ()
            {
                textBox1.Text = counter.ToString();
            }));
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void GatherData_save_to_databse()
        {
            PostgresConnection databaseConnection = new PostgresConnection();

            databaseConnection.connection().Open();

            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM users", databaseConnection.connection());
            NpgsqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                database_connection = true;
                Console.WriteLine("connection established");

                // temporary to delete, pushing example data to sql :



            }
            if (database_connection == false)
            {
                Console.WriteLine("data does not exist");
            }
            else
            {
                Console.WriteLine("problem with connections");
            }

            dr.Close();

            NpgsqlCommand command = new NpgsqlCommand("insert into nc_data (nc_var ,nc_value, measure_time, measure_date, status) values ('selectedWorkPProg[u1,1]','" + value_to_READ + "', '12:30:54', '2020-07-10', true)", databaseConnection.connection());
            NpgsqlDataReader datareader = command.ExecuteReader();
            datareader.Close();

            DateTime now = DateTime.Now;
            string datetime = DateTime.Today.ToString();


         

            foreach (var pair in opcVariables.getMap())
            {
                command = new NpgsqlCommand("update plc_data_variables set last_changed_time = '" + now.TimeOfDay + "', value = '" + pair.Value + "', last_changed_date = '" + datetime + "' where plc_var  = '" + pair.Key + "'", databaseConnection.connection());
                datareader = command.ExecuteReader();
                datareader.Close();
            }
                databaseConnection.connection().Close();
        }


        private void button4_Click(object sender, EventArgs e)
        {

            // empty, previously save to database, migrated to another function
          

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
      
            
        }

        //////////////////////////////////

    }
}
