
namespace NoteSchool.Layout.Schedule
{
    partial class ScSchedule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.lTitle = new System.Windows.Forms.Label();
            this.pbAddClass = new System.Windows.Forms.PictureBox();
            this.pbEditClass = new System.Windows.Forms.PictureBox();
            this.pbDeleteClass = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mondayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tuesdayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wedensdayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thursdayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fridayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saturdayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sundayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lDay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteClass)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSchedule.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSchedule.Location = new System.Drawing.Point(12, 35);
            this.dgvSchedule.MultiSelect = false;
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSchedule.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSchedule.RowHeadersVisible = false;
            this.dgvSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSchedule.Size = new System.Drawing.Size(741, 331);
            this.dgvSchedule.TabIndex = 0;
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            this.lTitle.Location = new System.Drawing.Point(5, 386);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(148, 40);
            this.lTitle.TabIndex = 10;
            this.lTitle.Text = "Schedule:";
            // 
            // pbAddClass
            // 
            this.pbAddClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddClass.Image = global::NoteSchool.Properties.Resources.Add_Circle_Outline;
            this.pbAddClass.Location = new System.Drawing.Point(568, 376);
            this.pbAddClass.Name = "pbAddClass";
            this.pbAddClass.Size = new System.Drawing.Size(53, 50);
            this.pbAddClass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddClass.TabIndex = 9;
            this.pbAddClass.TabStop = false;
            this.pbAddClass.Click += new System.EventHandler(this.pbAddClass_Click);
            // 
            // pbEditClass
            // 
            this.pbEditClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEditClass.Image = global::NoteSchool.Properties.Resources.Edir_Half_Line;
            this.pbEditClass.Location = new System.Drawing.Point(638, 376);
            this.pbEditClass.Name = "pbEditClass";
            this.pbEditClass.Size = new System.Drawing.Size(51, 50);
            this.pbEditClass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditClass.TabIndex = 8;
            this.pbEditClass.TabStop = false;
            this.pbEditClass.Click += new System.EventHandler(this.pbEditClass_Click);
            // 
            // pbDeleteClass
            // 
            this.pbDeleteClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDeleteClass.Image = global::NoteSchool.Properties.Resources.Delete;
            this.pbDeleteClass.Location = new System.Drawing.Point(705, 376);
            this.pbDeleteClass.Name = "pbDeleteClass";
            this.pbDeleteClass.Size = new System.Drawing.Size(50, 50);
            this.pbDeleteClass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDeleteClass.TabIndex = 7;
            this.pbDeleteClass.TabStop = false;
            this.pbDeleteClass.Click += new System.EventHandler(this.pbDeleteClass_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mondayToolStripMenuItem,
            this.tuesdayToolStripMenuItem,
            this.wedensdayToolStripMenuItem,
            this.thursdayToolStripMenuItem,
            this.fridayToolStripMenuItem,
            this.saturdayToolStripMenuItem,
            this.sundayToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(765, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mondayToolStripMenuItem
            // 
            this.mondayToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mondayToolStripMenuItem.Name = "mondayToolStripMenuItem";
            this.mondayToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.mondayToolStripMenuItem.Text = "Monday";
            this.mondayToolStripMenuItem.Click += new System.EventHandler(this.mondayToolStripMenuItem_Click);
            // 
            // tuesdayToolStripMenuItem
            // 
            this.tuesdayToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tuesdayToolStripMenuItem.Name = "tuesdayToolStripMenuItem";
            this.tuesdayToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.tuesdayToolStripMenuItem.Text = "Tuesday";
            this.tuesdayToolStripMenuItem.Click += new System.EventHandler(this.tuesdayToolStripMenuItem_Click);
            // 
            // wedensdayToolStripMenuItem
            // 
            this.wedensdayToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.wedensdayToolStripMenuItem.Name = "wedensdayToolStripMenuItem";
            this.wedensdayToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.wedensdayToolStripMenuItem.Text = "Wednesday";
            this.wedensdayToolStripMenuItem.Click += new System.EventHandler(this.wedensdayToolStripMenuItem_Click);
            // 
            // thursdayToolStripMenuItem
            // 
            this.thursdayToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.thursdayToolStripMenuItem.Name = "thursdayToolStripMenuItem";
            this.thursdayToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.thursdayToolStripMenuItem.Text = "Thursday";
            this.thursdayToolStripMenuItem.Click += new System.EventHandler(this.thursdayToolStripMenuItem_Click);
            // 
            // fridayToolStripMenuItem
            // 
            this.fridayToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fridayToolStripMenuItem.Name = "fridayToolStripMenuItem";
            this.fridayToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.fridayToolStripMenuItem.Text = "Friday";
            this.fridayToolStripMenuItem.Click += new System.EventHandler(this.fridayToolStripMenuItem_Click);
            // 
            // saturdayToolStripMenuItem
            // 
            this.saturdayToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saturdayToolStripMenuItem.Name = "saturdayToolStripMenuItem";
            this.saturdayToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.saturdayToolStripMenuItem.Text = "Saturday";
            this.saturdayToolStripMenuItem.Click += new System.EventHandler(this.saturdayToolStripMenuItem_Click);
            // 
            // sundayToolStripMenuItem
            // 
            this.sundayToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sundayToolStripMenuItem.Name = "sundayToolStripMenuItem";
            this.sundayToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.sundayToolStripMenuItem.Text = "Sunday";
            this.sundayToolStripMenuItem.Click += new System.EventHandler(this.sundayToolStripMenuItem_Click);
            // 
            // lDay
            // 
            this.lDay.AutoSize = true;
            this.lDay.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            this.lDay.Location = new System.Drawing.Point(143, 392);
            this.lDay.Name = "lDay";
            this.lDay.Size = new System.Drawing.Size(103, 32);
            this.lDay.TabIndex = 12;
            this.lDay.Text = "Monday";
            // 
            // ScSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(765, 450);
            this.Controls.Add(this.lDay);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.pbAddClass);
            this.Controls.Add(this.pbEditClass);
            this.Controls.Add(this.pbDeleteClass);
            this.Controls.Add(this.dgvSchedule);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ScSchedule";
            this.Text = "ScSchedule";
            this.Load += new System.EventHandler(this.ScSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteClass)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.PictureBox pbAddClass;
        private System.Windows.Forms.PictureBox pbEditClass;
        private System.Windows.Forms.PictureBox pbDeleteClass;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mondayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tuesdayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wedensdayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thursdayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fridayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saturdayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sundayToolStripMenuItem;
        private System.Windows.Forms.Label lDay;
    }
}