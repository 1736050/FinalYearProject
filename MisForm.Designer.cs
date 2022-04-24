namespace FinalYearProject
{
    partial class MisForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cftxt = new System.Windows.Forms.TextBox();
            this.Cflb = new System.Windows.Forms.Label();
            this.Cntxt = new System.Windows.Forms.TextBox();
            this.Cnlb = new System.Windows.Forms.Label();
            this.Cidtxt = new System.Windows.Forms.TextBox();
            this.Cidlb = new System.Windows.Forms.Label();
            this.Mtxt = new System.Windows.Forms.TextBox();
            this.Mlb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Location = new System.Drawing.Point(356, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 387);
            this.panel1.TabIndex = 0;
            // 
            // Cftxt
            // 
            this.Cftxt.Location = new System.Drawing.Point(131, 198);
            this.Cftxt.Name = "Cftxt";
            this.Cftxt.Size = new System.Drawing.Size(120, 20);
            this.Cftxt.TabIndex = 11;
            // 
            // Cflb
            // 
            this.Cflb.AutoSize = true;
            this.Cflb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Cflb.Location = new System.Drawing.Point(46, 201);
            this.Cflb.Name = "Cflb";
            this.Cflb.Size = new System.Drawing.Size(28, 13);
            this.Cflb.TabIndex = 10;
            this.Cflb.Text = "Fee:";
            // 
            // Cntxt
            // 
            this.Cntxt.Location = new System.Drawing.Point(131, 160);
            this.Cntxt.Name = "Cntxt";
            this.Cntxt.Size = new System.Drawing.Size(120, 20);
            this.Cntxt.TabIndex = 9;
            // 
            // Cnlb
            // 
            this.Cnlb.AutoSize = true;
            this.Cnlb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Cnlb.Location = new System.Drawing.Point(46, 163);
            this.Cnlb.Name = "Cnlb";
            this.Cnlb.Size = new System.Drawing.Size(74, 13);
            this.Cnlb.TabIndex = 8;
            this.Cnlb.Text = "Course Name:";
            // 
            // Cidtxt
            // 
            this.Cidtxt.Location = new System.Drawing.Point(131, 123);
            this.Cidtxt.Name = "Cidtxt";
            this.Cidtxt.Size = new System.Drawing.Size(120, 20);
            this.Cidtxt.TabIndex = 7;
            // 
            // Cidlb
            // 
            this.Cidlb.AutoSize = true;
            this.Cidlb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Cidlb.Location = new System.Drawing.Point(46, 126);
            this.Cidlb.Name = "Cidlb";
            this.Cidlb.Size = new System.Drawing.Size(57, 13);
            this.Cidlb.TabIndex = 6;
            this.Cidlb.Text = "Course ID:";
            // 
            // Mtxt
            // 
            this.Mtxt.Location = new System.Drawing.Point(499, 123);
            this.Mtxt.Name = "Mtxt";
            this.Mtxt.Size = new System.Drawing.Size(120, 20);
            this.Mtxt.TabIndex = 13;
            // 
            // Mlb
            // 
            this.Mlb.AutoSize = true;
            this.Mlb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Mlb.Location = new System.Drawing.Point(414, 126);
            this.Mlb.Name = "Mlb";
            this.Mlb.Size = new System.Drawing.Size(70, 13);
            this.Mlb.TabIndex = 12;
            this.Mlb.Text = "Modul Name:";
            // 
            // MisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(765, 521);
            this.Controls.Add(this.Mtxt);
            this.Controls.Add(this.Mlb);
            this.Controls.Add(this.Cftxt);
            this.Controls.Add(this.Cflb);
            this.Controls.Add(this.Cntxt);
            this.Controls.Add(this.Cnlb);
            this.Controls.Add(this.Cidtxt);
            this.Controls.Add(this.Cidlb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MisForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Cftxt;
        private System.Windows.Forms.Label Cflb;
        private System.Windows.Forms.TextBox Cntxt;
        private System.Windows.Forms.Label Cnlb;
        private System.Windows.Forms.TextBox Cidtxt;
        private System.Windows.Forms.Label Cidlb;
        private System.Windows.Forms.TextBox Mtxt;
        private System.Windows.Forms.Label Mlb;
    }
}