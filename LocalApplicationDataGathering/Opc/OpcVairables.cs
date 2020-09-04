
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocalApplicationDataGathering.App_start;
using Npgsql;
using Opc.Ua;

namespace LocalApplicationDataGathering.Opc
{
    class OpcVairables
    {
       private  List<string> nodesToRead = new List<string>();
       private  List<string> results = new List<string>();
       private Dictionary<string, string> map = new Dictionary<string, string>();

        private Dictionary<string, string> map_from_database = new Dictionary<string, string>();


        public bool CheckIfVarExists(string variable)
        {
            string nodeToRead = new NodeId(variable, 2).ToString();

           if( OpcUastartup.Instance.get_m_server().CheckIfValueIsReadable(nodeToRead) == true)
            {
                return true;
            }
           else
            {
                return false;
            }

        }

        public string getRecordFromResults(int index)
        {
            return this.results[index];
        }

        public Dictionary<string, string> getMap()
        {
            return this.map;
        }


        public List<string> get_nodesToRead_results()
        {
          return this.results = OpcUastartup.Instance.get_m_server().ReadValues(nodesToRead);

        }

        public void addElemtoResults(string fullName_and_chanell,string variable)
        {
            string value_to_save = new NodeId(fullName_and_chanell, 2).ToString();
            nodesToRead.Add(value_to_save);
            results = OpcUastartup.Instance.get_m_server().ReadValues(nodesToRead);

            // adding to map
            this.map.Add(variable, results.Last());




        }

        public void  pushMap_to_database()
        {        
            results = OpcUastartup.Instance.get_m_server().ReadValues(nodesToRead);

            int index = 0;
            foreach (var pair in this.map_from_database)
            {
              //  map.Add(pair.Key, results[index]);

                map[pair.Key] = results[index];
                
                index++;
            }
        }

      

        public OpcVairables()
        {

         //   List<string> list_of_var_indatabase = new List<string>();

            // empty, previously save to database, migrated to another function
            PostgresConnection databaseConnection = new PostgresConnection();

            databaseConnection.connection().Open();

            NpgsqlCommand cmd = new NpgsqlCommand("SELECT plc_var_path , plc_var FROM plc_data_variables pdv  ", databaseConnection.connection());
            NpgsqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                map_from_database.Add(rdr.GetString(1), rdr.GetString(0));
            }
            rdr.Close();
          //  databaseConnection.CloseAllConnetions();

            foreach (var pair in this.map_from_database)
            {
                string dup = pair.Value;
                string dupa = pair.Key;

                nodesToRead.Add(new NodeId(pair.Value + pair.Key, 2).ToString());
            }

            //finall result of collected items gathered by OPC_server
            results = OpcUastartup.Instance.get_m_server().ReadValues(nodesToRead);

            int index = 0;
            foreach (var pair in this.map_from_database)
            {
                map.Add(pair.Key, results[index]);
                index++;
            }

          
        }

    }
}





