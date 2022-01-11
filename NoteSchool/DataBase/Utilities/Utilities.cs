using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NoteSchool.DataBase.Utilities
{
    class Utilities
    {

        //Sql utilities.
        private static SqlConnection sqlConnection;

        //Method to create all tables in db.
        public static void CreateAllTables() {

            try {

                sqlConnection = SqlOpenHelper.OpenConnection();

                SqlOpenHelper.ExecNonQuery(StoredProcedure.CreateAllTables, sqlConnection);
                
            } catch (Exception err) {

                MessageBox.Show("Excepcion encontrada: \n" + err);

            } finally {
                
                sqlConnection.Close();
            
            }


        }

        public static void DeleteAllTables() {

            sqlConnection = SqlOpenHelper.OpenConnection();

            //Aqui crean sus tablas
            SqlOpenHelper.ExecNonQuery(Tables.Subject.DROP_TABLE_SUBJECT, sqlConnection);

            //EJEMPLO: SqlOpenHelper.ExecNonQuery(Tables.Subject.CREATE_TABLE_HOMEWORK, sqlConnection);

            sqlConnection.Close();


        }



    }
}
