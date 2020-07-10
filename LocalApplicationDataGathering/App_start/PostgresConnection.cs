using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalApplicationDataGathering.App_start
{

   public class PostgresConnection
    {
        private string server = "192.168.90.199";
        private string port = "5432";
        private string user = "Konrad";
        private string password = "IamTheKing";
        private string database = "machinedata";

        private NpgsqlConnection conn;

        public PostgresConnection()
        {
            string server_connection = "Server=" + this.server + "; Port="+this.port+"; User Id="+this.user+"; Password="+this.password+"; Database="+this.database+"";

            conn = new NpgsqlConnection(server_connection);
         }

        public NpgsqlConnection connection()
        {
            return conn;
        }

        public void CheckConnectionStatus()
        {
        // not implemented yet
        }

        public void CheckConnectionSettings()
        {
            // not implemented yet
        }

        public void CloseAllConnetions()
        {
            // not implemented yet
        }



    }
}
