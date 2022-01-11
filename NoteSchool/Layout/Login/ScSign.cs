using NoteSchool.Layout.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteSchool.Layout.Login
{
    public partial class ScSign : Form
    {

        //Vars
        private String userName;
        private String userPassword; 
        private String dfUserName = "User name";
        private String dfPassword = "Password";

        public ScSign()
        {
            InitializeComponent();
        }

        private void butSignUp_Click(object sender, EventArgs e) {

            userName = tbUserName.Text;
            userPassword = tbUserPassword.Text;

            DataBase.Tables.User.INSERT_INTO_USER(this, userName, userPassword);


        }

        private void pbBack_Click(object sender, EventArgs e) {
            

            ScLogin scLogin = new ScLogin();
            scLogin.Show();
            this.Dispose();
        }


        //Metodo para reinicar los textos por defecto.
        public void resetText(TextBox tb, String text)
        {

            //Verificamos que el TB esté vacio.
            if (tb.Text == "")
            {

                tb.ForeColor = (Color.DarkGray); //Cambiamos el color del TB
                tb.Text = (text); //Reiniciamos el texto por defecto.

            }

        }

        //Metodo para cambiar el color y limpiar el TB.
        public void changeTextColor(TextBox tb, String text)
        {

            //Verificamos que los textos sean iguales.
            if (tb.Text == text)
            {

                tb.Text = (""); //Limpiamos el TB.
                tb.ForeColor = Color.White; //Cambiamos el color de la leta.

            }

        }

        private void tbUserName_Click(object sender, EventArgs e)
        {
            changeTextColor(tbUserName, dfUserName);
        }

        private void tbUserName_Leave(object sender, EventArgs e)
        {
            resetText(tbUserName, dfUserName);
        }

        private void tbUserName_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                changeTextColor(tbUserPassword, dfPassword);
            }
        }

        private void tbUserPassword_Click(object sender, EventArgs e)
        {
            changeTextColor(tbUserPassword, dfPassword);
        }

        private void tbUserPassword_Leave(object sender, EventArgs e)
        {
            resetText(tbUserPassword, dfPassword);
        }

        private void lTitle_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                changeTextColor(tbUserName, dfUserName);
            }
        }

        private void ScSign_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lTitle;
        }

        private void butSignUp_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                changeTextColor(tbUserName, dfUserName);
            }
        }
    }
}
