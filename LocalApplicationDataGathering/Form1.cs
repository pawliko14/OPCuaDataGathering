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

using LocalApplicationDataGathering.InifinityLoop;
using Opc.Ua.Client;

namespace LocalApplicationDataGathering
{
    public partial class Form1 : Form
    {
        private static System.Timers.Timer DummyTimer = null;
        private Dictionary<string, int> existing_bags;

        private List<infinite_loops> inifite_loop_list;


     
        public Form1()
        {
            inifite_loop_list = new List<infinite_loops>();

            InitializeComponent();

            createBag();
            addInifniteLoop_to_Bag();
            start_every_ininiftyLoop_in_Bag_if_no_empty();

           

            this.Startcounting();
        }


        private void start_every_ininiftyLoop_in_Bag_if_no_empty()
        {
            for (int i = 0; i < inifite_loop_list.Count(); i++)
            {
                if(records_exists_in_table(inifite_loop_list.ElementAt(i)))
                  inifite_loop_list.ElementAt(i).initizalizer();
            }
            
        }

        private bool records_exists_in_table(infinite_loops infinite_loops)
        {

            PostgresConnection con = new PostgresConnection();
            con.connection().Open();

             NpgsqlCommand cmd = new NpgsqlCommand("SELECT CASE WHEN EXISTS (SELECT * FROM "+ infinite_loops.getTable_name() + " LIMIT 1) THEN 1 ELSE 0 END", con.connection());
             NpgsqlDataReader rdr = cmd.ExecuteReader();

            int value = -1;
            while (rdr.Read())
            {
                value = rdr.GetInt16(0);
            }

            rdr.Close();
            con.connection().Close();

            return value == 1 ? true : false;
        }

  

        private void addInifniteLoop_to_Bag()
        {
            foreach (KeyValuePair<string, int> kvp in existing_bags)
                inifite_loop_list.Add(new infinite_loops(kvp.Value, kvp.Key));
            
        }

        private void createBag()
        {
            existing_bags = new Dictionary<string, int>();

            string varu = null;
            PostgresConnection con = new PostgresConnection();

            con.connection().Open();

            //  NpgsqlCommand cmd = new NpgsqlCommand("select var_table , gather_data_time  from existing_bags eb order by id ", con.connection());

            // testting purpose
            NpgsqlCommand cmd = new NpgsqlCommand("select var_table , gather_data_time from existing_bags eb where alive  = true order by id ", con.connection());


            NpgsqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                varu = rdr.GetString(0);
                existing_bags.Add(rdr.GetString(0), rdr.GetInt32(1));
            }
            rdr.Close();
        }


    

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipText = "some notification";
            notifyIcon1.Text = "Application name";
            notifyIcon1.BalloonTipTitle = "name of application";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("SImple change to test Branching");

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



        private void button4_Click(object sender, EventArgs e)
        {
            // testing to change time beteewn getting value
            inifite_loop_list.ElementAt(3).setCounter(1500);

        }

        private void timer_tick(object sender, EventArgs e)
        {

            //timerBox.Invoke(new Action(delegate()
            //{
            //    timerBox.Text = infloop.getCounter().ToString();
            //}));

            //Ping_status.Invoke(new Action(delegate ()
            //{
            //    Ping_status.Text = infloop.getPing_status();
            //}));

            //timerBox2.Invoke(new Action(delegate ()
            //{
            //    timerBox2.Text = inf_loop_2.getCounter().ToString();
            //}));

        }

        private void Startcounting()
        {
            DummyTimer = new System.Timers.Timer(1000 * 1); // 5 sec interval
            DummyTimer.Enabled = true;
            DummyTimer.Elapsed += new System.Timers.ElapsedEventHandler(timer_tick);
            DummyTimer.AutoReset = true;

            DummyTimer.Start();
         //   timerBox.Text = infloop.getCounter().ToString();

        }

