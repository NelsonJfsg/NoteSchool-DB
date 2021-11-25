
namespace NoteSchool.Layout.Login
{
    partial class ScSign
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
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbUserPassword = new System.Windows.Forms.TextBox();
            this.butSignUp = new System.Windows.Forms.Button();
            this.lTitle = new System.Windows.Forms.Label();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUserName
            // 
            this.tbUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.tbUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUserName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbUserName.ForeColor = System.Drawing.Color.DarkGray;
            this.tbUserName.Location = new System.Drawing.Point(78, 229);
            this.tbUserName.Multiline = true;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(192, 27);
            this.tbUserName.TabIndex = 0;
            this.tbUserName.Text = "User name";
            this.tbUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbUserPassword
            // 
            this.tbUserPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.tbUserPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUserPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbUserPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.tbUserPassword.Location = new System.Drawing.Point(78, 280);
            this.tbUserPassword.Multiline = true;
            this.tbUserPassword.Name = "tbUserPassword";
            this.tbUserPassword.Size = new System.Drawing.Size(192, 27);
            this.tbUserPassword.TabIndex = 1;
            this.tbUserPassword.Text = "Password";
            this.tbUserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // butSignUp
            // 
            this.butSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            this.butSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSignUp.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.butSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.butSignUp.Location = new System.Drawing.Point(103, 344);
            this.butSignUp.Name = "butSignUp";
            this.butSignUp.Size = new System.Drawing.Size(139, 29);
            this.butSignUp.TabIndex = 2;
            this.butSignUp.Text = "Sign Up";
            this.butSignUp.UseVisualStyleBackColor = false;
            this.butSignUp.Click += new System.EventHandler(this.butSignUp_Click);
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.ForeColor = System.Drawing.Color.White;
            this.lTitle.Location = new System.Drawing.Point(73, 23);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(196, 25);
            this.lTitle.TabIndex = 3;
            this.lTitle.Text = "Create a new account";
            // 
            // pbBack
            // 
            this.pbBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBack.Image = global::NoteSchool.Properties.Resources.back_button;
            this.pbBack.Location = new System.Drawing.Point(296, 12);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(40, 40);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 7;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NoteSchool.Properties.Resources.add_user;
            this.pictureBox1.Location = new System.Drawing.Point(103, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ScSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(348, 420);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.butSignUp);
            this.Controls.Add(this.tbUserPassword);
            this.Controls.Add(this.tbUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScSign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScSign";
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbUserPassword;
        private System.Windows.Forms.Button butSignUp;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbBack;
    }
}