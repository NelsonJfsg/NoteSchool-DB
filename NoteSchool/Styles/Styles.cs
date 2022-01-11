using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteSchool.Styles
{
    class Styles
    {


        public static void setDesignDGV(DataGridView dgv)
        {

            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToAddRows = false; //Desactva añadir una fila.
            dgv.BorderStyle = 0;
            
            
            
            
            DataGridViewColumn column;

            column = dgv.Columns[0];
            column.HeaderText = "Subject name";
            column.Width = 199;

            column = dgv.Columns[1];
            column.HeaderText = "Teacher name";
            column.Width = 166;

            column = dgv.Columns[2];
            column.HeaderText = "Qualification scores";
            column.Width = 374;

            //Estilo de texto para la tabla.
            dgv.ForeColor = Color.White;
            dgv.BackgroundColor = Color.FromArgb(28, 39, 43);
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(28, 39, 43);
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
        }




    }
}
