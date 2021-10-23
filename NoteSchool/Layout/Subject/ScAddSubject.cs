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

        //Layout
        ScSubject scSubject = new ScSubject();

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
            icon = cbIcon.Text;
            
            //Insert into DB
            DataBase.Tables.Subject.INSERT_INTO_SUBJECT(this, subjectName, teacherName, qualificationScores, icon);
            
            DataBase.Tables.Subject.fillDgv(tDGV);

            DataBase.Tables.Subject.setDesignDGV(tDGV);
        }

    }
}
