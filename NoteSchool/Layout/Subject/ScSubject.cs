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
    public partial class ScSubject : Form
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

        //Constructor
        public ScSubject() {
            InitializeComponent();
        }

        //Load event
        private void ScSubject_Load(object sender, EventArgs e) {
            this.ActiveControl = lTitle;

            DataBase.Tables.Subject.fillDgv(dgvHomework);

            DataBase.Tables.Subject.setDesignDGV(dgvHomework);
        }

        //Add click
        private void pbAddSubject_Click(object sender, EventArgs e) {
            
            ScAddSubject scAddSubject = new ScAddSubject();
            scAddSubject.setDGV(dgvHomework);
            scAddSubject.Show();

        }

        //Delete click
        private void pbDeleteSubject_Click(object sender, EventArgs e) {

            //Var
            if (dgvHomework.Rows.Count == 0) {

                MessageBox.Show("Select a subject.");

            } else {

                DataBase.Tables.Subject.DELETE_SUBJECT(dgvHomework.CurrentRow.Cells[0].Value.ToString());
                updateDGV();

            }

        }

        //Edit click
        private void pbEditSubject_Click(object sender, EventArgs e) {

            if (dgvHomework.Rows.Count != 0) {

                ScEditSubject scEditSubject = new ScEditSubject(dgvHomework.CurrentRow.Cells[1].Value.ToString());
                scEditSubject.setDGV(dgvHomework);
                scEditSubject.Show();

            } else {

                MessageBox.Show("Select a subject.");

            }

        }

        //Methods 
        public void updateDGV() {

            DataBase.Tables.Subject.fillDgv(dgvHomework);

            DataBase.Tables.Subject.setDesignDGV(dgvHomework);

        }
    }
}
