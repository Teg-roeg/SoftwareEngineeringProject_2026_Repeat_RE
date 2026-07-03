using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ProductApp
{
    class Database
    {
        public const string connectionString = "Data Source = studentoracle:1521/orcl; User Id = t00262291; Password = gyqc4K*9prh;";

        public static OracleConnection OpenConnection()
        {
            OracleConnection conn = new OracleConnection(Database.connectionString); // Open an Oracle DB Connection 

            conn.Open();

            return conn;
        }

        public static DataSet ExecuteMultiRowQuery(string query)
        {
    
            OracleConnection conn = OpenConnection(); //Open a connection to an Oracle database


            OracleCommand cmd = new OracleCommand(query, conn); //Formulate the DB request

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet(); //Create the DataSet to hold results of the query

            da.Fill(ds); //Populate the DataSet with the results of the query

            conn.Close(); //Close DB connection

            return ds;
        }


        public static OracleDataReader ExecuteSingleRowQuery(string query)
        {
            OracleConnection conn = OpenConnection();

            OracleCommand cmd = new OracleCommand(query, conn);

            OracleDataReader dr = cmd.ExecuteReader();  //Execute the query and atore the results in an OracleDataReader

            return dr;
        }

        public static void ExecuteNonQuery(string query)
        {

            OracleConnection conn = OpenConnection(); //Open a connection to an Oracle database

            OracleCommand cmd = new OracleCommand(query, conn);

            cmd.ExecuteNonQuery(); // Executes non query 

            conn.Close(); // Closing connetion

        }
    }
}
