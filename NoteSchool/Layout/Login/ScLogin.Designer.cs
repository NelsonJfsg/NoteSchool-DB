
namespace NoteSchool.Layout.Login
{
    partial class ScLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lTitle = new System.Windows.Forms.Label();
            this.butLogin = new System.Windows.Forms.Button();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lSignUp = new System.Windows.Forms.Label();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.ForeColor = System.Drawing.Color.White;
            this.lTitle.Location = new System.Drawing.Point(60, 23);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(232, 25);
            this.lTitle.TabIndex = 0;
            this.lTitle.Text = "¡Welcome to NoteSchool!";
            // 
            // butLogin
            // 
            this.butLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            this.butLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.butLogin.Location = new System.Drawing.Point(103, 344);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(139, 29);
            this.butLogin.TabIndex = 1;
            this.butLogin.Text = "Log in";
            this.butLogin.UseVisualStyleBackColor = false;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.tbUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.ForeColor = System.Drawing.Color.DarkGray;
            this.tbUserName.Location = new System.Drawing.Point(78, 229);
            this.tbUserName.Multiline = true;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(192, 27);
            this.tbUserName.TabIndex = 2;
            this.tbUserName.Text = "User name";
            this.tbUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.tbPassword.Location = new System.Drawing.Point(78, 280);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '●';
            this.tbPassword.Size = new System.Drawing.Size(192, 27);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.Text = "Password";
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lSignUp
            // 
            this.lSignUp.AutoSize = true;
            this.lSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lSignUp.ForeColor = System.Drawing.Color.White;
            this.lSignUp.Location = new System.Drawing.Point(150, 385);
            this.lSignUp.Name = "lSignUp";
            this.lSignUp.Size = new System.Drawing.Size(45, 13);
            this.lSignUp.TabIndex = 4;
            this.lSignUp.Text = "Sign Up";
            this.lSignUp.Click += new System.EventHandler(this.lSignUp_Click);
            // 
            // pbExit
            // 
            this.pbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExit.Image = global::NoteSchool.Properties.Resources.exit;
            this.pbExit.Location = new System.Drawing.Point(298, 8);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(40, 40);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExit.TabIndex = 6;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NoteSchool.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(103, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ScLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(348, 420);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lSignUp);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.butLogin);
            this.Controls.Add(this.lTitle);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteSchool v0.5";
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lSignUp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbExit;
    }
}