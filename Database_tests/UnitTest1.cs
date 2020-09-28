
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Npgsql;
using System;

namespace Database_tests
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
}
