
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocalApplicationDataGathering.App_start;
using Npgsql;
using Opc.Ua;
using Opc.Ua.Client;
using NotificationEventHandler = Opc.Ua.Client.NotificationEventHandler;

namespace LocalApplicationDataGathering.Opc
{
    class OpcVairables
    {
        private readonly string  table_name;


       private  List<string> nodesToRead = new List<string>();
       private  List<string> results = new List<string>();


        private Dictionary<string, string> map_plc = new Dictionary<string, string>();
        private Dictionary<string, string> map_from_database = new Dictionary<string, string>();

        public bool CheckIfVarExists(string variable)
        {
            string nodeToRead = new NodeId(variable, 2).ToString();
            return  OpcUastartup.Instance.get_m_server().CheckIfValueIsReadable(nodeToRead) == true ?  true :  false;

        }

        public string getRecordFromResults(int index)
        {
            return this.results[index];
        }

        public Dictionary<string, string> getMap_plc()
        {
            return this.map_plc;
        }



        public List<string> get_nodesToRead_results()
        {
            return this.results = OpcUastartup.Instance.get_m_server().ReadValues(nodesToRead);
        }



        //public void addElemtoResults(string fullName_and_chanell, string variable)
        //{
        //    string value_to_save = new NodeId(fullName_and_chanell, 2).ToString();
        //    nodesToRead.Add(value_to_save);
        //    results = OpcUastartup.Instance.get_m_server().ReadValues(nodesToRead);

        //    // adding to map
        //    this.map_plc.Add(variable, results.Last());
        //}

     

        //public void  pushMap_to_database()
        //{        
        //    results = OpcUastartup.Instance.get_m_server().ReadValues(nodesToRead);

        //    int index = 0;
        //    foreach (var pair in this.map_from_database)
        //    {
        //        map_plc[pair.Key] = results[index];
                
        //        index++;
        //    }          
        //}

      

        private void  AddPlcVariablesToMap(PostgresConnection con)
        {
           

            NpgsqlCommand cmd = new NpgsqlCommand("SELECT var_path , var FROM "+ table_name + " pdv  ", con.connection());
            NpgsqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                map_from_database.Add(rdr.GetString(1), rdr.GetString(0));
            }
            rdr.Close();


            foreach (var pair in this.map_from_database)
            {
                string dup = pair.Value;
                string dupa = pair.Key;

                nodesToRead.Add(new NodeId(pair.Value + pair.Key, 2).ToString());
            }
        }



        public OpcVairables(string tablename)
        {
            table_name = tablename;


            // empty, previously save to database, migrated to another function
            PostgresConnection databaseConnection = new PostgresConnection();

            databaseConnection.connection().Open();

            AddPlcVariablesToMap(databaseConnection);
            //finall result of collected items gathered by OPC_server
            results = OpcUastartup.Instance.get_m_server().ReadValues(nodesToRead);

            int index = 0;
            foreach (var pair in this.map_from_database)
            {
                map_plc.Add(pair.Key, results[index]);
                index++;
            }



            ////
            start_testing_SUBSCRYPTION();
            ////


        }

        //public void GatherData_save_to_databse()
        //{
        //    DateTime now = DateTime.Now;
        //    string datetime = DateTime.Today.ToString();
        //    PostgresConnection databaseConnection; //= new PostgresConnection();

        //    databaseConnection = new PostgresConnection();
        //    databaseConnection.connection().Open();

        //    // need to create lambda expression instead of foreach!
        //    // foreach (var pair in opcVariables.getMap())

        //    foreach (KeyValuePair<string, string> pair in this.getMap_plc())
        //    {
        //        var cmd = new NpgsqlCommand("update " + table_name + " set last_changed_time =:p1, value =:p2, last_changed_date =:p3 where var  =:p4 ", databaseConnection.connection());

        //        // cmd.Parameters.AddWithValue("p1", (now.TimeOfDay).ToString());
        //        cmd.Parameters.Add(new NpgsqlParameter("p1", NpgsqlTypes.NpgsqlDbType.Text));
        //        cmd.Parameters.Add(new NpgsqlParameter("p2", NpgsqlTypes.NpgsqlDbType.Text));
        //        cmd.Parameters.Add(new NpgsqlParameter("p3", NpgsqlTypes.NpgsqlDbType.Text));
        //        cmd.Parameters.Add(new NpgsqlParameter("p4", NpgsqlTypes.NpgsqlDbType.Text));

        //        cmd.Parameters[0].Value = (now.TimeOfDay).ToString();
        //        cmd.Parameters[1].Value = pair.Value;
        //        cmd.Parameters[2].Value = datetime.ToString();
        //        cmd.Parameters[3].Value = pair.Key;

        //        cmd.Prepare();
        //        cmd.ExecuteNonQuery();

        //    }

        //    databaseConnection.connection().Close();
        //}


