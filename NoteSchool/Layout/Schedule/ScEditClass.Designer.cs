
namespace NoteSchool.Layout.Schedule
{
    partial class ScEditClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScEditClass));
            this.lHomework = new System.Windows.Forms.Label();
            this.butDone = new System.Windows.Forms.Button();
            this.tbEndtime = new System.Windows.Forms.TextBox();
            this.tbStarttime = new System.Windows.Forms.TextBox();
            this.tbLink = new System.Windows.Forms.TextBox();
            this.cbClassname = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lHomework
            // 
            this.lHomework.AutoSize = true;
            this.lHomework.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHomework.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            this.lHomework.Location = new System.Drawing.Point(98, 21);
            this.lHomework.Name = "lHomework";
            this.lHomework.Size = new System.Drawing.Size(141, 40);
            this.lHomework.TabIndex = 0;
            this.lHomework.Text = "Edit class";
            this.lHomework.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.lHomework_PreviewKeyDown);
            // 
            // butDone
            // 
            this.butDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(106)))), ((int)(((byte)(97)))));
            this.butDone.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.butDone.ForeColor = System.Drawing.Color.White;
            this.butDone.Location = new System.Drawing.Point(71, 409);
            this.butDone.Name = "butDone";
            this.butDone.Size = new System.Drawing.Size(192, 37);
            this.butDone.TabIndex = 5;
            this.butDone.Text = "Done";
            this.butDone.UseVisualStyleBackColor = false;
            this.butDone.Click += new System.EventHandler(this.butDone_Click);
            // 
            // tbEndtime
            // 
            this.tbEndtime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.tbEndtime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEndtime.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEndtime.ForeColor = System.Drawing.Color.DarkGray;
            this.tbEndtime.Location = new System.Drawing.Point(37, 294);
            this.tbEndtime.Name = "tbEndtime";
            this.tbEndtime.Size = new System.Drawing.Size(257, 27);
            this.tbEndtime.TabIndex = 3;
            this.tbEndtime.Text = "Class end time";
            this.tbEndtime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbEndtime.Click += new System.EventHandler(this.tbEndtime_Click);
            this.tbEndtime.Leave += new System.EventHandler(this.tbEndtime_Leave);
            this.tbEndtime.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tbEndtime_PreviewKeyDown);
            // 
            // tbStarttime
            // 
            this.tbStarttime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.tbStarttime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbStarttime.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStarttime.ForeColor = System.Drawing.Color.DarkGray;
            this.tbStarttime.Location = new System.Drawing.Point(37, 250);
            this.tbStarttime.Name = "tbStarttime";
            this.tbStarttime.Size = new System.Drawing.Size(257, 27);
            this.tbStarttime.TabIndex = 2;
            this.tbStarttime.Text = "Class start time";
            this.tbStarttime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbStarttime.Click += new System.EventHandler(this.tbStarttime_Click);
            this.tbStarttime.Leave += new System.EventHandler(this.tbStarttime_Leave);
            this.tbStarttime.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tbStarttime_PreviewKeyDown);
            // 
            // tbLink
            // 
            this.tbLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.tbLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLink.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLink.ForeColor = System.Drawing.Color.DarkGray;
            this.tbLink.Location = new System.Drawing.Point(37, 343);
            this.tbLink.Name = "tbLink";
            this.tbLink.Size = new System.Drawing.Size(257, 27);
            this.tbLink.TabIndex = 4;
            this.tbLink.Text = "Class link";
            this.tbLink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbLink.Click += new System.EventHandler(this.tbLink_Click);
            this.tbLink.Leave += new System.EventHandler(this.tbLink_Leave);
            // 
            // cbClassname
            // 
            this.cbClassname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.cbClassname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClassname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbClassname.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cbClassname.ForeColor = System.Drawing.Color.White;
            this.cbClassname.FormattingEnabled = true;
            this.cbClassname.Location = new System.Drawing.Point(37, 77);
            this.cbClassname.Name = "cbClassname";
            this.cbClassname.Size = new System.Drawing.Size(257, 28);
            this.cbClassname.TabIndex = 1;
            this.cbClassname.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cbClassname_PreviewKeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NoteSchool.Properties.Resources.Edir_Half_Line;
            this.pictureBox1.Location = new System.Drawing.Point(105, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ScEditClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(332, 481);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butDone);
            this.Controls.Add(this.tbEndtime);
            this.Controls.Add(this.tbStarttime);
            this.Controls.Add(this.tbLink);
            this.Controls.Add(this.cbClassname);
            this.Controls.Add(this.lHomework);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScEditClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteSchool - Edit class";
            this.Load += new System.EventHandler(this.ScEditClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lHomework;
        private System.Windows.Forms.Button butDone;
        private System.Windows.Forms.TextBox tbEndtime;
        private System.Windows.Forms.TextBox tbStarttime;
        private System.Windows.Forms.TextBox tbLink;
        private System.Windows.Forms.ComboBox cbClassname;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}