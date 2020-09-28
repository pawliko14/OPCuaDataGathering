
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Npgsql;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string val = null;

            PostgresConnection databaseConnection = new PostgresConnection();

            databaseConnection.connection().Open();

            NpgsqlCommand cmd = new NpgsqlCommand("select count(*) from existing_bags eb   ", databaseConnection.connection());
            NpgsqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                val = rdr.GetString(0);
            }
            //       Console.WriteLine("----------------asdsdass");

            Assert.Equals("4", val);
        }
    }

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
            string server_connection = "Server=" + this.server + "; Port=" + this.port + "; User Id=" + this.user + "; Password=" + this.password + "; Database=" + this.database + "";

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
