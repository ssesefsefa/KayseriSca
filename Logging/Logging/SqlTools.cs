using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
    public class SqlTools
    {
        private static SqlConnection connection;

        public static SqlConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    connection = new SqlConnection("Server =DESKTOP-58FAAJE\\SEFA; Database = KayseriScadaDB; Integrated Security = true;");

                }

                return connection;
            }
        }

        public static bool ExecuteNonQuery(SqlCommand command)
        {
            try
            {
                if (command.Connection.State != ConnectionState.Open)
                    command.Connection.Open();

                int suc = command.ExecuteNonQuery();
                return suc > 0 ? true : false;
            }
            catch (Exception)
            {

                return false;
            }

            finally
            {
                if (command.Connection.State != ConnectionState.Closed)
                    command.Connection.Close();
            }
        }

    }
}
