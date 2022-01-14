
namespace NoteSchool.Layout.Home
{
    partial class ScHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbHomework = new System.Windows.Forms.PictureBox();
            this.pbInformation = new System.Windows.Forms.PictureBox();
            this.pbSchedule = new System.Windows.Forms.PictureBox();
            this.pbSubject = new System.Windows.Forms.PictureBox();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHomework)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbHomework);
            this.panel1.Controls.Add(this.pbInformation);
            this.panel1.Controls.Add(this.pbSchedule);
            this.panel1.Controls.Add(this.pbSubject);
            this.panel1.Controls.Add(this.pbHome);
            this.panel1.Controls.Add(this.lTitle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 451);
            this.panel1.TabIndex = 0;
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.ForeColor = System.Drawing.Color.White;
            this.lTitle.Location = new System.Drawing.Point(16, 9);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(147, 32);
            this.lTitle.TabIndex = 0;
            this.lTitle.Text = "NoteSchool";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(181, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(765, 451);
            this.panel2.TabIndex = 1;
            // 
            // pbHomework
            // 
            this.pbHomework.Image = global::NoteSchool.Properties.Resources.homework;
            this.pbHomework.Location = new System.Drawing.Point(0, 311);
            this.pbHomework.Name = "pbHomework";
            this.pbHomework.Size = new System.Drawing.Size(181, 54);
            this.pbHomework.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHomework.TabIndex = 6;
            this.pbHomework.TabStop = false;
            this.pbHomework.Click += new System.EventHandler(this.pbHomework_Click);
            // 
            // pbInformation
            // 
            this.pbInformation.Image = global::NoteSchool.Properties.Resources.Information;
            this.pbInformation.Location = new System.Drawing.Point(125, 395);
            this.pbInformation.Name = "pbInformation";
            this.pbInformation.Size = new System.Drawing.Size(50, 50);
            this.pbInformation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInformation.TabIndex = 5;
            this.pbInformation.TabStop = false;
            this.pbInformation.Click += new System.EventHandler(this.pbInformation_Click);
            // 
            // pbSchedule
            // 
            this.pbSchedule.Image = global::NoteSchool.Properties.Resources.Calendar;
            this.pbSchedule.Location = new System.Drawing.Point(0, 224);
            this.pbSchedule.Name = "pbSchedule";
            this.pbSchedule.Size = new System.Drawing.Size(181, 54);
            this.pbSchedule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSchedule.TabIndex = 4;
            this.pbSchedule.TabStop = false;
            this.pbSchedule.Click += new System.EventHandler(this.pbSchedule_Click);
            // 
            // pbSubject
            // 
            this.pbSubject.Image = global::NoteSchool.Properties.Resources.Subject;
            this.pbSubject.Location = new System.Drawing.Point(0, 139);
            this.pbSubject.Name = "pbSubject";
            this.pbSubject.Size = new System.Drawing.Size(181, 54);
            this.pbSubject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSubject.TabIndex = 2;
            this.pbSubject.TabStop = false;
            this.pbSubject.Click += new System.EventHandler(this.pbSubject_Click);
            // 
            // pbHome
            // 
            this.pbHome.BackColor = System.Drawing.Color.White;
            this.pbHome.Image = global::NoteSchool.Properties.Resources.Background;
            this.pbHome.Location = new System.Drawing.Point(0, 55);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(181, 54);
            this.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHome.TabIndex = 1;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Home";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(59, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Schedule";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(54, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Homework";
            // 
            // ScHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteSchool v1.0.2";
            this.Load += new System.EventHandler(this.ScHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHomework)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbInformation;
        private System.Windows.Forms.PictureBox pbSchedule;
        private System.Windows.Forms.PictureBox pbSubject;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbHomework;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}