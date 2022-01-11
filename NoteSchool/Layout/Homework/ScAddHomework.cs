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
    public partial class ScAddHomework : Form
    {
        
        private static DataGridView dgv;
        private static int thisId;
        private static ComboBox cbSubjectAdaptative;

        public ScAddHomework(DataGridView dataGridView, int id, ComboBox cb)
        {
            dgv = dataGridView;
            thisId = id;
            cbSubjectAdaptative = cb;
            InitializeComponent();
        }

        private void butAddHomework_Click(object sender, EventArgs e)
        {

            dateTimePicker.CustomFormat = "yyyy-MM-dd";
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            
            //Vars
            String title = tbTitle.Text;
            String body = rtBody.Text;
            String date = dateTimePicker.Value.ToString("yyyy-MM-dd");
            String subject = cbSubject.Text;
            String status = cbStatus.Text;

            DataBase.Tables.Homework.INSERT_INTO(title, body, date, subject, status);
            int id = DataBase.Tables.Subject.GET_SUBJECT_ID(subject);

            DataBase.Tables.Homework.SELECT_HOMEWORK(id, dgv);
            int index = cbSubject.Items.IndexOf(subject);

            cbSubjectAdaptative.SelectedIndex = index;
            this.Dispose();

        }

        private void ScAddHomework_Load(object sender, EventArgs e)
        {
            DataBase.Tables.Subject.getAllSubjects(cbSubject);

            cbSubject.SelectedIndex = 0;
            cbStatus.SelectedIndex = 0;

        }
    }
}
