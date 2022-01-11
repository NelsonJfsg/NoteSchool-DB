
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
            this.lTitle = new System.Windows.Forms.Label();
            this.butEditSubject = new System.Windows.Forms.Button();
            this.tbQualificationScores = new System.Windows.Forms.TextBox();
            this.tbTeacherName = new System.Windows.Forms.TextBox();
            this.tbSubjectName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lQualificationScores
            // 
            this.lQualificationScores.AutoSize = true;
            this.lQualificationScores.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQualificationScores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            this.lQualificationScores.Location = new System.Drawing.Point(75, 143);
            this.lQualificationScores.Name = "lQualificationScores";
            this.lQualificationScores.Size = new System.Drawing.Size(185, 25);
            this.lQualificationScores.TabIndex = 17;
            this.lQualificationScores.Text = "Qualification scores";
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            this.lTitle.Location = new System.Drawing.Point(74, 17);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(175, 40);
            this.lTitle.TabIndex = 14;
            this.lTitle.Text = "Edit subject";
            this.lTitle.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.lTitle_PreviewKeyDown);
            // 
            // butEditSubject
            // 
            this.butEditSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            this.butEditSubject.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEditSubject.ForeColor = System.Drawing.Color.White;
            this.butEditSubject.Location = new System.Drawing.Point(68, 432);
            this.butEditSubject.Name = "butEditSubject";
            this.butEditSubject.Size = new System.Drawing.Size(192, 37);
            this.butEditSubject.TabIndex = 13;
            this.butEditSubject.Text = "Done";
            this.butEditSubject.UseVisualStyleBackColor = false;
            this.butEditSubject.Click += new System.EventHandler(this.butEditSubject_Click);
            this.butEditSubject.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.butEditSubject_PreviewKeyDown);
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
            this.tbQualificationScores.TabIndex = 12;
            this.tbQualificationScores.Text = "Qualification scores";
            this.tbQualificationScores.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbQualificationScores.Click += new System.EventHandler(this.tbQualificationScores_Click);
            this.tbQualificationScores.Leave += new System.EventHandler(this.tbQualificationScores_Leave);
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
            this.tbTeacherName.TabIndex = 11;
            this.tbTeacherName.Text = "Teacher´s name";
            this.tbTeacherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTeacherName.Click += new System.EventHandler(this.tbTeacherName_Click);
            this.tbTeacherName.Leave += new System.EventHandler(this.tbTeacherName_Leave);
            this.tbTeacherName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tbTeacherName_PreviewKeyDown);
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
            this.tbSubjectName.TabIndex = 10;
            this.tbSubjectName.Text = "Subject name";
            this.tbSubjectName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSubjectName.Click += new System.EventHandler(this.tbSubjectName_Click);
            this.tbSubjectName.Leave += new System.EventHandler(this.tbSubjectName_Leave);
            this.tbSubjectName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tbSubjectName_PreviewKeyDown);
            // 
            // ScEditSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(332, 481);
            this.Controls.Add(this.lQualificationScores);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.butEditSubject);
            this.Controls.Add(this.tbQualificationScores);
            this.Controls.Add(this.tbTeacherName);
            this.Controls.Add(this.tbSubjectName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(348, 520);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(348, 520);
            this.Name = "ScEditSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteSchool v0.2.1 - Edit subject";
            this.Load += new System.EventHandler(this.ScEditSubject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lQualificationScores;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Button butEditSubject;
        private System.Windows.Forms.TextBox tbQualificationScores;
        private System.Windows.Forms.TextBox tbTeacherName;
        private System.Windows.Forms.TextBox tbSubjectName;
    }
}