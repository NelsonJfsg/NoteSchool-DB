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
        private static String serverName = "DESKTOP-9KVSAP9\\DBNELSONJFSG;";
        private static String userName = "sa;";
        private static String password = "NelsonJfsg";

        //Variable para entrar a la base de datos.
        private static String connectionQuery =
            "Database = " + dbName +
            "Data Source = " + serverName +
            "User Id = " + userName +
            "Password = " + password;

        public static Boolean CheckConnection() {

            try {

                SqlConnection sqlConnection = new SqlConnection(connectionQuery);
                sqlConnection.Open();
                sqlConnection.Close();

                MessageBox.Show("Todo bien");

                return true;

            }
            catch (Exception err) {

                MessageBox.Show(err.ToString());

                return false;

            }
        }


        public static SqlConnection OpenConnection() {

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

        


    }
}
