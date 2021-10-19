
namespace NoteSchool.Layout.Home
{
    partial class ScStart
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cbDayList = new System.Windows.Forms.ComboBox();
            this.lHomework = new System.Windows.Forms.Label();
            this.lDay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(763, 160);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(17, 252);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(602, 177);
            this.dataGridView2.TabIndex = 1;
            // 
            // cbDayList
            // 
            this.cbDayList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.cbDayList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbDayList.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDayList.ForeColor = System.Drawing.Color.White;
            this.cbDayList.FormattingEnabled = true;
            this.cbDayList.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Viernes",
            "Sabado",
            "Domingo"});
            this.cbDayList.Location = new System.Drawing.Point(625, 252);
            this.cbDayList.Name = "cbDayList";
            this.cbDayList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbDayList.Size = new System.Drawing.Size(155, 29);
            this.cbDayList.TabIndex = 2;
            this.cbDayList.Text = "Seleccione un dia";
            // 
            // lHomework
            // 
            this.lHomework.AutoSize = true;
            this.lHomework.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHomework.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            this.lHomework.Location = new System.Drawing.Point(10, 3);
            this.lHomework.Name = "lHomework";
            this.lHomework.Size = new System.Drawing.Size(265, 40);
            this.lHomework.TabIndex = 3;
            this.lHomework.Text = "Tareas pendientes";
            // 
            // lDay
            // 
            this.lDay.AutoSize = true;
            this.lDay.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            this.lDay.Location = new System.Drawing.Point(12, 209);
            this.lDay.Name = "lDay";
            this.lDay.Size = new System.Drawing.Size(97, 40);
            this.lDay.TabIndex = 5;
            this.lDay.Text = "Lunes";
            // 
            // ScStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.lDay);
            this.Controls.Add(this.lHomework);
            this.Controls.Add(this.cbDayList);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScStart";
            this.Text = "ScStart";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cbDayList;
        private System.Windows.Forms.Label lHomework;
        private System.Windows.Forms.Label lDay;
    }
}