using NoteSchool.DataBase.Tables;
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
    }
}
