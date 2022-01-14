using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteSchool.Layout.Home
{
    public partial class ScStart : Form
    {
        public ScStart()
        {
            InitializeComponent();
        }

        private void ScStart_Activated(object sender, EventArgs e)
        {
            DataBase.Tables.Homework.GETCLASSESUNCOMPLETE(dgvHomework);
        }

        private void ScStart_Load(object sender, EventArgs e)
        {

            DataBase.Tables.Homework.GETCLASSESUNCOMPLETE(dgvHomework);


            DataBase.Tables.Schedule.FUNCTION_SELECT(dgvSchedule, "Monday");
            setDesignDGV(dgvSchedule);
        }

        private void cbDayList_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataBase.Tables.Schedule.FUNCTION_SELECT(dgvSchedule, cbDayList.Text);
            setDesignDGV(dgvSchedule);
            lDay.Text = cbDayList.Text;
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
            column.Width = 165;

            column = dgv.Columns[3];
            column.HeaderText = "Start time";
            column.Width = 100;

            column = dgv.Columns[4];
            column.HeaderText = "End time";
            column.Width = 100;

            column = dgv.Columns[5];
            column.HeaderText = "Virtual class";
            column.Width = 235;

            //Estilo de texto para la tabla.
            dgv.ForeColor = Color.White;
            dgv.BackgroundColor = Color.FromArgb(28, 39, 43);
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(28, 39, 43);
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
        }

        private void dgvSchedule_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBase.Tables.Schedule.openLink(dgvSchedule);
        }

        private void ScStart_VisibleChanged(object sender, EventArgs e)
        {

            DataBase.Tables.Homework.GETCLASSESUNCOMPLETE(dgvHomework);

            DataBase.Tables.Schedule.FUNCTION_SELECT(dgvSchedule, cbDayList.Text);
            setDesignDGV(dgvSchedule);

        }
    }
}
