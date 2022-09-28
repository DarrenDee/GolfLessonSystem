using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace GolfLessonSystem
{
    class Professional
    {
        public int ProID;
        public string Forename;
        public string Surname;
        public string Email;
        public string PhoneNumber;
        public decimal Fee;
        public string Status;


        public Professional(int ProID, string Forename, string Surname, string Email, string PhoneNumber, decimal Fee, string Status)
        {
            this.ProID = ProID;
            this.Forename = Forename;
            this.Surname = Surname;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.Fee = Fee;
            this.Status = Status;
        }

        public static int getNextProdID()
        {
            //Connect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            string sqlQuery = "SELECT MAX(PROID) FROM GOLFPROS";

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

        public static DataSet getAllPros()
        {
            //Connect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            string sqlQuery = "SELECT * FROM GOLFPROS ORDER BY Forename, Surname";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Pros");
            //close db
            conn.Close();

            return ds;
        }
        public static DataSet loadPro(int proId)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);


            //Define SQL Query
            string sqlQuery = "SELECT * FROM GOLFPROS WHERE PROID = (" + proId + ")";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Pros");
            //close db
            conn.Close();

            return ds;
        }

        public void addPro()
        {


            //connect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //define query
            String sqlQuery = "INSERT INTO GOLFPROS Values (" +
              this.ProID + ",'" +
               this.Forename + "','" +
                this.Surname + "','" +
                this.Email + "','" +
                this.PhoneNumber + "'," +
                this.Fee + ",'" +
                this.Status + "')";

            //execute
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //close db
            conn.Close();
        }

        public void UpdatePro()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "UPDATE GOLFPROS SET" +
                " FORENAME ='" + this.Forename +
                "', SURNAME ='" + this.Surname +
                "', EMAIL ='" + this.Email +
                "', PHONENUMBER ='" + this.PhoneNumber +
                "', FEE =" + this.Fee + " WHERE ProID = " + this.ProID;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public void DeRegPro()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "UPDATE GOLFPROS SET STATUS = 'U' WHERE ProID = " + this.ProID;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();

        }
    }
}
