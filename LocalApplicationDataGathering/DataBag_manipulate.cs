using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using LocalApplicationDataGathering.App_start;
using LocalApplicationDataGathering.Opc;
using Npgsql;

namespace LocalApplicationDataGathering
{
    public partial class DataBag_manipulate : LocalApplicationDataGathering.base_child_form
    {
        public DataBag_manipulate()
        {
            InitializeComponent();

            Load += new EventHandler(DataBags_Load);
            Load += new EventHandler(showElementsOfBag_Load);
        }


        protected void DataBags_Load(object sender, EventArgs e)
        {
            try
            {
                PostgresConnection databaseConnection = new PostgresConnection();
                databaseConnection.connection().Open();


                DataSet ds = new System.Data.DataSet();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("select var_table , alive ,gather_data_time from existing_bags eb ", databaseConnection.connection());


                da.Fill(ds, "DataBags");

                DataBags_gridview.DataSource = ds.Tables[0];
                DataBags_gridview.ReadOnly = true;
                DataBags_gridview.AutoResizeColumns();

                foreach (DataGridViewRow row in DataBags_gridview.Rows)
                {
                    row.Height = (DataBags_gridview.ClientRectangle.Height - DataBags_gridview.ColumnHeadersHeight) / DataBags_gridview.Rows.Count;
                }


                //DataBags_gridview.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                //DataBags_gridview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

                databaseConnection.connection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void showElementsOfBag_Load(object sender, EventArgs args)
        {
            try
            {
                DataGridViewRow row = DataBags_gridview.Rows[0];
                string row_tablename = row.Cells[0].Value.ToString();

                showElementsOfBag(row_tablename);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void showElementsOfBag(string table_name)
        {
            try
            {
                PostgresConnection databaseConnection = new PostgresConnection();
                databaseConnection.connection().Open();


                DataSet ds = new System.Data.DataSet();



                NpgsqlDataAdapter da = new NpgsqlDataAdapter("select id,last_changed_time ,status ,var ,var_meaning , value ,var_path ,created_on from " + table_name
                                                              + " pdv order by id  ", databaseConnection.connection());


                da.Fill(ds, "DataBags");

                valuesInBag_gridview.DataSource = ds.Tables[0];
                valuesInBag_gridview.ReadOnly = true;
                valuesInBag_gridview.AutoResizeColumns();

                valuesInBag_gridview.ScrollBars = ScrollBars.Both;

                valuesInBag_gridview.PerformLayout();

                foreach (DataGridViewRow row in valuesInBag_gridview.Rows)
                {
                    row.Height = (valuesInBag_gridview.ClientRectangle.Height - valuesInBag_gridview.ColumnHeadersHeight) / valuesInBag_gridview.Rows.Count;
                }


                databaseConnection.connection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DataBags_gridview_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            // disable last index ( expections )
            if (e.RowIndex >= 0)
            {

                try
                {
                    DataGridViewRow row = DataBags_gridview.Rows[e.RowIndex];
                    string row_tablename = row.Cells[0].Value.ToString();

                    showElementsOfBag(row_tablename);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void DataBags_gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = DataBags_gridview.Rows[1];
                string row_tablename = row.Cells[0].Value.ToString();

                string newName = rename_table(row_tablename);

                insertIntoTest();

                MessageBox.Show("new name : " + newName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void insertIntoTest()
        {
            DateTime now = DateTime.Now;
            string datetime = DateTime.Today.ToString();
            DateTimeOffset thisTime;
            thisTime = new DateTimeOffset(now, new TimeSpan(+2, 0, 0)); // wrong, in this case should be + 3 hours!!!! ( don't know why yet)
            PostgresConnection con = new PostgresConnection();
            con.connection().Open();

            try
            {

           

            var sql = "INSERT INTO drive_historical(variable,value,last_date, last_time) VALUES(@variable, @value,@last_date,@last_time)";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con.connection());

            cmd.Parameters.AddWithValue("variable", "BMW");
            cmd.Parameters.AddWithValue("value","dupa");
            cmd.Parameters.AddWithValue("last_date", now.Date);
            cmd.Parameters.AddWithValue("last_time", thisTime);
            cmd.Prepare();

            cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private string rename_table(string previousName)
        {
            string[] splitted = previousName.Split('_');
            splitted[1] = "_historical";

            return splitted[0]+splitted[1];
        }
    }
}
