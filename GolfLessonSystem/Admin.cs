using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfLessonSystem
{
    class Admin
    {


        public static DataSet getYearlyAnalysis(string year)
        {
            //Connect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            string strSQL = "SELECT SUM(COST), to_Char(APPDATE,'MM') FROM LESSONS WHERE to_Char(APPDATE, 'YYYY') = '"+  year +"' GROUP BY to_Char(APPDATE,'MM') ORDER BY to_Char(APPDATE, 'MM')";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            conn.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "An");
            //close db
            conn.Close();

            return ds;
        }

        public static DataSet getYearlyProAnalysis(string year)
        {
            //Connect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            string strSQL = "SELECT SUM(COST), PROID FROM LESSONS WHERE to_Char(APPDATE, 'YYYY') = '" + year + "' GROUP BY PROID ORDER BY PROID";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            conn.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Pro");
            //close db
            conn.Close();

            return ds;
        }


    }
}
