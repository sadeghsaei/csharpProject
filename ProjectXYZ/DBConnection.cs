using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace timesheetRecordSaving
{
    class DBConnection
    {
        private string ConString = @"Data Source=DESKTOP-N25CU7R\SQLEXPRESS;Initial Catalog=XYZ_Travel_Agency;Persist Security Info=True;User ID=sa;Password=121212";
        public DBConnection() { }

        public void saveToDB(Record record)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                string query = "INSERT INTO t_userinfo (RegisterationID, name, address, ivp_id, date) Values ('" + record.registrationID + "','" + record.name + "','" + record.address + "','" + record.ivp_id + "','" + record.date + "')";
                SqlCommand insertQuery = new SqlCommand(query, con);
                insertQuery.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void modifyRecord(Record record)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                string query = "UPDATE t_userinfo SET " +
                    "name = '" + record.name + "', " +
                    "address = '" + record.address + "', " +
                    "ivp_id = '" + record.ivp_id + "', " +
                    "date = '" + record.date + "'" +
                    "WHERE RegisterationID = '" + record.registrationID + "'";
                SqlCommand updateQuery = new SqlCommand(query, con);
                updateQuery.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        public int recordCount()
        {
            SqlConnection conn = new SqlConnection(ConString);
            conn.Open();
            SqlCommand comm = new SqlCommand("SELECT COUNT(*) FROM t_userinfo", conn);
            Int32 count = (Int32)comm.ExecuteScalar();
            return count;
        }

        public int recordCount(string RegisterationID)
        {
            SqlConnection conn = new SqlConnection(ConString);
            conn.Open();
            SqlCommand comm = new SqlCommand("SELECT COUNT(*) FROM t_userinfo WHERE RegisterationID = '" + RegisterationID + "'", conn);
            Int32 count = (Int32)comm.ExecuteScalar();
            return count;
        }

        public int ivpRecordCount()
        {
            SqlConnection conn = new SqlConnection(ConString);
            conn.Open();
            SqlCommand comm = new SqlCommand("SELECT COUNT(*) FROM t_ivp", conn);
            Int32 count = (Int32)comm.ExecuteScalar();
            return count;
        }

        public Record searchRecord(string registrationID)
        {
            string query = "select * from t_userinfo where RegisterationID = '" + registrationID + "'";

            string[] result = new string[4];
            Record resultRecord = new Record();
            using (SqlConnection sqlcon1 = new SqlConnection(ConString))
            {
                sqlcon1.Open();
                using (SqlCommand sql1 = new SqlCommand(query, (sqlcon1)))
                {
                    using (SqlDataReader reader = sql1.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            { 
                                resultRecord.registrationID = (string)reader[0];
                                resultRecord.name = (string)reader[1];
                                resultRecord.address = (string)reader[2];
                                resultRecord.ivp_id = (int)reader[3];
                                resultRecord.date = (DateTime)reader[4];
                            }
                            return resultRecord;
                        }
                        else
                        {
                            resultRecord.registrationID = "0";
                            return resultRecord;
                        }
                    }
                }
            }
        }


    }
}
