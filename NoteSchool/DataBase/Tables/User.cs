using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using NoteSchool.Layout.Home;
using NoteSchool.Layout.Login;

namespace NoteSchool.DataBase.Tables
{
    class User {

        //Sql object
        private static SqlConnection sqlConnection;
        private static SqlCommand sqlCommand;

        //Table name
        private static String tableName = "tUser";

        //Atributes
        private static String tUserName = "userName";
        private static String tUserPassword = "userPassword";

        //Data base function
        private static String IF_EXISTS = "IF object_id('" + tableName + "') IS NULL";

        //Query select root
        private static String SELECT_USER_NAME = "SELECT (" + tUserName + ") FROM " + tableName + " WHERE " + tUserName + " = ";
        private static String SELECT_ALL_USER = "SELECT * FROM " + tableName + " WHERE " + tUserName + " = ";


        //Query to create table
        public static String CREATE_TABLE_USER = IF_EXISTS + " CREATE TABLE " + tableName + "(" + 
            tUserName + " VARCHAR(50) NOT NULL PRIMARY KEY, " +
            tUserPassword + " VARCHAR(50) NOT NULL);";

        //Root query to insert into table
        private static String INSERT_INTO = "INSERT INTO " + tableName + "(" +
            tUserName + ", " +
            tUserPassword + 
            ") VALUES (";



        //Method to insert into table
        public static void INSERT_INTO_USER(Form sc, String userName, String password) {

            //Vars
            Boolean tableEmpty = true;

            sqlConnection = SqlOpenHelper.OpenConnection();
            sqlCommand = SqlOpenHelper.ExecNonQueryReturn("SELECT * FROM " + tableName, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read()) {
                    tableEmpty = false;
            }

            if (tableEmpty) {
                if (!checkIfUserExists(userName)) {

                    String query = INSERT_INTO + "'" + userName + "', '" + password + "');";

                    SqlOpenHelper.ExecNonQuery(query, sqlConnection);
                    sqlConnection.Close();
                    sc.Dispose();
                    ScLogin scLogin = new ScLogin();
                    scLogin.Show();

                } else {

                    MessageBox.Show("This user already exists.");

                }
            } else {
                MessageBox.Show("Ya hay un usuario en la DB.");
            }

        }

        public static Boolean checkIfUserExists(String userName) {

            Boolean exists = false;

            sqlConnection = SqlOpenHelper.OpenConnection();
            sqlCommand = SqlOpenHelper.ExecNonQueryReturn(SELECT_USER_NAME + "'" + userName + "'", sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            
            while (sqlDataReader.Read())
            {
                if (sqlDataReader != null)
                {
                    exists = true;
                }
                else
                {
                    exists = false;
                }

            }

            sqlDataReader.Close();
            return exists;

        }

        //Login
        public static void userAuthentication(Form sc, String userName, String password) {

            //Var
            String sqlUserName = null;
            String sqlPasword = null;
            Boolean result;

            sqlConnection = SqlOpenHelper.OpenConnection();
            sqlCommand = SqlOpenHelper.ExecNonQueryReturn(SELECT_ALL_USER + "'" + userName + "';", sqlConnection);
            
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            //Read DB
            while (sqlDataReader.Read()) {

                if (sqlDataReader != null) {
                    sqlUserName = sqlDataReader.GetString(0);
                    sqlPasword = sqlDataReader.GetString(1);
                }

            }

            //Correct credits
            if (userName == sqlUserName && password == sqlPasword) {

                MessageBox.Show("Welcome " + userName);
                ScHome scHome = new ScHome();
                scHome.Show();

                sc.Hide();

            } else {
                MessageBox.Show("User name or password incorrect.");
            }


        }













    }
}
