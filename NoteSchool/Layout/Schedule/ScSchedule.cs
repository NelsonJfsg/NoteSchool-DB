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

namespace NoteSchool.Layout.Schedule
{
    public partial class ScSchedule : Form
    {

        SqlConnection sqlConnection;

        public ScSchedule() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            ScAddClass scAddClass = new ScAddClass();
            scAddClass.Show();
        }

        private void ScSchedule_Load(object sender, EventArgs e) {

            


        }

        private void butCreateSubject_Click(object sender, EventArgs e) {

        }
    }
}
