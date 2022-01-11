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
using NoteSchool.DataBase;

namespace NoteSchool.Layout.Subject
{
    public partial class ScEditSubject : Form
    {

        //Default text.
        String defaultTextName = "Subject name";
        String defaultTextTeacherName = "Teacher´s name";
        String defaultTextQualfication = "Qualification scores";

        //Codigo para activar el doble buffer
        protected override CreateParams CreateParams {
            get {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        //Database
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;

        //Var
        private String subjectName;
        private String teacherName;
        private String qualificationScores;
        private String icon;
        private DataGridView tDGV;

        //Layout
        ScSubject scSubject = new ScSubject();

        //Constructor
        public ScEditSubject(String subjectName) {

            this.subjectName = subjectName;
            InitializeComponent();

        }

        //setDGV
        public DataGridView setDGV(DataGridView dGV) {
            tDGV = dGV;
            return dGV;
        }

        //Done click
        private void butEditSubject_Click(object sender, EventArgs e) {

            //Set values
            String tempSubjectName = tbSubjectName.Text;
            teacherName = tbTeacherName.Text;
            qualificationScores = tbQualificationScores.Text;
            
            DataBase.Tables.Subject.UPDATE_TABLE_SUBJECT(this, subjectName, tempSubjectName, teacherName, qualificationScores, icon);
            DataBase.Tables.Subject.fillDgv(tDGV);
            this.Close();
            

        }

        //Fill data
        private void ScEditSubject_Load(object sender, EventArgs e) {

            this.ActiveControl = lTitle;

            DataBase.Tables.Subject.SELECT_FROM_SUBJECT(subjectName, tbSubjectName, tbTeacherName, tbQualificationScores);

            tbSubjectName.ForeColor = Color.White;
            tbTeacherName.ForeColor = Color.White;
            tbQualificationScores.ForeColor = Color.White;

            
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

        private void tbSubjectName_Click(object sender, EventArgs e)
        {
            changeTextColor(tbSubjectName, defaultTextName);
        }

        private void tbTeacherName_Click(object sender, EventArgs e)
        {
            changeTextColor(tbTeacherName, defaultTextTeacherName);
        }

        private void tbQualificationScores_Click(object sender, EventArgs e)
        {
            changeTextColor(tbQualificationScores, defaultTextQualfication);
        }

        private void tbSubjectName_Leave(object sender, EventArgs e)
        {
            resetText(tbSubjectName, defaultTextName);
        }

        private void tbTeacherName_Leave(object sender, EventArgs e)
        {
            resetText(tbTeacherName, defaultTextTeacherName);
        }

        private void tbQualificationScores_Leave(object sender, EventArgs e)
        {
            resetText(tbQualificationScores, defaultTextQualfication);
        }

        private void lTitle_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab) {
                changeTextColor(tbSubjectName, defaultTextName);
            }
        }

        private void tbSubjectName_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                changeTextColor(tbTeacherName, defaultTextTeacherName);
            }
        }

        private void tbTeacherName_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                changeTextColor(tbQualificationScores, defaultTextQualfication);
            }
        }

        private void butEditSubject_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                changeTextColor(tbSubjectName, defaultTextName);
            }
        }
    }
}
