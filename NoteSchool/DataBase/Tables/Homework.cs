using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace NoteSchool.DataBase.Tables
{
    class Homework
    {

        //Database
        private static SqlConnection sqlConnection;
        private static SqlCommand sqlCommand;


        //Table data
        private static String tableName = "tHomework";
        
        //Table atributes.
        private static String tIdHomework = "idHomework";
        private static String tDate = "theDate";
        private static String tTitle = "title";
        private static String tBody = "body";
        private static String tSubject = "subject";
        private static String tStatus = "status";


        //Views
        private static String viewTable = "tableHomework";

        //Functions
        private static String SELECT_HOMEWORK_SUBJECT = "SELECT_HOMEWORK_SUBJECT";

        //Root querys
        private static String INSERT_INTO_HOMEWORK = "INSERT INTO " + tableName + " (" +
            tTitle + ", " + tBody + ", " + tDate + ", " + tSubject + ", " + tStatus + ") VALUES (";

        private static String SELECT_ALL_TABLE = "SELECT * FROM " + viewTable;


        //Table funcion
        

        //Method to insert into db
        public static void INSERT_INTO(String title, String body, String date, String subject, String status) {

            int id = 0;
            int booleanStatus = 0;

            id = Tables.Subject.GET_SUBJECT_ID(subject);

            if (status == "Complete") {
                booleanStatus = 1;
            } else {
                booleanStatus = 0;
            }

            //Vars
            String query = INSERT_INTO_HOMEWORK + 
                "'" + title + "', " + 
                "'" + body + "', " +
                "'" + date + "', " + 
                "" + id + ", " +
                "" + booleanStatus + ");";

            sqlConnection = SqlOpenHelper.OpenConnection();
            SqlOpenHelper.ExecNonQuery(query, sqlConnection);

            sqlConnection.Close();
        }

        //Method to select all from db
        public static void SELECT_HOMEWORK(int id, DataGridView dgv) {

            //Vars
            String query = "SELECT * FROM " + SELECT_HOMEWORK_SUBJECT + "(" + id + ");";

            sqlConnection = SqlOpenHelper.OpenConnection();
            sqlCommand = SqlOpenHelper.ExecNonQueryReturn(query, sqlConnection);

            SqlDataAdapter da = new SqlDataAdapter(sqlCommand); //Adapta los datos.
            DataTable dt = new DataTable(); //Convierte los datos en tabla
            da.Fill(dt); //Llena la tabla.

            dgv.DataSource = dt; //Asigna al DGV la fuente de datos.

            setDesignDGV(dgv);

        }


        //Design
        public static void setDesignDGV(DataGridView dgv)
        {

            dgv.AllowUserToAddRows = false; //Desactva añadir una fila.
            DataGridViewColumn column;

            dgv.Columns[0].Visible = false;

            column = dgv.Columns[1];
            column.HeaderText = "Subject name";
            column.Width = 200;

            column = dgv.Columns[2];
            column.HeaderText = "Title";
            column.Width = 200;

            column = dgv.Columns[3];
            column.HeaderText = "Descripcion";
            column.Width = 139;

            column = dgv.Columns[4];
            column.HeaderText = "Date";
            column.Width = 200;

            //Estilo de texto para la tabla.
            dgv.ForeColor = Color.White;
            dgv.BackgroundColor = Color.FromArgb(28, 39, 43);
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(28, 39, 43);
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
        }

        public static void deleteHomework(int id) {

            String query = "DELETE FROM tHomework WHERE idHomework = " + id;

            sqlConnection = SqlOpenHelper.OpenConnection();
            SqlOpenHelper.ExecNonQuery(query, sqlConnection);

            sqlConnection.Close();
            
        }

        public static void getHomeworkWithId(int id, TextBox title, ComboBox cbSubject, DateTimePicker dateTimePicker, RichTextBox rtBody, ComboBox cbStatus) {

            String query = "SELECT " + tTitle + ", " + tBody + ", " + tDate + ", " + tSubject + " FROM " + 
                tableName + " WHERE " + tIdHomework + " = " + id;

            sqlConnection = SqlOpenHelper.OpenConnection();
            sqlCommand = SqlOpenHelper.ExecNonQueryReturn(query, sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read()) {
                title.Text = sqlDataReader.GetString(0);
                rtBody.Text = sqlDataReader.GetString(1);
                dateTimePicker.Value = sqlDataReader.GetDateTime(2);
                cbSubject.SelectedIndex = 0;
            }
            cbStatus.SelectedIndex = 0;
            sqlDataReader.Close();
            sqlConnection.Close();

        }

        public static void updateHomework(int id, String title, int subject, String theDate, String body, String status) {

            int booleanStatus = 0;

            if (status == "Complete")
            {
                booleanStatus = 1;
            }
            else
            {
                booleanStatus = 0;
            }

            String query = "UPDATE "+ tableName + " SET " + 
                tTitle + " = '" + title + "', " + 
                tDate + " = '" + theDate + "', " + 
                tBody + " = '" + body + "', " +
                tStatus + " = " + booleanStatus + ", " +
                tSubject + " = " + subject + 
                " WHERE " + tIdHomework + " = " + id;

            sqlConnection = SqlOpenHelper.OpenConnection();
            SqlOpenHelper.ExecNonQuery(query, sqlConnection);

            sqlConnection.Close();
            
        }



    }
}
