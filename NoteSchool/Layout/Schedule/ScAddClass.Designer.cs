
namespace NoteSchool.Layout.Schedule
{
    partial class ScAddClass
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
            this.lHomework = new System.Windows.Forms.Label();
            this.cbClassname = new System.Windows.Forms.ComboBox();
            this.tbLink = new System.Windows.Forms.TextBox();
            this.tbStarttime = new System.Windows.Forms.TextBox();
            this.tbEndtime = new System.Windows.Forms.TextBox();
            this.butDone = new System.Windows.Forms.Button();
            this.cbMonday = new System.Windows.Forms.CheckBox();
            this.cbTuesday = new System.Windows.Forms.CheckBox();
            this.cbWednesday = new System.Windows.Forms.CheckBox();
            this.cbThursday = new System.Windows.Forms.CheckBox();
            this.cbFriday = new System.Windows.Forms.CheckBox();
            this.cbSaturday = new System.Windows.Forms.CheckBox();
            this.cbSunday = new System.Windows.Forms.CheckBox();
            this.gbDays = new System.Windows.Forms.GroupBox();
            this.lSubject = new System.Windows.Forms.Label();
            this.gbDays.SuspendLayout();
            this.SuspendLayout();
            // 
            // lHomework
            // 
            this.lHomework.AutoSize = true;
            this.lHomework.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHomework.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            this.lHomework.Location = new System.Drawing.Point(160, 16);
            this.lHomework.Name = "lHomework";
            this.lHomework.Size = new System.Drawing.Size(145, 40);
            this.lHomework.TabIndex = 0;
            this.lHomework.Text = "Add class";
            // 
            // cbClassname
            // 
            this.cbClassname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.cbClassname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClassname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbClassname.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cbClassname.ForeColor = System.Drawing.Color.White;
            this.cbClassname.FormattingEnabled = true;
            this.cbClassname.Location = new System.Drawing.Point(12, 103);
            this.cbClassname.Name = "cbClassname";
            this.cbClassname.Size = new System.Drawing.Size(226, 28);
            this.cbClassname.TabIndex = 1;
            this.cbClassname.Tag = "";
            this.cbClassname.Leave += new System.EventHandler(this.cbClassname_Leave);
            this.cbClassname.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cbClassname_PreviewKeyDown);
            // 
            // tbLink
            // 
            this.tbLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.tbLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLink.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLink.ForeColor = System.Drawing.Color.DarkGray;
            this.tbLink.Location = new System.Drawing.Point(12, 296);
            this.tbLink.Name = "tbLink";
            this.tbLink.Size = new System.Drawing.Size(444, 27);
            this.tbLink.TabIndex = 12;
            this.tbLink.Text = "Class link";
            this.tbLink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbLink.Click += new System.EventHandler(this.tbLink_Click);
            this.tbLink.Leave += new System.EventHandler(this.tbLink_Leave);
            // 
            // tbStarttime
            // 
            this.tbStarttime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.tbStarttime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbStarttime.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStarttime.ForeColor = System.Drawing.Color.DarkGray;
            this.tbStarttime.Location = new System.Drawing.Point(12, 202);
            this.tbStarttime.Name = "tbStarttime";
            this.tbStarttime.Size = new System.Drawing.Size(226, 27);
            this.tbStarttime.TabIndex = 2;
            this.tbStarttime.Text = "Class start time";
            this.tbStarttime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbStarttime.Click += new System.EventHandler(this.tbStarttime_Click);
            this.tbStarttime.Leave += new System.EventHandler(this.tbStarttime_Leave);
            this.tbStarttime.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tbStarttime_PreviewKeyDown);
            // 
            // tbEndtime
            // 
            this.tbEndtime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.tbEndtime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEndtime.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEndtime.ForeColor = System.Drawing.Color.DarkGray;
            this.tbEndtime.Location = new System.Drawing.Point(12, 245);
            this.tbEndtime.Name = "tbEndtime";
            this.tbEndtime.Size = new System.Drawing.Size(226, 27);
            this.tbEndtime.TabIndex = 3;
            this.tbEndtime.Text = "Class end time";
            this.tbEndtime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbEndtime.Click += new System.EventHandler(this.tbEndtime_Click);
            this.tbEndtime.Leave += new System.EventHandler(this.tbEndtime_Leave);
            // 
            // butDone
            // 
            this.butDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            this.butDone.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.butDone.ForeColor = System.Drawing.Color.White;
            this.butDone.Location = new System.Drawing.Point(133, 355);
            this.butDone.Name = "butDone";
            this.butDone.Size = new System.Drawing.Size(192, 37);
            this.butDone.TabIndex = 13;
            this.butDone.Text = "Done";
            this.butDone.UseVisualStyleBackColor = false;
            this.butDone.Click += new System.EventHandler(this.butDone_Click);
            // 
            // cbMonday
            // 
            this.cbMonday.AutoSize = true;
            this.cbMonday.BackColor = System.Drawing.Color.White;
            this.cbMonday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMonday.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cbMonday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.cbMonday.Location = new System.Drawing.Point(6, 19);
            this.cbMonday.Name = "cbMonday";
            this.cbMonday.Size = new System.Drawing.Size(79, 24);
            this.cbMonday.TabIndex = 5;
            this.cbMonday.Text = "Monday";
            this.cbMonday.UseVisualStyleBackColor = false;
            // 
            // cbTuesday
            // 
            this.cbTuesday.AutoSize = true;
            this.cbTuesday.BackColor = System.Drawing.Color.White;
            this.cbTuesday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTuesday.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cbTuesday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.cbTuesday.Location = new System.Drawing.Point(6, 43);
            this.cbTuesday.Name = "cbTuesday";
            this.cbTuesday.Size = new System.Drawing.Size(79, 24);
            this.cbTuesday.TabIndex = 6;
            this.cbTuesday.Text = "Tuesday";
            this.cbTuesday.UseVisualStyleBackColor = false;
            // 
            // cbWednesday
            // 
            this.cbWednesday.AutoSize = true;
            this.cbWednesday.BackColor = System.Drawing.Color.White;
            this.cbWednesday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbWednesday.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cbWednesday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.cbWednesday.Location = new System.Drawing.Point(6, 70);
            this.cbWednesday.Name = "cbWednesday";
            this.cbWednesday.Size = new System.Drawing.Size(101, 24);
            this.cbWednesday.TabIndex = 7;
            this.cbWednesday.Text = "Wednesday";
            this.cbWednesday.UseVisualStyleBackColor = false;
            // 
            // cbThursday
            // 
            this.cbThursday.AutoSize = true;
            this.cbThursday.BackColor = System.Drawing.Color.White;
            this.cbThursday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbThursday.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cbThursday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.cbThursday.Location = new System.Drawing.Point(6, 100);
            this.cbThursday.Name = "cbThursday";
            this.cbThursday.Size = new System.Drawing.Size(84, 24);
            this.cbThursday.TabIndex = 8;
            this.cbThursday.Text = "Thursday";
            this.cbThursday.UseVisualStyleBackColor = false;
            // 
            // cbFriday
            // 
            this.cbFriday.AutoSize = true;
            this.cbFriday.BackColor = System.Drawing.Color.White;
            this.cbFriday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFriday.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cbFriday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.cbFriday.Location = new System.Drawing.Point(6, 130);
            this.cbFriday.Name = "cbFriday";
            this.cbFriday.Size = new System.Drawing.Size(65, 24);
            this.cbFriday.TabIndex = 9;
            this.cbFriday.Text = "Friday";
            this.cbFriday.UseVisualStyleBackColor = false;
            // 
            // cbSaturday
            // 
            this.cbSaturday.AutoSize = true;
            this.cbSaturday.BackColor = System.Drawing.Color.White;
            this.cbSaturday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSaturday.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cbSaturday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.cbSaturday.Location = new System.Drawing.Point(6, 160);
            this.cbSaturday.Name = "cbSaturday";
            this.cbSaturday.Size = new System.Drawing.Size(83, 24);
            this.cbSaturday.TabIndex = 10;
            this.cbSaturday.Text = "Saturday";
            this.cbSaturday.UseVisualStyleBackColor = false;
            // 
            // cbSunday
            // 
            this.cbSunday.AutoSize = true;
            this.cbSunday.BackColor = System.Drawing.Color.White;
            this.cbSunday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSunday.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cbSunday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.cbSunday.Location = new System.Drawing.Point(6, 190);
            this.cbSunday.Name = "cbSunday";
            this.cbSunday.Size = new System.Drawing.Size(73, 24);
            this.cbSunday.TabIndex = 11;
            this.cbSunday.Text = "Sunday";
            this.cbSunday.UseVisualStyleBackColor = false;
            this.cbSunday.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cbSunday_PreviewKeyDown);
            // 
            // gbDays
            // 
            this.gbDays.Controls.Add(this.cbMonday);
            this.gbDays.Controls.Add(this.cbSunday);
            this.gbDays.Controls.Add(this.cbTuesday);
            this.gbDays.Controls.Add(this.cbSaturday);
            this.gbDays.Controls.Add(this.cbWednesday);
            this.gbDays.Controls.Add(this.cbFriday);
            this.gbDays.Controls.Add(this.cbThursday);
            this.gbDays.Location = new System.Drawing.Point(256, 64);
            this.gbDays.Name = "gbDays";
            this.gbDays.Size = new System.Drawing.Size(200, 217);
            this.gbDays.TabIndex = 4;
            this.gbDays.TabStop = false;
            this.gbDays.Text = "Select days";
            // 
            // lSubject
            // 
            this.lSubject.AutoSize = true;
            this.lSubject.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            this.lSubject.Location = new System.Drawing.Point(7, 70);
            this.lSubject.Name = "lSubject";
            this.lSubject.Size = new System.Drawing.Size(81, 30);
            this.lSubject.TabIndex = 14;
            this.lSubject.Text = "Subject";
            // 
            // ScAddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(468, 422);
            this.Controls.Add(this.lSubject);
            this.Controls.Add(this.gbDays);
            this.Controls.Add(this.butDone);
            this.Controls.Add(this.tbEndtime);
            this.Controls.Add(this.tbStarttime);
            this.Controls.Add(this.tbLink);
            this.Controls.Add(this.cbClassname);
            this.Controls.Add(this.lHomework);
            this.Name = "ScAddClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteSchool - Add class";
            this.Load += new System.EventHandler(this.ScAddClass_Load);
            this.gbDays.ResumeLayout(false);
            this.gbDays.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lHomework;
        private System.Windows.Forms.ComboBox cbClassname;
        private System.Windows.Forms.TextBox tbLink;
        private System.Windows.Forms.TextBox tbStarttime;
        private System.Windows.Forms.TextBox tbEndtime;
        private System.Windows.Forms.Button butDone;
        private System.Windows.Forms.CheckBox cbMonday;
        private System.Windows.Forms.CheckBox cbTuesday;
        private System.Windows.Forms.CheckBox cbWednesday;
        private System.Windows.Forms.CheckBox cbThursday;
        private System.Windows.Forms.CheckBox cbFriday;
        private System.Windows.Forms.CheckBox cbSaturday;
        private System.Windows.Forms.CheckBox cbSunday;
        private System.Windows.Forms.GroupBox gbDays;
        private System.Windows.Forms.Label lSubject;
    }
}