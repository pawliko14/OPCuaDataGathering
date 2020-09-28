using Microsoft.VisualStudio.TestTools.UnitTesting;

using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        Dictionary<string, int> existing_bags;

        [TestMethod]
        public void TestMethod1()
        {
                   


          string varu = null;
            PostgresConnection con = new PostgresConnection();

            con.connection().Open();

            //NpgsqlCommand cmd = new NpgsqlCommand("select var_table from existing_bags eb  limit 1 ", con.connection());
            //NpgsqlDataReader rdr = cmd.ExecuteReader();

            //while (rdr.Read())
            //{
            //     varu = rdr.GetString(0);

            //}
            //CreateBag();
            //foreach (KeyValuePair<string, int> kvp in existing_bags)
            //{ 
            //    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            //}

            //rdr.Close();

            //     update_test();

            create_additional_table("dupa", con);


            Assert.AreEqual("plc_data_variables", varu);
        }


        private void CreateBag()
        {
            existing_bags = new Dictionary<string, int>();

            string varu = null;
            PostgresConnection con = new PostgresConnection();

            con.connection().Open();

            NpgsqlCommand cmd = new NpgsqlCommand("select var_table , gather_data_time  from existing_bags eb ", con.connection());
            NpgsqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                varu = rdr.GetString(0);
                existing_bags.Add(rdr.GetString(0), rdr.GetInt32(1));
            }
            rdr.Close();
        }

        private void update_test()
        {
            PostgresConnection databaseConnection; //= new PostgresConnection();

            databaseConnection = new PostgresConnection();
            databaseConnection.connection().Open();

            var cmd = new NpgsqlCommand("update existing_bags set gather_data_time =:p1  where var_table  =:p2 ", databaseConnection.connection());

            // cmd.Parameters.AddWithValue("p1", (now.TimeOfDay).ToString());
            cmd.Parameters.Add(new NpgsqlParameter("p1", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(new NpgsqlParameter("p2", NpgsqlTypes.NpgsqlDbType.Text));


            cmd.Parameters[0].Value = 1000;
            cmd.Parameters[1].Value = "plc_data_variables";


            cmd.Prepare();
            cmd.ExecuteNonQuery();



            databaseConnection.connection().Close();
        }


        private void create_additional_table(string temporarty_bag_record, PostgresConnection con)
        {
      


            /*
             *  CAREFUL, SQL INJECTION RIGHT BELOW! CORRECT IT!
             */

            var m_createdb_cmd = new NpgsqlCommand(@"create table if not exists "+ temporarty_bag_record + @"
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

        //   m_createdb_cmd.Parameters.Add(new NpgsqlParameter("p1", NpgsqlTypes.NpgsqlDbType.Text));
       //    m_createdb_cmd.Parameters[0].Value = temporarty_bag_record;
            m_createdb_cmd.ExecuteNonQuery();
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