        private void oPCParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Opc_parameters_form PLC_NC_form = new Opc_parameters_form();
            PLC_NC_form.ShowDialog();
        }

     

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Minimized)
            {


                ShowIcon = false;
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            }
        
        }

        private void notifyIcon1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }

        private void branch1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Testing_modern testing_Modern_form = new Testing_modern();
            testing_Modern_form.ShowDialog();
        }

        private void branch2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modern_new_version t = new modern_new_version();
            t.ShowDialog();
        }

        private void testing_add_record_Click(object sender, EventArgs e)
        {
            string temporarty_bag_record = null;
            temporarty_bag_record = "test_record";

            
            PostgresConnection con = new PostgresConnection();

            con.connection().Open();

            NpgsqlCommand cmd = new NpgsqlCommand("select var_table   from existing_bags eb order by id ", con.connection());
            NpgsqlDataReader rdr = cmd.ExecuteReader();

            bool table_already_exists = false;
            while (rdr.Read())
            {
                if (rdr.GetString(0).Equals(temporarty_bag_record))
                    table_already_exists = true;

            }
                        rdr.Close();


            if(table_already_exists == false)
            {
                //   NpgsqlCommand cmd_2 = new NpgsqlCommand("insert into existing_bags(var_table, alive, gather_data_time) values('"+ temporarty_bag_record + "',true,2000 ", con.connection());
                // NpgsqlDataReader rdr_2 = cmd_2.ExecuteReader();


                using (var cmd_2 = new NpgsqlCommand("insert into existing_bags(var_table, alive, gather_data_time) values(@p1,@p2,@p3)", con.connection()))
                {

                    cmd_2.Parameters.Add(new NpgsqlParameter("p1", NpgsqlTypes.NpgsqlDbType.Text));
                    cmd_2.Parameters.Add(new NpgsqlParameter("p2", NpgsqlTypes.NpgsqlDbType.Boolean));
                    cmd_2.Parameters.Add(new NpgsqlParameter("p3", NpgsqlTypes.NpgsqlDbType.Integer));

                    cmd_2.Parameters[0].Value = temporarty_bag_record;
                    cmd_2.Parameters[1].Value = true;
                    cmd_2.Parameters[2].Value = 2000;

                    cmd_2.ExecuteNonQuery();
                }
                infinite_loops inf_temp = new infinite_loops(2000, temporarty_bag_record);

                inifite_loop_list.Add(inf_temp);


                create_additional_table(temporarty_bag_record,con);
                MessageBox.Show("table created", "Database information", MessageBoxButtons.OK);

                insert_example_values_to_table(temporarty_bag_record, con);
                MessageBox.Show("values added", "Database information", MessageBoxButtons.OK);


                inf_temp.initizalizer();
                MessageBox.Show("loop initialized", "Database information", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Rekord aleady exists", "Database information", MessageBoxButtons.OK);
            }


            con.connection().Close();
        }

        private void insert_example_values_to_table(string temporarty_bag_record, PostgresConnection con)
        {
            var m_createdb_cmd = new NpgsqlCommand(@"insert into "+ temporarty_bag_record + @" 
                                                    (var ,var_meaning ,created_on ,last_changed_date ,status ,var_path ,value ,last_changed_time )
                                                    values ('MB5','testing','2020-07-21','2020-07-21',true,'/Plc/','true','15:20:20')"
                                                    , con.connection());

            m_createdb_cmd.ExecuteNonQuery();
        }

        private void create_additional_table(string temporarty_bag_record, PostgresConnection con)
        {
            /*
             *  CAREFUL, SQL INJECTION RIGHT BELOW! CORRECT IT!
             */
            var m_createdb_cmd = new NpgsqlCommand(@"create table if not exists " + temporarty_bag_record + @"
                                                    (
                                                    id serial primary key,
                                                    last_changed_time varchar(255) not null,
                                                    status varchar(255) not null,
                                                    var varchar(255) not null,
                                                    last_changed_date varchar(255) not null,
                                                    var_meaning varchar(255) not null,
                                                    value varchar(255) not null,
                                                    var_path varchar(255) not null,
                                                    created_on varchar(255) not null
                                                    )", con.connection());

            m_createdb_cmd.ExecuteNonQuery();
        }

        private void stop_bag_gathering_Click(object sender, EventArgs e)
        {
           string table_name =  inifite_loop_list.ElementAt(2).getTable_name();

            inifite_loop_list.ElementAt(2).stop_working();

            MessageBox.Show("table "+ table_name + " stopped working", "Database information", MessageBoxButtons.OK);

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
