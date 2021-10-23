
namespace NoteSchool.Layout.Subject
{
    partial class ScAddSubject
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
            this.tbSubjectName = new System.Windows.Forms.TextBox();
            this.tbTeacherName = new System.Windows.Forms.TextBox();
            this.tbQualificationScores = new System.Windows.Forms.TextBox();
            this.butAddSubject = new System.Windows.Forms.Button();
            this.lHomework = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbIcon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.tbSubjectName.TabIndex = 0;
            this.tbSubjectName.Text = "Subject name";
            this.tbSubjectName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.tbTeacherName.TabIndex = 1;
            this.tbTeacherName.Text = "Teacher´s name";
            this.tbTeacherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.tbQualificationScores.TabIndex = 3;
            // 
            // butAddSubject
            // 
            this.butAddSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            this.butAddSubject.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAddSubject.ForeColor = System.Drawing.Color.White;
            this.butAddSubject.Location = new System.Drawing.Point(249, 251);
            this.butAddSubject.Name = "butAddSubject";
            this.butAddSubject.Size = new System.Drawing.Size(192, 37);
            this.butAddSubject.TabIndex = 5;
            this.butAddSubject.Text = "Done";
            this.butAddSubject.UseVisualStyleBackColor = false;
            this.butAddSubject.Click += new System.EventHandler(this.butAddSubject_Click);
            // 
            // lHomework
            // 
            this.lHomework.AutoSize = true;
            this.lHomework.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHomework.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            this.lHomework.Location = new System.Drawing.Point(145, 21);
            this.lHomework.Name = "lHomework";
            this.lHomework.Size = new System.Drawing.Size(179, 40);
            this.lHomework.TabIndex = 6;
            this.lHomework.Text = "Add subject";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NoteSchool.Properties.Resources.Add_Mark;
            this.pictureBox1.Location = new System.Drawing.Point(249, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
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
            this.cbIcon.TabIndex = 8;
            this.cbIcon.Text = "Choose icon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            this.label1.Location = new System.Drawing.Point(37, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Qualification scores";
            // 
            // ScAddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(468, 422);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbIcon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lHomework);
            this.Controls.Add(this.butAddSubject);
            this.Controls.Add(this.tbQualificationScores);
            this.Controls.Add(this.tbTeacherName);
            this.Controls.Add(this.tbSubjectName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(484, 461);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(484, 461);
            this.Name = "ScAddSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteSchool v0.2.1 - Add subject";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSubjectName;
        private System.Windows.Forms.TextBox tbTeacherName;
        private System.Windows.Forms.TextBox tbQualificationScores;
        private System.Windows.Forms.Button butAddSubject;
        private System.Windows.Forms.Label lHomework;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbIcon;
        private System.Windows.Forms.Label label1;
    }
}