using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace NoteSchool.DataBase.Utilities
{
    class Utilities
    {

        private static SqlConnection sqlConnection;

        public static void CreateAllTables() {

            sqlConnection = SqlOpenHelper.OpenConnection();

            //Aqui crean sus tablas
            SqlOpenHelper.ExecNonQuery(Tables.Subject.CREATE_TABLE_SUBJECT, sqlConnection);

            //EJEMPLO: SqlOpenHelper.ExecNonQuery(Tables.Subject.CREATE_TABLE_HOMEWORK, sqlConnection);

            sqlConnection.Close();

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
