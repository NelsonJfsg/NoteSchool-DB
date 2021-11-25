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
    }
}
