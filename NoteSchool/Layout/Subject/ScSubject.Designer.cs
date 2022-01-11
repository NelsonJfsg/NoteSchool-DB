
namespace NoteSchool.Layout.Subject
{
    partial class ScSubject
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHomework = new System.Windows.Forms.DataGridView();
            this.pbAddHomework = new System.Windows.Forms.PictureBox();
            this.pbEditHomework = new System.Windows.Forms.PictureBox();
            this.pbDeleteHomework = new System.Windows.Forms.PictureBox();
            this.lTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomework)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddHomework)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditHomework)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteHomework)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHomework
            // 
            this.dgvHomework.AllowUserToResizeColumns = false;
            this.dgvHomework.AllowUserToResizeRows = false;
            this.dgvHomework.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvHomework.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHomework.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHomework.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHomework.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHomework.Location = new System.Drawing.Point(12, 12);
            this.dgvHomework.MultiSelect = false;
            this.dgvHomework.Name = "dgvHomework";
            this.dgvHomework.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHomework.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHomework.RowHeadersVisible = false;
            this.dgvHomework.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHomework.Size = new System.Drawing.Size(741, 367);
            this.dgvHomework.TabIndex = 0;
            // 
            // pbAddHomework
            // 
            this.pbAddHomework.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddHomework.Image = global::NoteSchool.Properties.Resources.homework;
            this.pbAddHomework.Location = new System.Drawing.Point(568, 385);
            this.pbAddHomework.Name = "pbAddHomework";
            this.pbAddHomework.Size = new System.Drawing.Size(53, 50);
            this.pbAddHomework.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddHomework.TabIndex = 3;
            this.pbAddHomework.TabStop = false;
            this.pbAddHomework.Click += new System.EventHandler(this.pbAddSubject_Click);
            // 
            // pbEditHomework
            // 
            this.pbEditHomework.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEditHomework.Image = global::NoteSchool.Properties.Resources.Edit;
            this.pbEditHomework.Location = new System.Drawing.Point(638, 385);
            this.pbEditHomework.Name = "pbEditHomework";
            this.pbEditHomework.Size = new System.Drawing.Size(51, 50);
            this.pbEditHomework.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditHomework.TabIndex = 2;
            this.pbEditHomework.TabStop = false;
            this.pbEditHomework.Click += new System.EventHandler(this.pbEditSubject_Click);
            // 
            // pbDeleteHomework
            // 
            this.pbDeleteHomework.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDeleteHomework.Image = global::NoteSchool.Properties.Resources.Delete;
            this.pbDeleteHomework.Location = new System.Drawing.Point(705, 385);
            this.pbDeleteHomework.Name = "pbDeleteHomework";
            this.pbDeleteHomework.Size = new System.Drawing.Size(50, 50);
            this.pbDeleteHomework.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDeleteHomework.TabIndex = 1;
            this.pbDeleteHomework.TabStop = false;
            this.pbDeleteHomework.Click += new System.EventHandler(this.pbDeleteSubject_Click);
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            this.lTitle.Location = new System.Drawing.Point(5, 395);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(140, 40);
            this.lTitle.TabIndex = 6;
            this.lTitle.Text = "Subject´s";
            // 
            // ScSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(765, 450);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.pbAddHomework);
            this.Controls.Add(this.pbEditHomework);
            this.Controls.Add(this.pbDeleteHomework);
            this.Controls.Add(this.dgvHomework);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScSubject";
            this.Text = "ScSubject";
            this.Load += new System.EventHandler(this.ScSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomework)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddHomework)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditHomework)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteHomework)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHomework;
        private System.Windows.Forms.PictureBox pbDeleteHomework;
        private System.Windows.Forms.PictureBox pbEditHomework;
        private System.Windows.Forms.PictureBox pbAddHomework;
        private System.Windows.Forms.Label lTitle;
    }
}