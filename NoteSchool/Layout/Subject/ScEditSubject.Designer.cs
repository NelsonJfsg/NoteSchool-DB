
namespace NoteSchool.Layout.Subject
{
    partial class ScEditSubject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lQualificationScores = new System.Windows.Forms.Label();
            this.cbIcon = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lTitle = new System.Windows.Forms.Label();
            this.butEditSubject = new System.Windows.Forms.Button();
            this.tbQualificationScores = new System.Windows.Forms.TextBox();
            this.tbTeacherName = new System.Windows.Forms.TextBox();
            this.tbSubjectName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lQualificationScores
            // 
            this.lQualificationScores.AutoSize = true;
            this.lQualificationScores.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQualificationScores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            this.lQualificationScores.Location = new System.Drawing.Point(37, 147);
            this.lQualificationScores.Name = "lQualificationScores";
            this.lQualificationScores.Size = new System.Drawing.Size(185, 25);
            this.lQualificationScores.TabIndex = 17;
            this.lQualificationScores.Text = "Qualification scores";
            // 
            // cbIcon
            // 
            this.cbIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.cbIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbIcon.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIcon.ForeColor = System.Drawing.Color.White;
            this.cbIcon.FormattingEnabled = true;
            this.cbIcon.Items.AddRange(new object[] {
            "Icon"});
            this.cbIcon.Location = new System.Drawing.Point(249, 76);
            this.cbIcon.Name = "cbIcon";
            this.cbIcon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbIcon.Size = new System.Drawing.Size(192, 28);
            this.cbIcon.TabIndex = 16;
            this.cbIcon.Text = "Choose icon";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NoteSchool.Properties.Resources.Edir_Half_Line;
            this.pictureBox1.Location = new System.Drawing.Point(249, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            this.lTitle.Location = new System.Drawing.Point(145, 21);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(175, 40);
            this.lTitle.TabIndex = 14;
            this.lTitle.Text = "Edit subject";
            // 
            // butEditSubject
            // 
            this.butEditSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            this.butEditSubject.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEditSubject.ForeColor = System.Drawing.Color.White;
            this.butEditSubject.Location = new System.Drawing.Point(249, 251);
            this.butEditSubject.Name = "butEditSubject";
            this.butEditSubject.Size = new System.Drawing.Size(192, 37);
            this.butEditSubject.TabIndex = 13;
            this.butEditSubject.Text = "Done";
            this.butEditSubject.UseVisualStyleBackColor = false;
            this.butEditSubject.Click += new System.EventHandler(this.butEditSubject_Click);
            // 
            // tbQualificationScores
            // 
            this.tbQualificationScores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.tbQualificationScores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbQualificationScores.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQualificationScores.ForeColor = System.Drawing.Color.White;
            this.tbQualificationScores.Location = new System.Drawing.Point(32, 175);
            this.tbQualificationScores.Multiline = true;
            this.tbQualificationScores.Name = "tbQualificationScores";
            this.tbQualificationScores.Size = new System.Drawing.Size(192, 235);
            this.tbQualificationScores.TabIndex = 12;
            // 
            // tbTeacherName
            // 
            this.tbTeacherName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.tbTeacherName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTeacherName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTeacherName.ForeColor = System.Drawing.Color.White;
            this.tbTeacherName.Location = new System.Drawing.Point(32, 110);
            this.tbTeacherName.Name = "tbTeacherName";
            this.tbTeacherName.Size = new System.Drawing.Size(192, 27);
            this.tbTeacherName.TabIndex = 11;
            this.tbTeacherName.Text = "Teacher´s name";
            this.tbTeacherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSubjectName
            // 
            this.tbSubjectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.tbSubjectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSubjectName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubjectName.ForeColor = System.Drawing.Color.White;
            this.tbSubjectName.Location = new System.Drawing.Point(32, 77);
            this.tbSubjectName.Name = "tbSubjectName";
            this.tbSubjectName.Size = new System.Drawing.Size(192, 27);
            this.tbSubjectName.TabIndex = 10;
            this.tbSubjectName.Text = "Subject name";
            this.tbSubjectName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ScEditSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(468, 422);
            this.Controls.Add(this.lQualificationScores);
            this.Controls.Add(this.cbIcon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.butEditSubject);
            this.Controls.Add(this.tbQualificationScores);
            this.Controls.Add(this.tbTeacherName);
            this.Controls.Add(this.tbSubjectName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(484, 461);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(484, 461);
            this.Name = "ScEditSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteSchool v0.2.0 - Edit subject";
            this.Load += new System.EventHandler(this.ScEditSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lQualificationScores;
        private System.Windows.Forms.ComboBox cbIcon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Button butEditSubject;
        private System.Windows.Forms.TextBox tbQualificationScores;
        private System.Windows.Forms.TextBox tbTeacherName;
        private System.Windows.Forms.TextBox tbSubjectName;
    }
}