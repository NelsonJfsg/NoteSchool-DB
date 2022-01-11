
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
            this.lTitle = new System.Windows.Forms.Label();
            this.lQualification = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbSubjectName
            // 
            this.tbSubjectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.tbSubjectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSubjectName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubjectName.ForeColor = System.Drawing.Color.DarkGray;
            this.tbSubjectName.Location = new System.Drawing.Point(53, 73);
            this.tbSubjectName.Name = "tbSubjectName";
            this.tbSubjectName.Size = new System.Drawing.Size(226, 27);
            this.tbSubjectName.TabIndex = 1;
            this.tbSubjectName.Text = "Subject name";
            this.tbSubjectName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSubjectName.Click += new System.EventHandler(this.tbSubjectName_Click);
            this.tbSubjectName.Leave += new System.EventHandler(this.tbSubjectName_Leave);
            this.tbSubjectName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tbSubjectName_PreviewKeyDown);
            // 
            // tbTeacherName
            // 
            this.tbTeacherName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.tbTeacherName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTeacherName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTeacherName.ForeColor = System.Drawing.Color.DarkGray;
            this.tbTeacherName.Location = new System.Drawing.Point(53, 106);
            this.tbTeacherName.Name = "tbTeacherName";
            this.tbTeacherName.Size = new System.Drawing.Size(226, 27);
            this.tbTeacherName.TabIndex = 2;
            this.tbTeacherName.Text = "Teacher´s name";
            this.tbTeacherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTeacherName.Click += new System.EventHandler(this.tbTeacherName_Click);
            this.tbTeacherName.Leave += new System.EventHandler(this.tbTeacherName_Leave);
            this.tbTeacherName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tbTeacherName_PreviewKeyDown);
            // 
            // tbQualificationScores
            // 
            this.tbQualificationScores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.tbQualificationScores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbQualificationScores.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQualificationScores.ForeColor = System.Drawing.Color.DarkGray;
            this.tbQualificationScores.Location = new System.Drawing.Point(24, 171);
            this.tbQualificationScores.Multiline = true;
            this.tbQualificationScores.Name = "tbQualificationScores";
            this.tbQualificationScores.Size = new System.Drawing.Size(281, 246);
            this.tbQualificationScores.TabIndex = 4;
            this.tbQualificationScores.Text = "Qualification scores";
            this.tbQualificationScores.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbQualificationScores.Click += new System.EventHandler(this.tbQualificationScores_Click);
            this.tbQualificationScores.Leave += new System.EventHandler(this.tbQualificationScores_Leave);
            // 
            // butAddSubject
            // 
            this.butAddSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            this.butAddSubject.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAddSubject.ForeColor = System.Drawing.Color.White;
            this.butAddSubject.Location = new System.Drawing.Point(68, 432);
            this.butAddSubject.Name = "butAddSubject";
            this.butAddSubject.Size = new System.Drawing.Size(192, 37);
            this.butAddSubject.TabIndex = 5;
            this.butAddSubject.Text = "Done";
            this.butAddSubject.UseVisualStyleBackColor = false;
            this.butAddSubject.Click += new System.EventHandler(this.butAddSubject_Click);
            this.butAddSubject.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.butAddSubject_PreviewKeyDown);
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            this.lTitle.Location = new System.Drawing.Point(74, 17);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(179, 40);
            this.lTitle.TabIndex = 0;
            this.lTitle.Text = "Add subject";
            this.lTitle.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.lHomework_PreviewKeyDown);
            // 
            // lQualification
            // 
            this.lQualification.AutoSize = true;
            this.lQualification.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQualification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            this.lQualification.Location = new System.Drawing.Point(75, 143);
            this.lQualification.Name = "lQualification";
            this.lQualification.Size = new System.Drawing.Size(185, 25);
            this.lQualification.TabIndex = 3;
            this.lQualification.Text = "Qualification scores";
            // 
            // ScAddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(332, 481);
            this.Controls.Add(this.lQualification);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.butAddSubject);
            this.Controls.Add(this.tbQualificationScores);
            this.Controls.Add(this.tbTeacherName);
            this.Controls.Add(this.tbSubjectName);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScAddSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteSchool v0.2.1 - Add subject";
            this.Load += new System.EventHandler(this.ScAddSubject_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSubjectName;
        private System.Windows.Forms.TextBox tbTeacherName;
        private System.Windows.Forms.TextBox tbQualificationScores;
        private System.Windows.Forms.Button butAddSubject;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Label lQualification;
    }
}