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
            this.SoftwareName = new System.Windows.Forms.Label();
            this.StudentFormlb = new System.Windows.Forms.Label();
            this.closebt = new System.Windows.Forms.Button();
            this.TeacherFormlo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SoftwareName
            // 
            this.SoftwareName.AutoSize = true;
            this.SoftwareName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoftwareName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SoftwareName.Location = new System.Drawing.Point(94, 35);
            this.SoftwareName.Name = "SoftwareName";
            this.SoftwareName.Size = new System.Drawing.Size(773, 31);
            this.SoftwareName.TabIndex = 1;
            this.SoftwareName.Text = "College Management and Face recognition Attendence System";
            // 
            // StudentFormlb
            // 
            this.StudentFormlb.AutoSize = true;
            this.StudentFormlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentFormlb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StudentFormlb.Location = new System.Drawing.Point(366, 91);
            this.StudentFormlb.Name = "StudentFormlb";
            this.StudentFormlb.Size = new System.Drawing.Size(192, 25);
            this.StudentFormlb.TabIndex = 3;
            this.StudentFormlb.Text = "User Type: Teacher ";
            this.StudentFormlb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closebt
            // 
            this.closebt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.closebt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closebt.ForeColor = System.Drawing.Color.Red;
            this.closebt.Location = new System.Drawing.Point(913, 12);
            this.closebt.Name = "closebt";
            this.closebt.Size = new System.Drawing.Size(26, 23);
            this.closebt.TabIndex = 10;
            this.closebt.Text = "X";
            this.closebt.UseVisualStyleBackColor = false;
            this.closebt.Click += new System.EventHandler(this.closebt_Click);
            // 
            // TeacherFormlo
            // 
            this.TeacherFormlo.Location = new System.Drawing.Point(864, 542);
            this.TeacherFormlo.Name = "TeacherFormlo";
            this.TeacherFormlo.Size = new System.Drawing.Size(75, 23);
            this.TeacherFormlo.TabIndex = 15;
            this.TeacherFormlo.Text = "Logout";
            this.TeacherFormlo.UseVisualStyleBackColor = true;
            this.TeacherFormlo.Click += new System.EventHandler(this.TeacherFormlo_Click);
            // 
            // Teacherform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.TeacherFormlo);
            this.Controls.Add(this.closebt);
            this.Controls.Add(this.StudentFormlb);
            this.Controls.Add(this.SoftwareName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Teacherform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacherform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SoftwareName;
        private System.Windows.Forms.Label StudentFormlb;
        private System.Windows.Forms.Button closebt;
        private System.Windows.Forms.Button TeacherFormlo;
    }
}