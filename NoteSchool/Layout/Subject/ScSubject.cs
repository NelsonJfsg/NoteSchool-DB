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

            DataBase.Tables.Subject.fillDgv(dgvSubject);

            DataBase.Tables.Subject.setDesignDGV(dgvSubject);
        }

        //Add click
        private void pbAddSubject_Click(object sender, EventArgs e) {
            
            ScAddSubject scAddSubject = new ScAddSubject();
            scAddSubject.setDGV(dgvSubject);
            scAddSubject.Show();

        }

        //TEMPORAL
        private void lTitle_Click(object sender, EventArgs e) {

            DataBase.Tables.Subject.fillDgv(dgvSubject);

            DataBase.Tables.Subject.setDesignDGV(dgvSubject);
        }

        //Delete click
        private void pbDeleteSubject_Click(object sender, EventArgs e) {

            //Var


            if (dgvSubject.Rows.Count == 0) {

                MessageBox.Show("Select a subject.");

            } else {

                DataBase.Tables.Subject.DELETE_SUBJECT(dgvSubject.CurrentRow.Cells[0].Value.ToString());
                updateDGV();

            }

        }

        //Edit click
        private void pbEditSubject_Click(object sender, EventArgs e) {

            if (dgvSubject.Rows.Count != 0) {

                ScEditSubject scEditSubject = new ScEditSubject(dgvSubject.CurrentRow.Cells[0].Value.ToString());
                scEditSubject.setDGV(dgvSubject);
                scEditSubject.Show();

            } else {

                MessageBox.Show("Select a subject.");

            }

        }

        //Methods 
        public void updateDGV() {

            DataBase.Tables.Subject.fillDgv(dgvSubject);

            DataBase.Tables.Subject.setDesignDGV(dgvSubject);

        }
    }
}
