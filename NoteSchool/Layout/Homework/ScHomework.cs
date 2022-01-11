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


            DataBase.Tables.Subject.getAllSubjects(cbSubject);

            int id = DataBase.Tables.Subject.GET_SUBJECT_ID(cbSubject.Text);

            DataBase.Tables.Homework.SELECT_HOMEWORK(id, dgvHomework);
            DataBase.Tables.Homework.setDesignDGV(dgvHomework);

            cbSubject.SelectedIndex = 0;


        }


        private void cbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = DataBase.Tables.Subject.GET_SUBJECT_ID(cbSubject.Text);

            DataBase.Tables.Homework.SELECT_HOMEWORK(id, dgvHomework);

            dgvHomework.AllowUserToAddRows = false; //Desactva añadir una fila.
            DataGridViewColumn column;

            dgvHomework.Columns[0].Visible = false;
            dgvHomework.Columns[5].Visible = false;

            /*
            column = dgvHomework.Columns[1];
            column.HeaderText = "Subject name";
            column.Width = 199;

            column = dgvHomework.Columns[2];
            column.HeaderText = "Teacher name";
            column.Width = 166;

            column = dgvHomework.Columns[3];
            column.HeaderText = "Qualification scores";
            column.Width = 374;
            */

            //Estilo de texto para la tabla.
            dgvHomework.ForeColor = Color.White;
            dgvHomework.BackgroundColor = Color.FromArgb(28, 39, 43);
            dgvHomework.DefaultCellStyle.BackColor = Color.FromArgb(28, 39, 43);
            dgvHomework.AllowUserToResizeColumns = false;
            dgvHomework.AllowUserToResizeRows = false;

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
    }
}
