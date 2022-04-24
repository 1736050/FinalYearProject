namespace FinalYearProject
{
    partial class Teacherform
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.Softwarenamelb = new System.Windows.Forms.Label();
            this.AdminFormlobtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panelnav = new System.Windows.Forms.Panel();
            this.Teacherattendencedashbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AdminFormlb = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel3.Controls.Add(this.Softwarenamelb);
            this.panel3.Controls.Add(this.AdminFormlobtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(186, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(765, 56);
            this.panel3.TabIndex = 18;
            // 
            // Softwarenamelb
            // 
            this.Softwarenamelb.AutoSize = true;
            this.Softwarenamelb.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Softwarenamelb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Softwarenamelb.Location = new System.Drawing.Point(3, 30);
            this.Softwarenamelb.Name = "Softwarenamelb";
            this.Softwarenamelb.Size = new System.Drawing.Size(400, 21);
            this.Softwarenamelb.TabIndex = 15;
            this.Softwarenamelb.Text = "College Management and Face Recognition System";
            // 
            // AdminFormlobtn
            // 
            this.AdminFormlobtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.AdminFormlobtn.FlatAppearance.BorderSize = 0;
            this.AdminFormlobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminFormlobtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.AdminFormlobtn.Location = new System.Drawing.Point(713, 30);
            this.AdminFormlobtn.Name = "AdminFormlobtn";
            this.AdminFormlobtn.Size = new System.Drawing.Size(49, 23);
            this.AdminFormlobtn.TabIndex = 14;
            this.AdminFormlobtn.Text = "Logout";
            this.AdminFormlobtn.UseVisualStyleBackColor = false;
            this.AdminFormlobtn.Click += new System.EventHandler(this.AdminFormlobtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.Panelnav);
            this.panel1.Controls.Add(this.Teacherattendencedashbtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 17;
            // 
            // Panelnav
            // 
            this.Panelnav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Panelnav.Location = new System.Drawing.Point(0, 130);
            this.Panelnav.Name = "Panelnav";
            this.Panelnav.Size = new System.Drawing.Size(3, 50);
            this.Panelnav.TabIndex = 0;
            // 
            // Teacherattendencedashbtn
            // 
            this.Teacherattendencedashbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Teacherattendencedashbtn.FlatAppearance.BorderSize = 0;
            this.Teacherattendencedashbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Teacherattendencedashbtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacherattendencedashbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Teacherattendencedashbtn.Location = new System.Drawing.Point(0, 118);
            this.Teacherattendencedashbtn.Name = "Teacherattendencedashbtn";
            this.Teacherattendencedashbtn.Size = new System.Drawing.Size(186, 42);
            this.Teacherattendencedashbtn.TabIndex = 1;
            this.Teacherattendencedashbtn.Text = "Student Attendence";
            this.Teacherattendencedashbtn.UseVisualStyleBackColor = true;
            this.Teacherattendencedashbtn.Click += new System.EventHandler(this.Teacherattendencedashbtn_Click);
            this.Teacherattendencedashbtn.Leave += new System.EventHandler(this.Teacherattendencedashbtn_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.AdminFormlb);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 118);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalYearProject.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AdminFormlb
            // 
            this.AdminFormlb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminFormlb.AutoSize = true;
            this.AdminFormlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminFormlb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.AdminFormlb.Location = new System.Drawing.Point(46, 88);
            this.AdminFormlb.Name = "AdminFormlb";
            this.AdminFormlb.Size = new System.Drawing.Size(102, 13);
            this.AdminFormlb.TabIndex = 12;
            this.AdminFormlb.Text = "User Type: Teacher";
            this.AdminFormlb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Teacherform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Teacherform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacherform";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Softwarenamelb;
        private System.Windows.Forms.Button AdminFormlobtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Panelnav;
        private System.Windows.Forms.Button Teacherattendencedashbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AdminFormlb;
    }
}