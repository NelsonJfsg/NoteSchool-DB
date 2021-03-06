
namespace NoteSchool.Layout.Homework
{
    partial class ScAddHomework
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScAddHomework));
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.rtBody = new System.Windows.Forms.RichTextBox();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.butAddHomework = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.tbTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.ForeColor = System.Drawing.Color.White;
            this.tbTitle.Location = new System.Drawing.Point(88, 65);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(221, 27);
            this.tbTitle.TabIndex = 0;
            // 
            // rtBody
            // 
            this.rtBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.rtBody.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtBody.ForeColor = System.Drawing.Color.White;
            this.rtBody.Location = new System.Drawing.Point(29, 134);
            this.rtBody.Name = "rtBody";
            this.rtBody.Size = new System.Drawing.Size(743, 266);
            this.rtBody.TabIndex = 1;
            this.rtBody.Text = "";
            // 
            // cbSubject
            // 
            this.cbSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSubject.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSubject.ForeColor = System.Drawing.Color.White;
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(651, 64);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(121, 29);
            this.cbSubject.TabIndex = 2;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dateTimePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.dateTimePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(143)))), ((int)(((byte)(124)))));
            this.dateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(500, 64);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(117, 27);
            this.dateTimePicker.TabIndex = 3;
            // 
            // butAddHomework
            // 
            this.butAddHomework.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            this.butAddHomework.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAddHomework.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.butAddHomework.ForeColor = System.Drawing.Color.White;
            this.butAddHomework.Location = new System.Drawing.Point(651, 406);
            this.butAddHomework.Name = "butAddHomework";
            this.butAddHomework.Size = new System.Drawing.Size(121, 29);
            this.butAddHomework.TabIndex = 4;
            this.butAddHomework.Text = "Done";
            this.butAddHomework.UseVisualStyleBackColor = false;
            this.butAddHomework.Click += new System.EventHandler(this.butAddHomework_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.ForeColor = System.Drawing.Color.White;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Unfilled",
            "Complete"});
            this.cbStatus.Location = new System.Drawing.Point(107, 408);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 29);
            this.cbStatus.TabIndex = 5;
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            this.lTitle.Location = new System.Drawing.Point(22, 9);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(228, 40);
            this.lTitle.TabIndex = 12;
            this.lTitle.Text = "Add homework";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            this.label1.Location = new System.Drawing.Point(429, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            this.label2.Location = new System.Drawing.Point(23, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            this.label3.Location = new System.Drawing.Point(23, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 32);
            this.label3.TabIndex = 15;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            this.label4.Location = new System.Drawing.Point(23, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 32);
            this.label4.TabIndex = 16;
            this.label4.Text = "Title";
            // 
            // ScAddHomework
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.butAddHomework);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.cbSubject);
            this.Controls.Add(this.rtBody);
            this.Controls.Add(this.tbTitle);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScAddHomework";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteSchool - Add homework";
            this.Load += new System.EventHandler(this.ScAddHomework_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.RichTextBox rtBody;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button butAddHomework;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}