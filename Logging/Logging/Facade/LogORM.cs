using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging.Facade
{
    public class LogORM
    {
        public static  DataTable Select() //select report from db
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("LogSelect", SqlTools.Connection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        public static DataTable SelectRoute(int routeID) //select routes from db
        {

            string conString = string.Format("select LineName from Lines where DeviceID={0}", routeID);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(conString, SqlTools.Connection);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

    }
}
