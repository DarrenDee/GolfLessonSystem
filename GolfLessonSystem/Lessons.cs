using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfLessonSystem
{
    class Lessons
    {
        public int bookingNumber;
        public int cost;
        public string appTime;
        public string date;
        public int proId;
        public int memberId;

        public Lessons(int bookingNumber, int cost, string appTime, string date, int proId, int memberId)
        {
            this.bookingNumber = bookingNumber;
            this.cost = cost;
            this.appTime = appTime;
            this.date = date;
            this.proId = proId;
            this.memberId = memberId;
        }
        public static int getNextBookingID()
        {
            //Connect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            string sqlQuery = "SELECT MAX(BOOKINGNUMBER) FROM LESSONS";

            //Execute Query
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            int nextId;
            dr.Read();

            if (dr.IsDBNull(0)) //Check if max value is NULL or not
                nextId = 1;
            else //Get value
                nextId = dr.GetInt32(0) + 1;

            conn.Close(); //Close Connection
            return nextId;
        }
        public static DataSet getAllLessons()
        {
            //Connect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            string sqlQuery = "SELECT * FROM LESSONS ORDER BY BOOKINGNUMBER";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Lesson");
            //close db
            conn.Close();

            return ds;
        }

        public static DataSet loadTimesPro(String proId)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);


            //Define SQL Query
            string sqlQuery = "SELECT * FROM LESSONS WHERE PROID = ('" + proId + "')"; 

           OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Time");
            //close db
            conn.Close();

            return ds;
        }


        public static DataSet loadTimesMem(String memId)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);


            //Define SQL Query
            string sqlQuery = "SELECT * FROM LESSONS WHERE MEMBERID = ('" + memId + "')";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "MemTime");
            //close db
            conn.Close();

            return ds;
        }

        public static DataSet checkproDate(String date , int proId )
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);


            //Define SQL Query
            string sqlQuery = "SELECT * FROM LESSONS WHERE APPDATE = '"+date+"' AND PROID = "+ proId +"" ;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds , "Date");
            //close db
            conn.Close();

            return ds;
        }

        public static DataSet checkmemDate(String date, String memberId)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);


            //Define SQL Query
            string sqlQuery = "SELECT * FROM LESSONS WHERE APPDATE = '" + date + "' AND MEMBERID = '" + memberId + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Date");
            //close db
            conn.Close();

            return ds;
        }

        public static int getNextLessonID()
        {
            //Connect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            string sqlQuery = "SELECT MAX(BOOKINGNUMBER) FROM LESSONS";

            //Execute Query
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            int nextId;
            dr.Read();

            if (dr.IsDBNull(0)) //Check if max value is NULL or not
                nextId = 1;
            else //Get value
                nextId = dr.GetInt32(0) + 1;

            conn.Close(); //Close Connection
            return nextId;
        }

       public void addLesson()
        {


            //connect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //define query
            String sqlQuery = "INSERT INTO LESSONS Values (" +
              this.bookingNumber + "," +
               this.cost + ",'" +
                this.appTime + "','" +
                this.date + "'," +
                this.proId + "," +
                this.memberId + ")";

            //execute
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //close db
            conn.Close();
        }
        
        public static void cancelLesson(int bookingNumber)
        {     
            //connect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "DELETE FROM LESSONS WHERE BOOKINGNUMBER = "+ bookingNumber + " ";


            //execute
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //close db
            conn.Close();


        }
        public static DataSet getBookingNumbers()
        {
            //Connect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            string sqlQuery = "SELECT BOOKINGNUMBER FROM LESSONS ORDER BY BOOKINGNUMBER";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "BN");
            //close db
            conn.Close();

            return ds;
        }

        public static DataSet getMemberLessons(int memberId)
        {
            //Connect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            string sqlQuery = "SELECT * FROM LESSONS WHERE MEMBERID = " + memberId + " ";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "ML");
            //close db
            conn.Close();

            return ds;
        }
        public static DataSet getLessonSchedule(String date)
        {
            //Connect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            string sqlQuery = "SELECT * FROM LESSONS WHERE APPDATE = '" + date + "' ";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "SD");
            //close db
            conn.Close();

            return ds;
        }
    }
}
