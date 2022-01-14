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


        private void ScSchedule_Load(object sender, EventArgs e) {
            
            DataBase.Tables.Schedule.FUNCTION_SELECT(dgvSchedule, "Monday");
            setDesignDGV(dgvSchedule);
        }


       

        private void pbAddClass_Click(object sender, EventArgs e) {

            ScAddClass scAddClass = new ScAddClass(lDay.Text);
            scAddClass.setDGV(dgvSchedule);
            scAddClass.Show();
            
        }

        private void pbEditClass_Click(object sender, EventArgs e) {

            int id = Int32.Parse(dgvSchedule.CurrentRow.Cells[0].Value.ToString());
            
            ScEditClass scEditClass = new ScEditClass(id, lDay.Text);
            scEditClass.setDGV(dgvSchedule);
            scEditClass.Show();

        }
        
        //Design
        public static void setDesignDGV(DataGridView dgv)
        {

            dgv.AllowUserToAddRows = false; //Desactva añadir una fila.
            DataGridViewColumn column;
            
            dgv.Columns[0].Visible = false;
            dgv.Columns[2].Visible = false;

            column = dgv.Columns[1];
            column.HeaderText = "Subject name";
            column.Width = 200;

            column = dgv.Columns[3];
            column.HeaderText = "Start time";
            column.Width = 103;

            column = dgv.Columns[4];
            column.HeaderText = "End time";
            column.Width = 103;

            column = dgv.Columns[5];
            column.HeaderText = "Virtual class";
            column.Width = 333;

            //Estilo de texto para la tabla.
            dgv.ForeColor = Color.White;
            dgv.BackgroundColor = Color.FromArgb(28, 39, 43);
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(28, 39, 43);
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
        }

        private void mondayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lDay.Text = "Monday";
            DataBase.Tables.Schedule.FUNCTION_SELECT(dgvSchedule, "Monday");
        }

        private void tuesdayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lDay.Text = "Tuesday";
            DataBase.Tables.Schedule.FUNCTION_SELECT(dgvSchedule, "Tuesday");
        }

        private void wedensdayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lDay.Text = "Wednesday";
            DataBase.Tables.Schedule.FUNCTION_SELECT(dgvSchedule, "Wednesday");
        }

        private void thursdayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lDay.Text = "Thursday";
            DataBase.Tables.Schedule.FUNCTION_SELECT(dgvSchedule, "Thursday");
        }

        private void fridayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lDay.Text = "Friday";
            DataBase.Tables.Schedule.FUNCTION_SELECT(dgvSchedule, "Friday");
        }

        private void saturdayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lDay.Text = "Saturday";
            DataBase.Tables.Schedule.FUNCTION_SELECT(dgvSchedule, "Saturday");
        }

        private void sundayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lDay.Text = "Sunday";
            DataBase.Tables.Schedule.FUNCTION_SELECT(dgvSchedule, "Sunday");
        }

        private void pbDeleteClass_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dgvSchedule.CurrentRow.Cells[0].Value.ToString());

            DataBase.Tables.Schedule.DELETE_CLASS(id);
            DataBase.Tables.Schedule.FUNCTION_SELECT(dgvSchedule, lDay.Text);
        }

        private void dgvSchedule_DoubleClick(object sender, EventArgs e)
        {
            DataBase.Tables.Schedule.openLink(dgvSchedule);
        }
    }
}
