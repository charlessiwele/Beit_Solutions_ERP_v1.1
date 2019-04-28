using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace Beit_Solutions_ERP_v1._1.DataConnectionHandlers
{
    class Connection
    {


        public SqlConnection SetConnection()
        {
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = "Data Source=CHARLES_;Initial Catalog=Beit_Solutions_WF;Integrated Security=True";
            }
            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.StackTrace);
            }
            return sqlConnection;
        }

        public void Connect()
        {
            try
            {
                SqlConnection sqlConnection = SetConnection();
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
            }
            catch (SqlException sqlException)
            {
                int i = sqlException.Number;
                if (i == 233)
                {
                    Reconnect();
                }
                else
                {
                    MessageBox.Show(sqlException.StackTrace);
                }
            }
        }


        public void Reconnect()
        {
            try
            {
                SqlConnection sqlConnection = SetConnection();

                Thread.Sleep(30000);
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
            }
            catch (Exception sqlException)
            {
                MessageBox.Show(sqlException.StackTrace);
            }
        }
        public void Disconnect()
        {
            try
            {
                if (SetConnection().State == ConnectionState.Open)
                {
                    SetConnection().Close();
                }
            }
            catch (SqlException sqlException)
            {
                MessageBox.Show(sqlException.StackTrace);
            }
        }
    }
}
