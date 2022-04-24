using System;

namespace FinalYearProject
{
    partial class SubLogin
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
            this.DeveloperName = new System.Windows.Forms.Label();
            this.SubUserTypelb = new System.Windows.Forms.Label();
            this.SubUsertypeCb = new System.Windows.Forms.ComboBox();
            this.SubLoginbt = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Softwarenamelb = new System.Windows.Forms.Label();
            this.Closewindowbt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DeveloperName
            // 
            this.DeveloperName.AutoSize = true;
            this.DeveloperName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.DeveloperName.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeveloperName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.DeveloperName.Location = new System.Drawing.Point(59, 49);
            this.DeveloperName.Name = "DeveloperName";
            this.DeveloperName.Size = new System.Drawing.Size(172, 17);
            this.DeveloperName.TabIndex = 1;
            this.DeveloperName.Text = "By Muhammad Hamza Farid";
            // 
            // SubUserTypelb
            // 
            this.SubUserTypelb.AutoSize = true;
            this.SubUserTypelb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.SubUserTypelb.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubUserTypelb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.SubUserTypelb.Location = new System.Drawing.Point(332, 254);
            this.SubUserTypelb.Name = "SubUserTypelb";
            this.SubUserTypelb.Size = new System.Drawing.Size(71, 19);
            this.SubUserTypelb.TabIndex = 4;
            this.SubUserTypelb.Text = "UserType";
            // 
            // SubUsertypeCb
            // 
            this.SubUsertypeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubUsertypeCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.SubUsertypeCb.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SubUsertypeCb.FormattingEnabled = true;
            this.SubUsertypeCb.Items.AddRange(new object[] {
            "Student",
            "Teacher",
            "Admin"});
            this.SubUsertypeCb.Location = new System.Drawing.Point(426, 256);
            this.SubUsertypeCb.Name = "SubUsertypeCb";
            this.SubUsertypeCb.Size = new System.Drawing.Size(159, 23);
            this.SubUsertypeCb.TabIndex = 7;
            this.SubUsertypeCb.Tag = "";
            // 
            // SubLoginbt
            // 
            this.SubLoginbt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SubLoginbt.Location = new System.Drawing.Point(426, 326);
            this.SubLoginbt.Name = "SubLoginbt";
            this.SubLoginbt.Size = new System.Drawing.Size(75, 23);
            this.SubLoginbt.TabIndex = 8;
            this.SubLoginbt.Text = "Login";
            this.SubLoginbt.UseVisualStyleBackColor = true;
            this.SubLoginbt.Click += new System.EventHandler(this.SubLoginbt_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.Softwarenamelb);
            this.panel3.Controls.Add(this.Closewindowbt);
            this.panel3.Controls.Add(this.DeveloperName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(951, 78);
            this.panel3.TabIndex = 17;
            // 
            // Softwarenamelb
            // 
            this.Softwarenamelb.AutoSize = true;
            this.Softwarenamelb.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Softwarenamelb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Softwarenamelb.Location = new System.Drawing.Point(59, 28);
            this.Softwarenamelb.Name = "Softwarenamelb";
            this.Softwarenamelb.Size = new System.Drawing.Size(400, 21);
            this.Softwarenamelb.TabIndex = 15;
            this.Softwarenamelb.Text = "College Management and Face Recognition System";
            // 
            // Closewindowbt
            // 
            this.Closewindowbt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Closewindowbt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Closewindowbt.FlatAppearance.BorderSize = 0;
            this.Closewindowbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closewindowbt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Closewindowbt.Location = new System.Drawing.Point(922, 3);
            this.Closewindowbt.Name = "Closewindowbt";
            this.Closewindowbt.Size = new System.Drawing.Size(26, 23);
            this.Closewindowbt.TabIndex = 13;
            this.Closewindowbt.Text = "X";
            this.Closewindowbt.UseVisualStyleBackColor = false;
            this.Closewindowbt.Click += new System.EventHandler(this.Closewindowbt_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::FinalYearProject.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // SubLogin
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.SubLoginbt);
            this.Controls.Add(this.SubUsertypeCb);
            this.Controls.Add(this.SubUserTypelb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SubLogin_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CloseWindowBt_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion


        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DeveloperName;
        private System.Windows.Forms.Label SubUserTypelb;
        private System.Windows.Forms.ComboBox SubUsertypeCb;
        private System.Windows.Forms.Button SubLoginbt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Softwarenamelb;
        private System.Windows.Forms.Button Closewindowbt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

