using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteSchool.DataBase.Tables;
using System.Data.SqlClient;
using System.Collections;

namespace NoteSchool.Layout.Schedule
{
    public partial class ScAddClass : Form
    {

        //Sql objects
        private static SqlConnection sqlConnection;
        private static SqlCommand sqlCommand;

        //String
        private static String defTextStart = "Class start time";
        private static String defTextEnd = "Class end time";
        private static String defTextLink = "Class link";

        //Variables
        private static DataGridView tDGV;
        private String thisDay;

        public ScAddClass(String day)
        {
            this.thisDay = day;
            InitializeComponent();
        }

        //setDGV
        public DataGridView setDGV(DataGridView dGV)
        {
            tDGV = dGV;
            return dGV;
        }

        private void ScAddClass_Load(object sender, EventArgs e) {
            
            this.ActiveControl = lHomework; //Set the first control selected.
            
            //ArrayList
            ArrayList listOfDays = new ArrayList();

            sqlConnection = DataBase.SqlOpenHelper.OpenConnection();
            sqlCommand = DataBase.SqlOpenHelper.ExecNonQueryReturn("SELECT name FROM tSubject;", sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read()){
                listOfDays.Add(sqlDataReader["name"]);                
            }

            for (int i = 0; i < listOfDays.Count; i++)
            {
                cbClassname.Items.Add(listOfDays[i]);
            }

            cbClassname.ForeColor = Color.White;

        }

        private void butDone_Click(object sender, EventArgs e)
        {

            ArrayList listOfDays = new ArrayList();
            int subjectId = getSubjectId(cbClassname.Text);

            getSelectDay(listOfDays, cbMonday);
            getSelectDay(listOfDays, cbTuesday);
            getSelectDay(listOfDays, cbWednesday);
            getSelectDay(listOfDays, cbThursday);
            getSelectDay(listOfDays, cbFriday);
            getSelectDay(listOfDays, cbSaturday);
            getSelectDay(listOfDays, cbSunday);

            for (int i = 0; i < listOfDays.Count; i++) {
                
                String query = DataBase.Tables.Schedule.INSERT_INTO_SCHEDULE +
                "'" + listOfDays[i] + "', " +
                "'" + tbStarttime.Text + "'," +
                "'" + tbEndtime.Text + "'," +
                "'" + tbLink.Text + "', " +
                "'" + subjectId + "');";

                sqlConnection = DataBase.SqlOpenHelper.OpenConnection();
                DataBase.SqlOpenHelper.ExecNonQuery(query, sqlConnection);

            }

            DataBase.Tables.Schedule.FUNCTION_SELECT(tDGV, thisDay);

            sqlConnection.Close();
            this.Close();

        }

        private static int getSubjectId(String subjectName) {
            
            int id = 0;

            sqlConnection = DataBase.SqlOpenHelper.OpenConnection();
            sqlCommand = DataBase.SqlOpenHelper.ExecNonQueryReturn(DataBase.Tables.Subject.SELECT_ID + "'" +subjectName + "';", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read()) {
                id = sqlDataReader.GetInt32(0);
            }

            return id;
        }

        private static void getSelectDay(ArrayList listOfDays, CheckBox cb) {

            if (cb.Checked) {
                listOfDays.Add(cb.Text);
            }

        }


        public void resetText(TextBox tb, String text)
        {

            //Verificamos que el TB esté vacio.
            if (tb.Text == "")
            {

                tb.ForeColor = (Color.DarkGray); //Cambiamos el color del TB
                tb.Text = (text); //Reiniciamos el texto por defecto.

            }

        }

        //Metodo para cambiar el color y limpiar el TB.
        public void changeTextColor(TextBox tb, String text)
        {

            //Verificamos que los textos sean iguales.
            if (tb.Text == text)
            {

                tb.Text = (""); //Limpiamos el TB.
                tb.ForeColor = Color.White; //Cambiamos el color de la leta.

            }

        }

        private void cbClassname_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            if (e.KeyData == Keys.Tab) {
               changeTextColor(tbStarttime, defTextStart);
            }
        }

        private void tbStarttime_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab) { 

                changeTextColor(tbEndtime, defTextEnd);
            }
        }

        private void cbClassname_Leave(object sender, EventArgs e)
        {

        }

        private void tbStarttime_Leave(object sender, EventArgs e)
        {
            resetText(tbStarttime, defTextStart);
        }

        private void tbEndtime_Leave(object sender, EventArgs e)
        {
            resetText(tbEndtime, defTextEnd);
        }

        private void tbLink_Leave(object sender, EventArgs e)
        {
            resetText(tbLink, defTextLink);
        }

        private void cbSunday_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                changeTextColor(tbLink, defTextLink);
            }
        }

        private void tbStarttime_Click(object sender, EventArgs e)
        {
            changeTextColor(tbStarttime, defTextStart);
        }

        private void tbEndtime_Click(object sender, EventArgs e)
        {
            changeTextColor(tbEndtime, defTextEnd);
        }

        private void tbLink_Click(object sender, EventArgs e)
        {
            changeTextColor(tbLink, defTextLink);
        }
    }
}
