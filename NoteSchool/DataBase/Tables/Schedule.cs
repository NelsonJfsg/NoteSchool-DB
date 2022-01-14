using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace NoteSchool.DataBase.Tables
{
    class Schedule
    {

        //Vars
        private static int idClassTemp = 0;

        //Database connections
        private static SqlConnection sqlConnection;
        private static SqlCommand sqlCommand;


        //Table data
        private static String tableName = "tSchedule";
        private static String viewTable = "GETCLASSES";
        private static String functionToSelectAndEdit = "GETCLASSWHEREID";
        public static String InsertIntoSchedule = "EXEC InsertIntoSchedule ";
        private static String UpdateSchedule = "EXEC UpdateSchedule ";
        private static String DeleteSchedule = "EXEC DeleteSchedule ";

        //Table atributes
        private static String tIdClass = "idClass";
        private static String tDayOfWeek = "dayOfWeek";
        private static String tStartHour = "startHour";
        private static String tFinishHour = "finishHour";
        private static String tLinkClass = "linkClass";
        private static String tSubject = "subject";

        public static String INSERT_INTO_SCHEDULE = "INSERT INTO " + tableName + " (" + 
            tDayOfWeek + ", " + tStartHour + ", " + tFinishHour + ", " + tLinkClass + ", " + tSubject + ") VALUES (";

        public static String SELECT_ALL = "SELECT * FROM " + viewTable + "('";
        
        //Querys
        private static String SELECT_TO_EDIT = "SELECT * FROM " + functionToSelectAndEdit + "(";

        public static void FUNCTION_SELECT(DataGridView dgv, String day) {
            
            sqlConnection = SqlOpenHelper.OpenConnection();

            sqlCommand = SqlOpenHelper.ExecNonQueryReturn(SELECT_ALL + day + "');", sqlConnection);

            SqlDataAdapter da = new SqlDataAdapter(sqlCommand); //Adapta los datos.
            DataTable dt = new DataTable(); //Convierte los datos en tabla
            da.Fill(dt); //Llena la tabla.

            dgv.DataSource = dt; //Asigna al DGV la fuente de datos.

        }

        public static void FUNCTION_SELECT_TO_EDIT(int id, ComboBox cbSubject, TextBox tbStartTime, TextBox tbEndTime, TextBox tbLink) {

            idClassTemp = id;

            String query = SELECT_TO_EDIT + id + ");"; 

            sqlConnection = SqlOpenHelper.OpenConnection();
            sqlCommand = SqlOpenHelper.ExecNonQueryReturn(query, sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read()) {
                cbSubject.Text = sqlDataReader.GetString(0);
                tbStartTime.Text = sqlDataReader.GetString(2);
                tbEndTime.Text = sqlDataReader.GetString(3);
                tbLink.Text = sqlDataReader.GetString(4);
            }

            sqlConnection.Close();

        }

        public static void UPDATE_CLASS(ComboBox cbSubject, TextBox tbStartTime, TextBox tbEndTime, TextBox tbLink) {

            int subjectId = 0;

            sqlConnection = SqlOpenHelper.OpenConnection();
            sqlCommand = SqlOpenHelper.ExecNonQueryReturn(Subject.SELECT_ID + "'" +cbSubject.Text + "';", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read()) {
                subjectId = sqlDataReader.GetInt32(0); 
            }

            String query = "UPDATE " + tableName + " SET " +
                tSubject + " = " + subjectId + ", " +
                tStartHour + " = '" + tbStartTime.Text + "', " +
                tFinishHour + " = '" + tbEndTime.Text + "', " +
                tLinkClass + " = '" + tbLink.Text + "' " +
                " WHERE " + tIdClass + " = " + idClassTemp;

            sqlConnection = SqlOpenHelper.OpenConnection();
            SqlOpenHelper.ExecNonQuery(query, sqlConnection);

            sqlConnection.Close();

        }

        public static void DELETE_CLASS(int id) {

            String query = DeleteSchedule + id;
            sqlConnection = SqlOpenHelper.OpenConnection();
            SqlOpenHelper.ExecNonQuery(query, sqlConnection);

            sqlConnection.Close();
        }

        //Metodo para ejecutar el link del aula.
        public static void openLink(DataGridView dataGridView) {

            try {

                String link = dataGridView.CurrentRow.Cells[5].Value.ToString();
                System.Diagnostics.Process.Start(link);

            } catch (Exception err) {

                MessageBox.Show("Ingrese un link valido.");

            }
        }

    }
}
