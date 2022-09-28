using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace GolfLessonSystem
{
    class Members
    {

        public int MemberID;
        public string Forename;
        public string Surname;
        public string Email;
        public int Handicap;


        public Members(int MemberID, string Forename, string Surname, string Email, int Handicap)
        {
            this.MemberID = MemberID;
            this.Forename = Forename;
            this.Surname = Surname;
            this.Email = Email;
            this.Handicap = Handicap;
        }


        public static DataSet getAllMem()
        {
            //Connect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            string sqlQuery = "SELECT * FROM MEMBERS ORDER BY Surname, Forename";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Mem");
            //close db
            conn.Close();

            return ds;
        }

        public static DataSet loadMem(String forename, String surname)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);


            //Define SQL Query
            string sqlQuery = "SELECT * FROM MEMBERS WHERE forename = ('" + forename + "') AND surname = ('" + surname + "')";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Mem");
            //close db
            conn.Close();

            return ds;
        }


    }
}
