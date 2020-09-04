using LocalApplicationDataGathering.App_start;
using LocalApplicationDataGathering.Opc;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Configuration;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalApplicationDataGathering
{
    public partial class Parameters_PLC_NC_form : Form
    {
       private OpcVairables opcvar = new OpcVairables();

        public Parameters_PLC_NC_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //check if plc/nc variable exists

            string variable = prefix.Text + variable_name.Text;

            if (prefix.Text.Equals("") || variable_name.Text.Equals(""))
            {
                MessageBox.Show("prefix and variable name must be fulfilled");
            }
            else
            {
                if (opcvar.CheckIfVarExists(variable) == true)
                {
                    MessageBox.Show("Record Exists, can be pushed to database");

                }
            }



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            List<string> list_of_var_in_database = new List<string>();

            // empty, previously save to database, migrated to another function
            PostgresConnection databaseConnection = new PostgresConnection();

            databaseConnection.connection().Open();

            //     NpgsqlCommand cmd = new NpgsqlCommand("select plc_var from plc_data_variables order by id_var", databaseConnection.connection());
            //     NpgsqlDataReader rdr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            //   SqlDataAdapter da = new SqlDataAdapter("select plc_var from plc_data_variables order by id_var", databaseConnection.connection());

            //   NpgsqlDataAdapter da = new NpgsqlDataAdapter("select concat(plc_var_path , plc_var) as var from plc_data_variables  order by id_var ", databaseConnection.connection());

            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select id_var  , concat(plc_var_path , plc_var) as var, created_on  da from plc_data_variables order by id_var", databaseConnection.connection());


            da.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = true;

            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = 32;

            DataGridViewColumn column2 = dataGridView1.Columns[1];
            column2.Width = 110;

            DataGridViewColumn column3 = dataGridView1.Columns[2];
            column3.Width = 110;





        }

        private void current_plc_nc_var_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
