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
    class Subject
    {

        //Var
        private static Boolean checkName;

        //Database
        private static SqlConnection sqlConnection;
        private static SqlCommand sqlCommand;

        //Table name
        private static String tableName = "tSubject";

        //Atributes
        private static String tName = "name";
        private static String tTeacherName = "teacherName";
        private static String tQualificationScores = "qualificationScores";
        private static String tIcon = "icon";

        //Data base funcion
        private static String CREATE_TABLE = "CREATE TABLE ";
        private static String IF_TABLE_EXISTS = "IF object_id ('" + tableName + "') IS NULL ";
        public static String DROP_TABLE_SUBJECT = "DROP TABLE " + tableName;
        public static String SELECT_SUBJECT = "SELECT " + tName + ", " + tTeacherName + ", " + tQualificationScores + ", " + tIcon + " FROM " + tableName;
        public static String SELECT_WHERE_SUBJECT = SELECT_SUBJECT + " WHERE "  + tName + " = ";
        public static String UPDATE_SUBJECT = "UPDATE " + tableName + " SET ";
        
        public static String SELECT_SUBJECTNAME = "SELECT (" + tName + ") FROM " + tableName + " WHERE " + tName + " = ";

        //Create table tSubject
        public static String CREATE_TABLE_SUBJECT = IF_TABLE_EXISTS + CREATE_TABLE + tableName + " (" +
            tName + " VARCHAR (50) PRIMARY KEY NOT NULL, " +
            tTeacherName + " VARCHAR (80), " +
            tQualificationScores + " TEXT, " +
            tIcon + " VARCHAR (100) NOT NULL );";

        //Insert table tSubject
        public static String INSERT_INTO = "INSERT INTO " + tableName + "( " + 
            tName + ", " + 
            tTeacherName + ", " + 
            tQualificationScores + ", " +
            tIcon + ") VALUES ( ";


        public static void INSERT_INTO_SUBJECT(Form Sc, String name, String teacherName, String qualificationScores, String icon) {

            checkName = checkIfExists(name);

            if (checkName == true) {

                MessageBox.Show("This subject already exists.");

            } else { 

                String query = INSERT_INTO +
                    "'" + name + "', " +
                    "'" + teacherName + "', " +
                    "'" + qualificationScores + "', " +
                    "'" + icon + "' ) ";

                sqlConnection = SqlOpenHelper.OpenConnection();
                SqlOpenHelper.ExecNonQuery(query, sqlConnection);
                sqlConnection.Close();

                Sc.Close();
            }
        }

        public static void UPDATE_SUBJECT_TABLE(String name, String teacherName, String qualificationScores, String icon){
            
            
            String query = UPDATE_SUBJECT + 
            tName + " = " + "'" + name + "'" +
            tTeacherName + " = " + "'" + teacherName + "'" +
            tQualificationScores + " = " + "'" + qualificationScores + "'" +
            tIcon + " = " + "'" + icon + "';";

            sqlConnection = SqlOpenHelper.OpenConnection();
            SqlOpenHelper.ExecNonQuery(query, sqlConnection);
            sqlConnection.Close();

        }

        public static void DELETE_SUBJECT(String name){

            String query = "DELETE FROM " + tableName + " WHERE " + tName + " = '" + name + "';";

            sqlConnection = SqlOpenHelper.OpenConnection();
            SqlOpenHelper.ExecNonQuery(query, sqlConnection);
            MessageBox.Show("Successfully removed.");
            sqlConnection.Close();

        }
        
        public static void SELECT_FROM_SUBJECT(String name, TextBox tbName, TextBox tbTeacherName, TextBox tbQualificationScores, ComboBox cbIcon) {

            //Atributes
            String subjectName;
            String teacherName;
            String qualificationScores;
            String icon;

            String query = SELECT_WHERE_SUBJECT + "'" + name + "'; ";

            sqlConnection = SqlOpenHelper.OpenConnection();
            sqlCommand = SqlOpenHelper.ExecNonQueryReturn(query, sqlConnection);
            
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read()) {

                tbName.Text = sqlDataReader[tName].ToString();
                tbTeacherName.Text = sqlDataReader[tTeacherName].ToString();
                tbQualificationScores.Text = sqlDataReader[tQualificationScores].ToString();
                cbIcon.Text = sqlDataReader[tIcon].ToString();

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

            String query = UPDATE_SUBJECT + 
                tName + " = '" + tempSubjectName + "', " +
                tTeacherName + " = '" + teacherName + "', " +
                tQualificationScores + " = '" + qualificationScores + "', " +
                tIcon + " = '" + icon + "' WHERE " + tName + " = '" + subjectName + "';";

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

            Boolean exists = false;

            sqlConnection = SqlOpenHelper.OpenConnection();
            sqlCommand = SqlOpenHelper.ExecNonQueryReturn(SELECT_SUBJECTNAME + "'" + subjectName + "'", sqlConnection);
            
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read()) {
                if (sqlDataReader != null) {
                    exists = true;
                } else {
                    exists = false;
                }

            }

            sqlDataReader.Close();
            return exists;

        }

        //Design
        public static void setDesignDGV(DataGridView dgv) {

            dgv.AllowUserToAddRows = false; //Desactva añadir una fila.
            DataGridViewColumn column;

            column = dgv.Columns[0];
            column.HeaderText = "Subject name";
            column.Width = 199;

            column = dgv.Columns[1];
            column.HeaderText = "Teacher name";
            column.Width = 166;

            column = dgv.Columns[2];
            column.HeaderText = "Qualification scores";
            column.Width = 232;

            column = dgv.Columns[3];
            column.HeaderText = "Icon";
            column.Width = 142;

            //Estilo de texto para la tabla.
            dgv.ForeColor = Color.White;
            dgv.BackgroundColor = Color.FromArgb(28, 39, 43);
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(28, 39, 43);
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
        }

    }
}
