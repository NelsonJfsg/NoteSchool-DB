using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace NoteSchool.Layout.Schedule
{
    public partial class ScEditClass : Form
    {

        //Vars
        private static String defTextStart = "Class start time";
        private static String defTextEnd = "Class end time";
        private static String defTextLink = "Class link";
        private static int thisId = 0;
        private String thisDay;

        private DataGridView tDGV;

        public ScEditClass(int id, String day)
        {
            thisId = id;
            this.thisDay = day;
            InitializeComponent();
        }

        //setDGV
        public DataGridView setDGV(DataGridView dGV)
        {
            tDGV = dGV;
            return dGV;
        }

        private void ScEditClass_Load(object sender, EventArgs e) {
            
            this.ActiveControl = lHomework;
            tbStarttime.ForeColor = Color.White;
            tbEndtime.ForeColor = Color.White;
            tbLink.ForeColor = Color.White;


            //ArrayList
            ArrayList listOfDays = new ArrayList();

            SqlConnection sqlConnection = DataBase.SqlOpenHelper.OpenConnection();
            SqlCommand sqlCommand = DataBase.SqlOpenHelper.ExecNonQueryReturn("SELECT name FROM tSubject;", sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                listOfDays.Add(sqlDataReader["name"]);
            }

            for (int i = 0; i < listOfDays.Count; i++)
            {
                cbClassname.Items.Add(listOfDays[i]);
            }

            DataBase.Tables.Schedule.FUNCTION_SELECT_TO_EDIT(thisId, cbClassname, tbStarttime, tbEndtime, tbLink);

        }

        private void butDone_Click(object sender, EventArgs e) {
            DataBase.Tables.Schedule.UPDATE_CLASS(cbClassname, tbStarttime, tbEndtime, tbLink);

            DataBase.Tables.Schedule.FUNCTION_SELECT(tDGV, thisDay);
            this.Close();
        }

        private void tbStarttime_Click(object sender, EventArgs e)
        {
            changeTextColor(tbStarttime, defTextStart);
        }




        //Metodo para reinicar los textos por defecto.
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

        private void tbEndtime_Click(object sender, EventArgs e)
        {
            changeTextColor(tbEndtime, defTextEnd);
        }

        private void tbLink_Click(object sender, EventArgs e)
        {
            changeTextColor(tbLink, defTextLink);
        }

        private void lHomework_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        private void cbClassname_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                changeTextColor(tbStarttime, defTextStart);
            }
        }

        private void tbStarttime_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab) {
                changeTextColor(tbEndtime, defTextEnd);
            }
        }

        private void tbEndtime_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                changeTextColor(tbLink, defTextLink);
            }
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
    }
}
