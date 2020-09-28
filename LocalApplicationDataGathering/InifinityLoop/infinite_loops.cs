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
using System.Data.SqlClient;
using System.Timers;

namespace LocalApplicationDataGathering.InifinityLoop
{
    

    class infinite_loops
    {

        //  private bool disconnected = false;
        private bool _disconnected;
        private  System.Timers.Timer DummyTimer = null;

        private int counter; // changes only to tests
        private string table_name;

        private string ping_status= null;
        private OpcVairables opcVariables;


        private DateTime now = DateTime.Now;
        private string datetime = DateTime.Today.ToString();


        private bool bitWystawiony = false;


        public infinite_loops(int c, string tb_name)
        {
            counter = c;
            table_name = tb_name;
        }

        public string getTable_name()
        {
            return table_name;
        }

        public int getCounter()
        {
            return counter;
        }

        public void setCounter(int value)
        {
            counter = value;

            this.DummyTimer.Enabled = false;
            this.DummyTimer.Stop();

            this.DummyTimer.Interval = value;
            this.DummyTimer.Enabled = true;
            this.DummyTimer.Start();

            opcVariables.update_counter_database(value);

        }

        public string getPing_status()
        {
            return ping_status;
        }

        public bool disconneced
        {
            get { return _disconnected; }
            set
            {
                _disconnected = value;
                if (_disconnected == true)
                {
                    Console.WriteLine("disconnected!");
                    OpcUastartup.Instance.disconnect();
                    OpcUastartup.Instance.SetStatus(false);

                }
            }
        }



        public void initizalizer()
        {
            if (OpcUastartup.Instance.GetStatus() == true)
            {

                opcVariables = new OpcVairables(table_name);
            }

            TimeCounter counter = new TimeCounter();
            this.Startcounting();
        }


        /* testowy */





            /* koniec testowy */


        /////////////////////// TIMER

        private void Startcounting()
        {
            this.DummyTimer = new System.Timers.Timer(counter * 1); // 5 sec interval
            this.DummyTimer.Enabled = true;
            this.DummyTimer.Elapsed += new System.Timers.ElapsedEventHandler(timer1_Tick);
            this.DummyTimer.AutoReset = true;

            this.DummyTimer.Start();

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            now = DateTime.Now;
            datetime = DateTime.Today.ToString();

            this.counter--;
            if (this.counter == 0)
            {
                this.counter = 10;
            }

            ComplexPing.Ping_function();
             ping_status = ComplexPing.getPingStatus().ToString();

     

            bool status = OpcUastartup.Instance.GetStatus();
            Console.WriteLine("current state of OPC connection" + status + " timer tick : " + this.counter.ToString());




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


            opcVariables.pushMap_to_database();
            opcVariables.GatherData_save_to_databse();

        }

        internal void stop_working()
        {
            this.DummyTimer.Stop();
            this.DummyTimer.Enabled = false;
            
        }

        internal void restart_working()
        {
            this.DummyTimer.Start();
            this.DummyTimer.Enabled = true;

        }

        //private void pushElemToDatabase(string temp, PostgresConnection databaseConnection)
        //{
        //    NpgsqlCommand cmd = new NpgsqlCommand("insert into plc_data_variables (plc_var ,plc_var_meaning ,created_on ,last_changed_date ,status ,plc_var_path ,value ,last_changed_time ) values ('" + temp + "','" + temp + "','2020-07-21','" + datetime + "',true,'/Plc/','true','15:20:20') ", databaseConnection.connection());
        //    NpgsqlDataReader rdr = cmd.ExecuteReader();
        //    rdr.Close();
        //}

    }
}
