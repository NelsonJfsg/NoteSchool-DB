using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteSchool.Layout.Homework
{
    public partial class ScHomework : Form
    {
        public ScHomework() {
            InitializeComponent();
        }


        private void pbAddSubject_Click(object sender, EventArgs e)
        {
            int id = DataBase.Tables.Subject.GET_SUBJECT_ID(cbSubject.Text);
            ScAddHomework scAddHomework = new ScAddHomework(dgvHomework, id, cbSubject);
            scAddHomework.Show();

        }

        private void ScHomework_Load(object sender, EventArgs e)
        {

            this.ActiveControl = lTitle;

            try {
                DataBase.Tables.Subject.getAllSubjects(cbSubject);

                cbSubject.SelectedIndex = 0;

                int id = DataBase.Tables.Subject.GET_SUBJECT_ID(cbSubject.Text);

                DataBase.Tables.Homework.SELECT_HOMEWORK(id, dgvHomework);

            } catch (Exception err) {

                MessageBox.Show("First add a new subject.");
                
            }

        }


        private void cbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = DataBase.Tables.Subject.GET_SUBJECT_ID(cbSubject.Text);

            DataBase.Tables.Homework.SELECT_HOMEWORK(id, dgvHomework);

        }

        private void pbDeleteSubject_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dgvHomework.CurrentRow.Cells[0].Value.ToString());

            String subjectName = cbSubject.Text;
            int subjectId = DataBase.Tables.Subject.GET_SUBJECT_ID(subjectName);

            DataBase.Tables.Homework.deleteHomework(id);
            DataBase.Tables.Homework.SELECT_HOMEWORK(subjectId, dgvHomework);
        }

        private void pbEditSubject_Click(object sender, EventArgs e)
        {
            ScEditHomework scEditHomework = new ScEditHomework(Int32.Parse(dgvHomework.CurrentRow.Cells[0].Value.ToString()), dgvHomework, cbSubject);
            scEditHomework.Show();
        }

        private void cbSubject_Click(object sender, EventArgs e)
        {
            DataBase.Tables.Subject.getAllSubjects(cbSubject);
        }
    }
}
