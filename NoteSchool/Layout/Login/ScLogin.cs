using NoteSchool.DataBase.Tables;
using NoteSchool.DataBase.Utilities;
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
    public partial class ScLogin : Form
    {

        //Vars
        private String userName;
        private String userPassword;

        private String dfUserName = "User name";
        private String dfPassword = "Password";

        public ScLogin() {
            InitializeComponent();
        }

        private void butLogin_Click(object sender, EventArgs e) {
            
            //Set data
            userName = tbUserName.Text;
            userPassword = tbPassword.Text;
            
            User.userAuthentication(this, userName, userPassword);



            
        }

        private void lSignUp_Click(object sender, EventArgs e) {

            ScSign scSign = new ScSign();

            this.Hide();
            scSign.Show();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ScLogin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lTitle;
            Utilities.CreateAllTables();
        }

        private void tbUserName_Click(object sender, EventArgs e)
        {
            changeTextColor(tbUserName, dfUserName);
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

        private void tbUserName_Leave(object sender, EventArgs e)
        {
            resetText(tbUserName, dfUserName);
        }

        private void lTitle_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab) {
                changeTextColor(tbUserName, dfUserName);
            }
        }

        private void tbUserName_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab) {
                changeTextColor(tbPassword, dfPassword);
            }
        }

        private void tbPassword_Click(object sender, EventArgs e)
        {
            changeTextColor(tbPassword, dfPassword);
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            resetText(tbPassword, dfPassword);
        }

        private void butLogin_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                changeTextColor(tbUserName, dfUserName);
            }
        }
    }
}
