namespace FinalYearProject
{
    partial class TrainStudentImagesForm
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
            this.Piccap = new System.Windows.Forms.PictureBox();
            this.Cpbtn = new System.Windows.Forms.Button();
            this.Dtfacbtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Piccap)).BeginInit();
            this.SuspendLayout();
            // 
            // Piccap
            // 
            this.Piccap.Location = new System.Drawing.Point(0, 0);
            this.Piccap.Name = "Piccap";
            this.Piccap.Size = new System.Drawing.Size(453, 288);
            this.Piccap.TabIndex = 0;
            this.Piccap.TabStop = false;
            // 
            // Cpbtn
            // 
            this.Cpbtn.Location = new System.Drawing.Point(12, 306);
            this.Cpbtn.Name = "Cpbtn";
            this.Cpbtn.Size = new System.Drawing.Size(75, 23);
            this.Cpbtn.TabIndex = 1;
            this.Cpbtn.Text = "Capture";
            this.Cpbtn.UseVisualStyleBackColor = true;
            this.Cpbtn.Click += new System.EventHandler(this.Cpbtn_Click);
            // 
            // Dtfacbtn
            // 
            this.Dtfacbtn.Location = new System.Drawing.Point(109, 306);
            this.Dtfacbtn.Name = "Dtfacbtn";
            this.Dtfacbtn.Size = new System.Drawing.Size(75, 23);
            this.Dtfacbtn.TabIndex = 2;
            this.Dtfacbtn.Text = " Detect Face";
            this.Dtfacbtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(202, 306);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // TrainStudentImagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(749, 482);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Dtfacbtn);
            this.Controls.Add(this.Cpbtn);
            this.Controls.Add(this.Piccap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrainStudentImagesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrainStudenImagesForm";
            ((System.ComponentModel.ISupportInitialize)(this.Piccap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Piccap;
        private System.Windows.Forms.Button Cpbtn;
        private System.Windows.Forms.Button Dtfacbtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}