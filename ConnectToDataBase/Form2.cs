using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectToDataBase
{
    public partial class Form2 : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataReader sqlReader = null;
                SqlCommand sqlCommand = new SqlCommand("select*from sys.databases", connection);


                try
                {
                    connection.Open();
                    sqlReader = sqlCommand.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        lbDB.Items.Add(Convert.ToString(sqlReader["name"]));
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (connection != null)
                    {
                        connection.Close();
                    }
                }

            }

        }

        private void btTables_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataReader sqlReader1 = null;
                SqlCommand sqlCommand1 = new SqlCommand("SELECT table_name FROM information_schema.tables where TABLE_CATALOG=\'" + tbDB.Text + "\'", connection);




                    try
                    {
                        connection.Open();

                        sqlReader1 = sqlCommand1.ExecuteReader();

                        while (sqlReader1.Read())
                        {
                            lbTables.Items.Add(Convert.ToString(sqlReader1["table_name"]));
                        }
                        lbTables.Refresh();

                        SqlDataReader sqlDataReader = null;
                        SqlCommand sqlCommand = new SqlCommand("select*from sys.databases", connection);


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    finally
                    {
                        if (connection != null)
                        {
                            connection.Close();
                        }
                    }

                
            }
        }
    }
}


