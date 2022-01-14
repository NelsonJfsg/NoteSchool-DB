
namespace NoteSchool.Layout.Homework
{
    partial class ScHomework
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScHomework));
            this.lTitle = new System.Windows.Forms.Label();
            this.dgvHomework = new System.Windows.Forms.DataGridView();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.pbAddSubject = new System.Windows.Forms.PictureBox();
            this.pbEditSubject = new System.Windows.Forms.PictureBox();
            this.pbDeleteSubject = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomework)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            this.lTitle.Location = new System.Drawing.Point(25, 385);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(169, 40);
            this.lTitle.TabIndex = 11;
            this.lTitle.Text = "Homework";
            // 
            // dgvHomework
            // 
            this.dgvHomework.AllowUserToResizeColumns = false;
            this.dgvHomework.AllowUserToResizeRows = false;
            this.dgvHomework.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
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
            this.dgvHomework.Location = new System.Drawing.Point(12, 41);
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
            this.dgvHomework.Size = new System.Drawing.Size(741, 328);
            this.dgvHomework.TabIndex = 13;
            // 
            // cbSubject
            // 
            this.cbSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSubject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSubject.ForeColor = System.Drawing.Color.White;
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(632, 7);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(121, 29);
            this.cbSubject.TabIndex = 14;
            this.cbSubject.SelectedIndexChanged += new System.EventHandler(this.cbSubject_SelectedIndexChanged);
            this.cbSubject.Click += new System.EventHandler(this.cbSubject_Click);
            // 
            // pbAddSubject
            // 
            this.pbAddSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddSubject.Image = global::NoteSchool.Properties.Resources.Add_Mark;
            this.pbAddSubject.Location = new System.Drawing.Point(566, 375);
            this.pbAddSubject.Name = "pbAddSubject";
            this.pbAddSubject.Size = new System.Drawing.Size(53, 50);
            this.pbAddSubject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddSubject.TabIndex = 10;
            this.pbAddSubject.TabStop = false;
            this.pbAddSubject.Click += new System.EventHandler(this.pbAddSubject_Click);
            // 
            // pbEditSubject
            // 
            this.pbEditSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEditSubject.Image = global::NoteSchool.Properties.Resources.Edir_Half_Line;
            this.pbEditSubject.Location = new System.Drawing.Point(636, 375);
            this.pbEditSubject.Name = "pbEditSubject";
            this.pbEditSubject.Size = new System.Drawing.Size(51, 50);
            this.pbEditSubject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditSubject.TabIndex = 9;
            this.pbEditSubject.TabStop = false;
            this.pbEditSubject.Click += new System.EventHandler(this.pbEditSubject_Click);
            // 
            // pbDeleteSubject
            // 
            this.pbDeleteSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDeleteSubject.Image = global::NoteSchool.Properties.Resources.Delete;
            this.pbDeleteSubject.Location = new System.Drawing.Point(703, 375);
            this.pbDeleteSubject.Name = "pbDeleteSubject";
            this.pbDeleteSubject.Size = new System.Drawing.Size(50, 50);
            this.pbDeleteSubject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDeleteSubject.TabIndex = 8;
            this.pbDeleteSubject.TabStop = false;
            this.pbDeleteSubject.Click += new System.EventHandler(this.pbDeleteSubject_Click);
            // 
            // ScHomework
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(765, 450);
            this.Controls.Add(this.cbSubject);
            this.Controls.Add(this.dgvHomework);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.pbAddSubject);
            this.Controls.Add(this.pbEditSubject);
            this.Controls.Add(this.pbDeleteSubject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScHomework";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScHomework";
            this.Load += new System.EventHandler(this.ScHomework_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomework)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.PictureBox pbAddSubject;
        private System.Windows.Forms.PictureBox pbEditSubject;
        private System.Windows.Forms.PictureBox pbDeleteSubject;
        private System.Windows.Forms.DataGridView dgvHomework;
        private System.Windows.Forms.ComboBox cbSubject;
    }
}