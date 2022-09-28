using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace GolfLessonSystem
{
    class AppTime
    {

        public string appTime;


        public AppTime(string appTime)
        {
            this.appTime = appTime;
        }


        public static DataSet getAllTimes()
        {
            //Connect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            string sqlQuery = "SELECT * FROM APPTIMES ORDER BY APPTIME";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "App");
            //close db
            conn.Close();

            return ds;
        }
    }
}
