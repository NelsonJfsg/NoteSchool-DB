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
    public partial class ScEditHomework : Form
    {

        //Vars
        private static int thisId;
        private static DataGridView dataGridView;
        private static ComboBox cbSubjectAdaptative;

        public ScEditHomework(int id, DataGridView dgv, ComboBox cb)
        {
            thisId = id;
            dataGridView = dgv;
            cbSubjectAdaptative = cb;
            InitializeComponent();
        }

        private void ScEditHomework_Load(object sender, EventArgs e)
        {
            DataBase.Tables.Subject.getAllSubjects(cbSubject);
            DataBase.Tables.Homework.getHomeworkWithId(thisId, tbTitle, cbSubject, dateTimePicker, rtBody, cbStatus);
            
        }

        private void butAddHomework_Click(object sender, EventArgs e)
        {
            String dates = dateTimePicker.Value.ToString("yyyy-MM-dd");

            int idSubject = DataBase.Tables.Subject.GET_SUBJECT_ID(cbSubject.Text);

            DataBase.Tables.Homework.updateHomework(thisId, tbTitle.Text, idSubject, dates, rtBody.Text, cbStatus.Text);
            
            DataBase.Tables.Homework.SELECT_HOMEWORK(idSubject, dataGridView);

            int index = cbSubject.Items.IndexOf(cbSubject.Text);

            cbSubjectAdaptative.SelectedIndex = index;

            this.Dispose();
        }
    }
}
