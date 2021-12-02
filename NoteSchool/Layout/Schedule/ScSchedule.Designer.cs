
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
            this.dgvSubject = new System.Windows.Forms.DataGridView();
            this.butCreateSubject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSubject
            // 
            this.dgvSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubject.Location = new System.Drawing.Point(12, 40);
            this.dgvSubject.Name = "dgvSubject";
            this.dgvSubject.Size = new System.Drawing.Size(776, 234);
            this.dgvSubject.TabIndex = 0;
            // 
            // butCreateSubject
            // 
            this.butCreateSubject.Location = new System.Drawing.Point(573, 310);
            this.butCreateSubject.Name = "butCreateSubject";
            this.butCreateSubject.Size = new System.Drawing.Size(75, 23);
            this.butCreateSubject.TabIndex = 1;
            this.butCreateSubject.Text = "button1";
            this.butCreateSubject.UseVisualStyleBackColor = true;
            this.butCreateSubject.Click += new System.EventHandler(this.butCreateSubject_Click);
            // 
            // ScSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butCreateSubject);
            this.Controls.Add(this.dgvSubject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScSchedule";
            this.Text = "ScSchedule";
            this.Load += new System.EventHandler(this.ScSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubject;
        private System.Windows.Forms.Button butCreateSubject;
    }
}