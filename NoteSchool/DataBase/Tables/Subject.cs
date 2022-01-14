using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;

namespace NoteSchool.DataBase.Tables
{
    class Subject
    {

        //Var
        private static Boolean checkName;

        //Database
        private static SqlConnection sqlConnection;
        private static SqlCommand sqlCommand;

        //Table name
        public static String tableName = "tSubject";

        //Atributes
        private static String tId = "idSubject";
        public static String tName = "name";
        private static String tTeacherName = "teacherName";
        private static String tQualificationScores = "qualificationScores";
        
        //Views
        private static String tableSubject = "tableSubject";

        //Stored Procedures
        private static String InsertIntoSubject = "EXEC InsertIntoSubject ";
        private static String UpdateSubject = "EXEC UpdateSubject ";
        private static String DeleteSubject = "EXEC DeleteSubject ";

        //Data base funcion
        public static String DROP_TABLE_SUBJECT = "DROP TABLE " + tableName;
        public static String SELECT_SUBJECT = "SELECT * FROM " + tableSubject;
        public static String SELECT_WHERE_SUBJECT = SELECT_SUBJECT + " WHERE "  + tName + " = ";
        public static String UPDATE_SUBJECT = "UPDATE " + tableName + " SET ";

        public static String SELECT_ID = "SELECT " + tId + " FROM " + tableName + " WHERE " + tName + " = ";

        public static String SELECT_SUBJECTNAME = "SELECT (" + tName + ") FROM " + tableName + " WHERE " + tName + " = ";

        //Insert table tSubject
        public static String INSERT_INTO = "INSERT INTO " + tableName + "( " + 
            tName + ", " + 
            tTeacherName + ", " + 
            tQualificationScores + ") VALUES ( ";

        public static int GET_SUBJECT_ID(String subjectName) {

            int id = 0;
            String query = SELECT_ID + "'" + subjectName + "';";

            sqlConnection = SqlOpenHelper.OpenConnection();
            sqlCommand = SqlOpenHelper.ExecNonQueryReturn(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {

                id = sqlDataReader.GetInt32(0);

            }

            return id;

        }

        public static String GET_SUBJECT_NAME(int id) {

            //Vars
            String subjectName = null;

            String query = "SELECT " + tName + " FROM " + tableSubject + " WHERE " + tId + " = " + id;

            sqlConnection = SqlOpenHelper.OpenConnection();
            sqlCommand = SqlOpenHelper.ExecNonQueryReturn(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {

                subjectName = sqlDataReader.GetString(0);

            }

            return subjectName;

        }



        public static void INSERT_INTO_SUBJECT(Form Sc, String name, String teacherName, String qualificationScores) {

            String query = InsertIntoSubject +
                "'" + name + "', " +
                "'" + teacherName + "', " +
                "'" + qualificationScores + "'";

            sqlConnection = SqlOpenHelper.OpenConnection();
            SqlOpenHelper.ExecNonQuery(query, sqlConnection);
            sqlConnection.Close();

            Sc.Close();
            
        }

        public static void DELETE_SUBJECT(String id){

            String query = DeleteSubject + id;

            sqlConnection = SqlOpenHelper.OpenConnection();
            SqlOpenHelper.ExecNonQuery(query, sqlConnection);

            sqlConnection.Close();
            
        }
        
        public static void SELECT_FROM_SUBJECT(String name, TextBox tbName, TextBox tbTeacherName, TextBox tbQualificationScores) {

            //Atributes
            String subjectName;
            String teacherName;
            String qualificationScores;

            String query = SELECT_WHERE_SUBJECT + "'" + name + "'; ";

            sqlConnection = SqlOpenHelper.OpenConnection();
            sqlCommand = SqlOpenHelper.ExecNonQueryReturn(query, sqlConnection);
            
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read()) {

                tbName.Text = sqlDataReader[tName].ToString();
                tbTeacherName.Text = sqlDataReader[tTeacherName].ToString();
                tbQualificationScores.Text = sqlDataReader[tQualificationScores].ToString();
                
            }

            sqlConnection.Close();

        }

        public static void fillDgv(DataGridView dgv) {

            sqlConnection = SqlOpenHelper.OpenConnection();

            sqlCommand = SqlOpenHelper.ExecNonQueryReturn(DataBase.Tables.Subject.SELECT_SUBJECT, sqlConnection);

            SqlDataAdapter da = new SqlDataAdapter(sqlCommand); //Adapta los datos.
            DataTable dt = new DataTable(); //Convierte los datos en tabla
            da.Fill(dt); //Llena la tabla.

            dgv.DataSource = dt; //Asigna al DGV la fuente de datos.
            
        }

        public static void UPDATE_TABLE_SUBJECT(Form form, String subjectName, String tempSubjectName, String teacherName, String qualificationScores, String icon) {

            String query = UpdateSubject + "'" + subjectName + "', '" + tempSubjectName + "', '" + teacherName + "', '" + qualificationScores + "';";  

            sqlConnection = SqlOpenHelper.OpenConnection();
            
            if (subjectName == tempSubjectName) {

                SqlOpenHelper.ExecNonQuery(query, sqlConnection);
                MessageBox.Show("Successfully edited");
                form.Close();

            } else {
                
                if (checkIfExists(tempSubjectName)) {
                    
                    MessageBox.Show("Subject already exists.\nPlease rename subject.");

                } else {

                    SqlOpenHelper.ExecNonQuery(query, sqlConnection);
                    MessageBox.Show("Successfully edited");
                    form.Close();
                }
            }

            sqlConnection.Close();

        }

        private static Boolean checkIfExists(String subjectName) {

            //Vars
            Boolean exists = false;

            sqlConnection = SqlOpenHelper.OpenConnection(); //Set connection

            //Ejecute query.
            sqlCommand = SqlOpenHelper.ExecNonQueryReturn(SELECT_SUBJECTNAME + "'" + subjectName + "'", sqlConnection);
            
            //Read command
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            //Check if the name exists in db.
            while (sqlDataReader.Read()) {
                if (sqlDataReader != null) {
                    exists = true;
                } else {
                    exists = false;
                }
            }

            sqlDataReader.Close(); //Close db
            
            //Result
            return exists;

        }

        //Design
        public static void setDesignDGV(DataGridView dgv) {

            dgv.AllowUserToAddRows = false; //Desactva añadir una fila.
            DataGridViewColumn column;

            dgv.Columns[0].Visible = false;
            
            column = dgv.Columns[1];
            column.HeaderText = "Subject name";
            column.Width = 199;

            column = dgv.Columns[2];
            column.HeaderText = "Teacher name";
            column.Width = 166;

            column = dgv.Columns[3];
            column.HeaderText = "Qualification scores";
            column.Width = 374;

            //Estilo de texto para la tabla.
            dgv.ForeColor = Color.White;
            dgv.BackgroundColor = Color.FromArgb(28, 39, 43);
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(28, 39, 43);
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
        }

        public static void getAllSubjects(ComboBox cb) {

            //ArrayList
            ArrayList listOfDays = new ArrayList();

            sqlConnection = DataBase.SqlOpenHelper.OpenConnection();
            sqlCommand = DataBase.SqlOpenHelper.ExecNonQueryReturn("SELECT name FROM tSubject;", sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                listOfDays.Add(sqlDataReader["name"]);
            }

            for (int i = 0; i < listOfDays.Count; i++)
            {

                if (!cb.Items.Contains(listOfDays[i])) {
                    cb.Items.Add(listOfDays[i]);
                }

            }

        }


    }
}
