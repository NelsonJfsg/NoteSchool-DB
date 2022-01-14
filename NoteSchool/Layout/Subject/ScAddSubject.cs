using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NoteSchool.Layout.Subject
{
    public partial class ScAddSubject : Form
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

        //Vars
        private String subjectName;
        private String teacherName;
        private String qualificationScores;
        private String icon;
        private DataGridView tDGV;

        //Constructor
        public ScAddSubject() {
            InitializeComponent();
        }

        //setDGV
        public DataGridView setDGV(DataGridView dGV) {
            tDGV = dGV;
            return dGV;
        }

        //Done click
        private void butAddSubject_Click(object sender, EventArgs e) {

            //Set values
            subjectName = tbSubjectName.Text;
            teacherName = tbTeacherName.Text;
            qualificationScores = tbQualificationScores.Text;

            if (subjectName == defaultTextName) {
                MessageBox.Show("Please enter a valid name.");
            } else {
                if (teacherName == defaultTextTeacherName)
                {
                    teacherName = "No teachers name.";
                }

                if (qualificationScores == defaultTextQualfication)
                {
                    qualificationScores = "No qualification scores.";
                }

                //Insert into DB
                DataBase.Tables.Subject.INSERT_INTO_SUBJECT(this, subjectName, teacherName, qualificationScores);

                DataBase.Tables.Subject.fillDgv(tDGV);

                DataBase.Tables.Subject.setDesignDGV(tDGV);
                this.Close();
            }

            
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

        private void tbSubjectName_TextChanged(object sender, EventArgs e)
        {
            changeTextColor(tbSubjectName, defaultTextName);
        }

        private void tbSubjectName_Click(object sender, EventArgs e)
        {
            changeTextColor(tbSubjectName, defaultTextName);
        }

        private void tbSubjectName_Leave(object sender, EventArgs e)
        {
            resetText(tbSubjectName, defaultTextName);
        }

        private void tbTeacherName_Click(object sender, EventArgs e)
        {
            changeTextColor(tbTeacherName, defaultTextTeacherName);
        }

        private void tbTeacherName_Leave(object sender, EventArgs e)
        {
            resetText(tbTeacherName, defaultTextTeacherName);
        }

        private void tbQualificationScores_Click(object sender, EventArgs e)
        {
            changeTextColor(tbQualificationScores, defaultTextQualfication);
        }

        private void tbQualificationScores_Leave(object sender, EventArgs e)
        {
            resetText(tbQualificationScores, defaultTextQualfication);
        }

        private void lHomework_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            if (e.KeyData == Keys.Tab) {
                changeTextColor(tbSubjectName, defaultTextName);
            }

        }

        private void tbSubjectName_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            if (e.KeyData == Keys.Tab) {
                changeTextColor(tbTeacherName, defaultTextTeacherName);
            }

        }

        private void tbTeacherName_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            if (e.KeyData == Keys.Tab) {
                changeTextColor(tbQualificationScores, defaultTextQualfication);
            }

        }

        private void butAddSubject_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            if (e.KeyData == Keys.Tab) {
                changeTextColor(tbSubjectName, defaultTextName);
            }

        }

        private void ScAddSubject_Load(object sender, EventArgs e)
        {
            lQualification.TabIndex = 0;
        }

        private void ScAddSubject_Load_1(object sender, EventArgs e)
        {
            this.ActiveControl = lTitle;
        }
    }
}
