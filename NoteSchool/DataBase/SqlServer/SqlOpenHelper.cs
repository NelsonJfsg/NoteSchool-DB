using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NoteSchool.DataBase
{
    class SqlOpenHelper
    {

        //Atributes to connect db.
        private static String dbName = "dbNoteSchool;";

        //Nelson, Pablo, Kevin, Kike
        private static String user = "Nelson";


        private static String connectionQuery;
        
        public static Boolean CheckConnection() {

            try {

                connectionQuery = connectUser(user);

                SqlConnection sqlConnection = new SqlConnection(connectionQuery);
                sqlConnection.Open();
                sqlConnection.Close();


                return true;

            } catch (Exception err) {

                MessageBox.Show("Something was wrong: \n" + err.ToString());

                return false;

            }
        }


        public static SqlConnection OpenConnection() {
            
            connectionQuery = connectUser(user);

            SqlConnection sqlConnection = new SqlConnection(connectionQuery);

            sqlConnection.Open();

            return sqlConnection;

        }

        public static void CloseConnection(SqlConnection sqlConnection) {

            sqlConnection.Close();

        }

        public static void ExecNonQuery(String query, SqlConnection sqlConnection) {

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();

        }

        public static SqlCommand ExecNonQueryReturn(String query, SqlConnection sqlConnection) {
            
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            return sqlCommand;

        }

        private static String setUser(String dbName, String serverName, String userName, String password) {
            
            //Variable para entrar a la base de datos.
            String connectionQuery = "Database = " + dbName + "Data Source = " + serverName + "User Id = " + userName + "Password = " + password;

            return connectionQuery;
        }
        
        private static String connectUser(String user) {
            
            String connectionQuery = null;
            
            switch (user) {

                case "Nelson":

                    connectionQuery = setUser(dbName, "DESKTOP-9KVSAP9\\DBNELSONJFSG;", "sa;", "NelsonJfsg;");

                    break;

                case "Kevin":

                    connectionQuery = setUser(dbName, "localhost\\SQLEXPRESS;", "kevinvillagran;", "kevinricardo;");

                    break;
                case "Kike":

                    connectionQuery = setUser(dbName, "LAPTOP-4P9S268V;", "kikexmtz;", "tutifruti123");

                    break;
                case "Pablo":

                    connectionQuery = setUser(dbName, "localhost\\SQLEXPRESS;", "PabloG;", "chtmkevinxd;");

                    break;

            }
            
            return connectionQuery;

        }


    }
}