        // ovverided
        public void GatherData_save_to_databse(string value,string path)
        {
            DateTime now = DateTime.Now;
            string datetime = DateTime.Today.ToString();
            PostgresConnection databaseConnection; //= new PostgresConnection();

            databaseConnection = new PostgresConnection();
            databaseConnection.connection().Open();

            try
            {

                var cmd = new NpgsqlCommand("update " + table_name + " set last_changed_time =:p1, value =:p2, last_changed_date =:p3 where var  =:p4 ", databaseConnection.connection());

                // cmd.Parameters.AddWithValue("p1", (now.TimeOfDay).ToString());
                cmd.Parameters.Add(new NpgsqlParameter("p1", NpgsqlTypes.NpgsqlDbType.Text));
                cmd.Parameters.Add(new NpgsqlParameter("p2", NpgsqlTypes.NpgsqlDbType.Text));
                cmd.Parameters.Add(new NpgsqlParameter("p3", NpgsqlTypes.NpgsqlDbType.Text));
                cmd.Parameters.Add(new NpgsqlParameter("p4", NpgsqlTypes.NpgsqlDbType.Text));

                cmd.Parameters[0].Value = (now.TimeOfDay).ToString();
                cmd.Parameters[1].Value = value;
                cmd.Parameters[2].Value = datetime.ToString();
                cmd.Parameters[3].Value = path;

                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }


            databaseConnection.connection().Close();
        }



        internal void update_counter_database(int value)
        {
            PostgresConnection databaseConnection; //= new PostgresConnection();

            databaseConnection = new PostgresConnection();
            databaseConnection.connection().Open();

                var cmd = new NpgsqlCommand("update existing_bags set gather_data_time =:p1  where var_table  =:p2 ", databaseConnection.connection());

                // cmd.Parameters.AddWithValue("p1", (now.TimeOfDay).ToString());
                cmd.Parameters.Add(new NpgsqlParameter("p1", NpgsqlTypes.NpgsqlDbType.Integer));
                cmd.Parameters.Add(new NpgsqlParameter("p2", NpgsqlTypes.NpgsqlDbType.Text));


                cmd.Parameters[0].Value = value;
                cmd.Parameters[1].Value = table_name;
 

                cmd.Prepare();
                cmd.ExecuteNonQuery();

            

            databaseConnection.connection().Close();
        }


        /// <summary>
        /// /////////////////////////////////////////////////////
        /// </summary>

        private void start_testing_SUBSCRYPTION()
        {
            monitor_values( 2000);

        }


        private void monitor_values(int subscribe_time)
        {
            // Check if we have a subscription 
            //  - No  -> Create a new subscription and create monitored items
            //  - Yes -> Delete Subcription

            //   OpcUastartup.Instance.get_m_Subscryption();
            if (OpcUastartup.Instance.get_m_Subscryption() == null)
            {
                try
                {
                    // Create subscription
                    OpcUastartup.Instance.set_Subscryption(OpcUastartup.Instance.get_m_server().Subscribe(subscribe_time));
                      OpcUastartup.Instance.get_m_server().ItemChangedNotification += new MonitoredItemNotificationEventHandler(ClientApi_ValueChanged);
                 //    OpcUastartup.Instance.get_m_server().ItemEventNotification += new NotificationEventHandler(ClientApi_ValueChanged_2);

                //    OpcUastartup.Instance.get_m_server().ItemEventNotification += new NotificationEventHandler(ClientApi_ValueChanged_2);

                    // Create first monitored item
                    int index = 0;
                    foreach (var pair in this.map_from_database)
                    {

                        OpcUastartup.Instance.get_m_server().AddMonitoredItem(OpcUastartup.Instance.get_m_Subscryption(), new NodeId(pair.Value + pair.Key, 2).ToString(), pair.Key, 2000);
                            index++; 
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                try
                {
                    OpcUastartup.Instance.get_m_server().RemoveSubscription(OpcUastartup.Instance.get_m_Subscryption());
                    OpcUastartup.Instance.set_Subscryption(null);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

      

        private void ClientApi_ValueChanged(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {
            try
            {
                //if (this.InvokeRequired)
                //{
                //    this.BeginInvoke(new MonitoredItemNotificationEventHandler(ClientApi_ValueChanged), monitoredItem, e);
                //    return;
                //}
                MonitoredItemNotification notification = e.NotificationValue as MonitoredItemNotification;
                if (notification == null)
                    return;

                

                //foreach (var pair in this.map_from_database)
                //{
                //    this.GatherData_save_to_databse(notification.Value.WrappedValue.ToString());
                // }

                for (int i = 0; i < monitoredItem.Subscription.MonitoredItemCount; i++)
                {
                    this.GatherData_save_to_databse(notification.Value.WrappedValue.ToString(), monitoredItem.DisplayName.ToString());

                }

            

            



                //if (monitoredItem.DisplayName == "item8")
                //{
                //    // Get the according item
                //  //  textBox5.Text = notification.Value.WrappedValue.ToString();
                //    this.GatherData_save_to_databse(notification.Value.WrappedValue.ToString());

                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }


}





