namespace FinalYearProject
{
    partial class Adminform
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
            this.closebt = new System.Windows.Forms.Button();
            this.StudentFormlb = new System.Windows.Forms.Label();
            this.AdminFormlo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closebt
            // 
            this.closebt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.closebt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closebt.ForeColor = System.Drawing.Color.Red;
            this.closebt.Location = new System.Drawing.Point(913, 12);
            this.closebt.Name = "closebt";
            this.closebt.Size = new System.Drawing.Size(26, 23);
            this.closebt.TabIndex = 13;
            this.closebt.Text = "X";
            this.closebt.UseVisualStyleBackColor = false;
            this.closebt.Click += new System.EventHandler(this.closebt_Click);
            // 
            // StudentFormlb
            // 
            this.StudentFormlb.AutoSize = true;
            this.StudentFormlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentFormlb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StudentFormlb.Location = new System.Drawing.Point(390, 12);
            this.StudentFormlb.Name = "StudentFormlb";
            this.StudentFormlb.Size = new System.Drawing.Size(170, 25);
            this.StudentFormlb.TabIndex = 12;
            this.StudentFormlb.Text = "User Type: Admin";
            this.StudentFormlb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StudentFormlb.Click += new System.EventHandler(this.StudentFormlb_Click);
            // 
            // AdminFormlo
            // 
            this.AdminFormlo.Location = new System.Drawing.Point(864, 542);
            this.AdminFormlo.Name = "AdminFormlo";
            this.AdminFormlo.Size = new System.Drawing.Size(75, 23);
            this.AdminFormlo.TabIndex = 14;
            this.AdminFormlo.Text = "Logout";
            this.AdminFormlo.UseVisualStyleBackColor = true;
            this.AdminFormlo.Click += new System.EventHandler(this.StudentFormlo_Click);
            // 
            // Adminform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.AdminFormlo);
            this.Controls.Add(this.closebt);
            this.Controls.Add(this.StudentFormlb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Adminform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adminform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closebt;
        private System.Windows.Forms.Label StudentFormlb;
        private System.Windows.Forms.Button AdminFormlo;
    }
}