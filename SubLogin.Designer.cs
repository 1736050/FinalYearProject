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
            this.SoftwareName = new System.Windows.Forms.Label();
            this.DeveloperName = new System.Windows.Forms.Label();
            this.SubUserTypelb = new System.Windows.Forms.Label();
            this.SubUsertypeCb = new System.Windows.Forms.ComboBox();
            this.SubLoginbt = new System.Windows.Forms.Button();
            this.closebt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SoftwareName
            // 
            this.SoftwareName.AutoSize = true;
            this.SoftwareName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoftwareName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SoftwareName.Location = new System.Drawing.Point(94, 34);
            this.SoftwareName.Name = "SoftwareName";
            this.SoftwareName.Size = new System.Drawing.Size(773, 31);
            this.SoftwareName.TabIndex = 0;
            this.SoftwareName.Text = "College Management and Face recognition Attendence System";
            // 
            // DeveloperName
            // 
            this.DeveloperName.AutoSize = true;
            this.DeveloperName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeveloperName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeveloperName.Location = new System.Drawing.Point(593, 515);
            this.DeveloperName.Name = "DeveloperName";
            this.DeveloperName.Size = new System.Drawing.Size(260, 25);
            this.DeveloperName.TabIndex = 1;
            this.DeveloperName.Text = "By Muhammad Hamza Farid";
            // 
            // SubUserTypelb
            // 
            this.SubUserTypelb.AutoSize = true;
            this.SubUserTypelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubUserTypelb.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.SubUserTypelb.Location = new System.Drawing.Point(311, 289);
            this.SubUserTypelb.Name = "SubUserTypelb";
            this.SubUserTypelb.Size = new System.Drawing.Size(70, 17);
            this.SubUserTypelb.TabIndex = 4;
            this.SubUserTypelb.Text = "UserType";
            // 
            // SubUsertypeCb
            // 
            this.SubUsertypeCb.FormattingEnabled = true;
            this.SubUsertypeCb.Items.AddRange(new object[] {
            "Student",
            "Teacher",
            "Admin"});
            this.SubUsertypeCb.Location = new System.Drawing.Point(431, 289);
            this.SubUsertypeCb.Name = "SubUsertypeCb";
            this.SubUsertypeCb.Size = new System.Drawing.Size(159, 21);
            this.SubUsertypeCb.TabIndex = 7;
            this.SubUsertypeCb.Tag = "";
            // 
            // SubLoginbt
            // 
            this.SubLoginbt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SubLoginbt.Location = new System.Drawing.Point(515, 369);
            this.SubLoginbt.Name = "SubLoginbt";
            this.SubLoginbt.Size = new System.Drawing.Size(75, 23);
            this.SubLoginbt.TabIndex = 8;
            this.SubLoginbt.Text = "Login";
            this.SubLoginbt.UseVisualStyleBackColor = true;
            this.SubLoginbt.Click += new System.EventHandler(this.SubLoginbt_Click);
            // 
            // closebt
            // 
            this.closebt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.closebt.ForeColor = System.Drawing.Color.Red;
            this.closebt.Location = new System.Drawing.Point(913, 12);
            this.closebt.Name = "closebt";
            this.closebt.Size = new System.Drawing.Size(26, 23);
            this.closebt.TabIndex = 9;
            this.closebt.Text = "X";
            this.closebt.UseVisualStyleBackColor = false;
            this.closebt.Click += new System.EventHandler(this.CloseWindowBt_Click);
            // 
            // SubLogin
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.closebt);
            this.Controls.Add(this.SubLoginbt);
            this.Controls.Add(this.SubUsertypeCb);
            this.Controls.Add(this.SubUserTypelb);
            this.Controls.Add(this.DeveloperName);
            this.Controls.Add(this.SoftwareName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SubLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CloseWindowBt_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion


        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SoftwareName;
        private System.Windows.Forms.Label DeveloperName;
        private System.Windows.Forms.Label SubUserTypelb;
        private System.Windows.Forms.ComboBox SubUsertypeCb;
        private System.Windows.Forms.Button SubLoginbt;
        private System.Windows.Forms.Button closebt;
    }
}

