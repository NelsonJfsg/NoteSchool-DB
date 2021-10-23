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
            icon = cbIcon.Text;

            DataBase.Tables.Subject.UPDATE_TABLE_SUBJECT(this, subjectName, tempSubjectName, teacherName, qualificationScores, icon);
            DataBase.Tables.Subject.fillDgv(tDGV);
            

        }

        //Fill data
        private void ScEditSubject_Load(object sender, EventArgs e) {

            DataBase.Tables.Subject.SELECT_FROM_SUBJECT(subjectName , tbSubjectName, tbTeacherName, tbQualificationScores, cbIcon);
            
        }
    }
}
