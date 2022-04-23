namespace FinalYearProject
{
    partial class Studentform
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
            this.StudentFormlo = new System.Windows.Forms.Button();
            this.CloseWindowbt2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SoftwareName
            // 
            this.SoftwareName.AutoSize = true;
            this.SoftwareName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoftwareName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SoftwareName.Location = new System.Drawing.Point(91, 33);
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
            this.StudentFormlb.Location = new System.Drawing.Point(364, 86);
            this.StudentFormlb.Name = "StudentFormlb";
            this.StudentFormlb.Size = new System.Drawing.Size(187, 25);
            this.StudentFormlb.TabIndex = 2;
            this.StudentFormlb.Text = "User Type: Student ";
            this.StudentFormlb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentFormlo
            // 
            this.StudentFormlo.Location = new System.Drawing.Point(789, 516);
            this.StudentFormlo.Name = "StudentFormlo";
            this.StudentFormlo.Size = new System.Drawing.Size(75, 23);
            this.StudentFormlo.TabIndex = 3;
            this.StudentFormlo.Text = "Logout";
            this.StudentFormlo.UseVisualStyleBackColor = true;
            this.StudentFormlo.Click += new System.EventHandler(this.StudentFormlo_Click);
            // 
            // CloseWindowbt2
            // 
            this.CloseWindowbt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CloseWindowbt2.ForeColor = System.Drawing.Color.Red;
            this.CloseWindowbt2.Location = new System.Drawing.Point(913, 12);
            this.CloseWindowbt2.Name = "CloseWindowbt2";
            this.CloseWindowbt2.Size = new System.Drawing.Size(26, 23);
            this.CloseWindowbt2.TabIndex = 4;
            this.CloseWindowbt2.Text = "X";
            this.CloseWindowbt2.UseVisualStyleBackColor = false;
            this.CloseWindowbt2.Click += new System.EventHandler(this.CloseWindowbt2_Click);
            // 
            // Studentform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.CloseWindowbt2);
            this.Controls.Add(this.StudentFormlo);
            this.Controls.Add(this.StudentFormlb);
            this.Controls.Add(this.SoftwareName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Studentform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studentform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SoftwareName;
        private System.Windows.Forms.Label StudentFormlb;
        private System.Windows.Forms.Button StudentFormlo;
        private System.Windows.Forms.Button CloseWindowbt2;
    }
}