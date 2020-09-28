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
    }
}
