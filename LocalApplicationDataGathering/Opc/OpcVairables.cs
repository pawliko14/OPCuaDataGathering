
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.Ua;

namespace LocalApplicationDataGathering.Opc
{
    class OpcVairables
    {
       private  List<string> nodesToRead = new List<string>();
       private  List<string> results = new List<string>();
       private Dictionary<string, string> map = new Dictionary<string, string>();


        public string getRecordFromResults(int index)
        {
            return this.results[index];
        }

        public Dictionary<string, string> getMap()
        {
            return this.map;
        }

        
        public void addElemtoResults(string fullName_and_chanell,string variable)
        {
            string value_to_save = new NodeId(fullName_and_chanell, 2).ToString();
            nodesToRead.Add(value_to_save);
            results = OpcUastartup.Instance.get_m_server().ReadValues(nodesToRead);

            // adding to map
            map.Add(variable, results.Last());


        }

        public OpcVairables()
        {
            nodesToRead.Add(new NodeId("/Channel/ProgramInfo/selectedWorkPProg[u1,1]", 2).ToString());
            nodesToRead.Add(new NodeId("/Plc/IB3", 2).ToString());
            nodesToRead.Add(new NodeId("/Plc/IB0", 2).ToString());
            nodesToRead.Add(new NodeId("/Plc/Q2.0", 2).ToString());
            nodesToRead.Add(new NodeId("/Plc/Q2.1", 2).ToString());
            nodesToRead.Add(new NodeId("/Plc/Q1.6", 2).ToString());
            nodesToRead.Add(new NodeId("/Plc/Q1.7", 2).ToString());
            nodesToRead.Add(new NodeId("/Plc/Q204.2", 2).ToString());
            nodesToRead.Add(new NodeId("/Plc/Q204.1", 2).ToString());
            nodesToRead.Add(new NodeId("/Plc/Q204.0", 2).ToString());
            nodesToRead.Add(new NodeId("/Plc/DB36.DBX64.7", 2).ToString());
            nodesToRead.Add(new NodeId("/Plc/DB36.DBX64.6", 2).ToString());
            nodesToRead.Add(new NodeId("/Plc/DB34.DBX64.7", 2).ToString());
            nodesToRead.Add(new NodeId("/Plc/DB34.DBX64.6", 2).ToString());
            nodesToRead.Add(new NodeId("/Plc/DB33.DBX64.7", 2).ToString());
            nodesToRead.Add(new NodeId("/Plc/DB33.DBX64.6", 2).ToString());
            nodesToRead.Add(new NodeId("/Plc/DB32.DBX64.7", 2).ToString());
            nodesToRead.Add(new NodeId("/Plc/DB32.DBX64.6", 2).ToString());

            nodesToRead.Add(new NodeId("/Plc/DB31.DBX64.7", 2).ToString());
            nodesToRead.Add(new NodeId("/Plc/DB31.DBX64.6", 2).ToString());
            nodesToRead.Add(new NodeId("/Plc/DB21.DBX35.0", 2).ToString());
            nodesToRead.Add(new NodeId("/Plc/DB10.DBX56.5", 2).ToString());
            nodesToRead.Add(new NodeId("/Plc/DB10.DBX56.6", 2).ToString());
            nodesToRead.Add(new NodeId("/Plc/DB10.DBX56.7", 2).ToString());
            nodesToRead.Add(new NodeId("/Plc/DB11.DBX6.0", 2).ToString());
            nodesToRead.Add(new NodeId("/Plc/DB11.DBX6.1", 2).ToString());
            nodesToRead.Add(new NodeId("/Plc/DB11.DBX6.2", 2).ToString());
            nodesToRead.Add(new NodeId("/Plc/DB11.DBX7.2", 2).ToString());



            results = OpcUastartup.Instance.get_m_server().ReadValues(nodesToRead);

            map.Add("selectedWorkPProg[u1,1]", results[0]);
            map.Add("IB3", results[1]);
            map.Add("IB0", results[2]);
            map.Add("Q2.0", results[3]);
            map.Add("Q2.1", results[4]);
            map.Add("Q1.6", results[5]);
            map.Add("Q1.7", results[6]);
            map.Add("Q204.2", results[7]);
            map.Add("Q204.1", results[8]);
            map.Add("Q204.0", results[9]);
            map.Add("DB36.DBX64.7", results[10]);
            map.Add("DB36.DBX64.6", results[11]);
            map.Add("DB34.DBX64.7", results[12]);
            map.Add("DB34.DBX64.6", results[13]);
            map.Add("DB33.DBX64.7", results[14]);
            map.Add("DB33.DBX64.6", results[15]);
            map.Add("DB32.DBX64.7", results[16]);
            map.Add("DB32.DBX64.6", results[17]);

            map.Add("DB31.DBX64.7", results[18]);
            map.Add("DB31.DBX64.6", results[19]);
            map.Add("DB21.DBX35.0", results[20]);
            map.Add("DB10.DBX56.5", results[21]);
            map.Add("DB10.DBX56.6", results[22]);
            map.Add("DB10.DBX56.7", results[23]);
            map.Add("DB11.DBX6.0", results[24]);
            map.Add("DB11.DBX6.1", results[25]);
            map.Add("DB11.DBX6.2", results[26]);
            map.Add("DB11.DBX7.2", results[27]);
        }

    }
}
*/


 
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



        public string getRecordFromResults(int index)
        {
            return this.results[index];
        }

        public Dictionary<string, string> getMap()
        {
            return this.map;
        }

        
        public void addElemtoResults(string fullName_and_chanell,string variable)
        {
            string value_to_save = new NodeId(fullName_and_chanell, 2).ToString();
            nodesToRead.Add(value_to_save);
            results = OpcUastartup.Instance.get_m_server().ReadValues(nodesToRead);

            // adding to map
            map.Add(variable, results.Last());


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





