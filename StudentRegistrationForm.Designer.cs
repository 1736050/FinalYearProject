namespace FinalYearProject
{
    partial class StudentRegistrationForm
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
            this.Fntxt = new System.Windows.Forms.TextBox();
            this.Stfnlb = new System.Windows.Forms.Label();
            this.Sntxt = new System.Windows.Forms.TextBox();
            this.Stsnlb = new System.Windows.Forms.Label();
            this.Stdblb = new System.Windows.Forms.Label();
            this.Stglb = new System.Windows.Forms.Label();
            this.Stclb = new System.Windows.Forms.Label();
            this.stimlb = new System.Windows.Forms.Label();
            this.Adtxt = new System.Windows.Forms.TextBox();
            this.stadlb = new System.Windows.Forms.Label();
            this.Pntxt = new System.Windows.Forms.TextBox();
            this.stpnlb = new System.Windows.Forms.Label();
            this.Gntxt = new System.Windows.Forms.ComboBox();
            this.Cotxt = new System.Windows.Forms.ComboBox();
            this.Dbtxt = new System.Windows.Forms.DateTimePicker();
            this.Imbox = new System.Windows.Forms.PictureBox();
            this.StDGV = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Stupdatebtn = new System.Windows.Forms.Button();
            this.StAddbtn = new System.Windows.Forms.Button();
            this.Stremovebtn = new System.Windows.Forms.Button();
            this.Stsearchbtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Sitxt = new System.Windows.Forms.TextBox();
            this.Silb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Imbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Fntxt
            // 
            this.Fntxt.Location = new System.Drawing.Point(119, 69);
            this.Fntxt.Name = "Fntxt";
            this.Fntxt.Size = new System.Drawing.Size(120, 20);
            this.Fntxt.TabIndex = 3;
            // 
            // Stfnlb
            // 
            this.Stfnlb.AutoSize = true;
            this.Stfnlb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Stfnlb.Location = new System.Drawing.Point(34, 72);
            this.Stfnlb.Name = "Stfnlb";
            this.Stfnlb.Size = new System.Drawing.Size(60, 13);
            this.Stfnlb.TabIndex = 2;
            this.Stfnlb.Text = "First Name:";
            // 
            // Sntxt
            // 
            this.Sntxt.Location = new System.Drawing.Point(119, 107);
            this.Sntxt.Name = "Sntxt";
            this.Sntxt.Size = new System.Drawing.Size(120, 20);
            this.Sntxt.TabIndex = 5;
            // 
            // Stsnlb
            // 
            this.Stsnlb.AutoSize = true;
            this.Stsnlb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Stsnlb.Location = new System.Drawing.Point(34, 110);
            this.Stsnlb.Name = "Stsnlb";
            this.Stsnlb.Size = new System.Drawing.Size(52, 13);
            this.Stsnlb.TabIndex = 4;
            this.Stsnlb.Text = "Surname:";
            // 
            // Stdblb
            // 
            this.Stdblb.AutoSize = true;
            this.Stdblb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Stdblb.Location = new System.Drawing.Point(34, 149);
            this.Stdblb.Name = "Stdblb";
            this.Stdblb.Size = new System.Drawing.Size(69, 13);
            this.Stdblb.TabIndex = 6;
            this.Stdblb.Text = "Date of Birth:";
            // 
            // Stglb
            // 
            this.Stglb.AutoSize = true;
            this.Stglb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Stglb.Location = new System.Drawing.Point(34, 188);
            this.Stglb.Name = "Stglb";
            this.Stglb.Size = new System.Drawing.Size(45, 13);
            this.Stglb.TabIndex = 8;
            this.Stglb.Text = "Gender:";
            // 
            // Stclb
            // 
            this.Stclb.AutoSize = true;
            this.Stclb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Stclb.Location = new System.Drawing.Point(34, 227);
            this.Stclb.Name = "Stclb";
            this.Stclb.Size = new System.Drawing.Size(43, 13);
            this.Stclb.TabIndex = 10;
            this.Stclb.Text = "Course:";
            // 
            // stimlb
            // 
            this.stimlb.AutoSize = true;
            this.stimlb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.stimlb.Location = new System.Drawing.Point(291, 35);
            this.stimlb.Name = "stimlb";
            this.stimlb.Size = new System.Drawing.Size(39, 13);
            this.stimlb.TabIndex = 16;
            this.stimlb.Text = "Image:";
            // 
            // Adtxt
            // 
            this.Adtxt.Location = new System.Drawing.Point(119, 301);
            this.Adtxt.Multiline = true;
            this.Adtxt.Name = "Adtxt";
            this.Adtxt.Size = new System.Drawing.Size(120, 71);
            this.Adtxt.TabIndex = 15;
            // 
            // stadlb
            // 
            this.stadlb.AutoSize = true;
            this.stadlb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.stadlb.Location = new System.Drawing.Point(34, 304);
            this.stadlb.Name = "stadlb";
            this.stadlb.Size = new System.Drawing.Size(48, 13);
            this.stadlb.TabIndex = 14;
            this.stadlb.Text = "Address:";
            // 
            // Pntxt
            // 
            this.Pntxt.Location = new System.Drawing.Point(119, 262);
            this.Pntxt.Name = "Pntxt";
            this.Pntxt.Size = new System.Drawing.Size(120, 20);
            this.Pntxt.TabIndex = 13;
            // 
            // stpnlb
            // 
            this.stpnlb.AutoSize = true;
            this.stpnlb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.stpnlb.Location = new System.Drawing.Point(34, 265);
            this.stpnlb.Name = "stpnlb";
            this.stpnlb.Size = new System.Drawing.Size(81, 13);
            this.stpnlb.TabIndex = 12;
            this.stpnlb.Text = "Phone Number:";
            // 
            // Gntxt
            // 
            this.Gntxt.FormattingEnabled = true;
            this.Gntxt.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Nobinary",
            "Others"});
            this.Gntxt.Location = new System.Drawing.Point(119, 188);
            this.Gntxt.Name = "Gntxt";
            this.Gntxt.Size = new System.Drawing.Size(121, 21);
            this.Gntxt.TabIndex = 20;
            // 
            // Cotxt
            // 
            this.Cotxt.FormattingEnabled = true;
            this.Cotxt.Location = new System.Drawing.Point(119, 224);
            this.Cotxt.Name = "Cotxt";
            this.Cotxt.Size = new System.Drawing.Size(121, 21);
            this.Cotxt.TabIndex = 21;
            // 
            // Dbtxt
            // 
            this.Dbtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dbtxt.Location = new System.Drawing.Point(119, 149);
            this.Dbtxt.Name = "Dbtxt";
            this.Dbtxt.Size = new System.Drawing.Size(121, 18);
            this.Dbtxt.TabIndex = 22;
            // 
            // Imbox
            // 
            this.Imbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Imbox.Location = new System.Drawing.Point(367, 35);
            this.Imbox.Name = "Imbox";
            this.Imbox.Size = new System.Drawing.Size(162, 149);
            this.Imbox.TabIndex = 23;
            this.Imbox.TabStop = false;
            // 
            // StDGV
            // 
            this.StDGV.AllowUserToAddRows = false;
            this.StDGV.AllowUserToDeleteRows = false;
            this.StDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StDGV.GridColor = System.Drawing.SystemColors.Control;
            this.StDGV.Location = new System.Drawing.Point(294, 200);
            this.StDGV.Name = "StDGV";
            this.StDGV.ReadOnly = true;
            this.StDGV.RowHeadersWidth = 20;
            this.StDGV.Size = new System.Drawing.Size(459, 250);
            this.StDGV.TabIndex = 15;
            this.StDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StDGV_CellClick);
            // 
            // Stupdatebtn
            // 
            this.Stupdatebtn.Location = new System.Drawing.Point(37, 472);
            this.Stupdatebtn.Name = "Stupdatebtn";
            this.Stupdatebtn.Size = new System.Drawing.Size(75, 23);
            this.Stupdatebtn.TabIndex = 25;
            this.Stupdatebtn.Text = "Update";
            this.Stupdatebtn.UseVisualStyleBackColor = true;
            this.Stupdatebtn.Click += new System.EventHandler(this.Stupdatebtn_Click);
            // 
            // StAddbtn
            // 
            this.StAddbtn.Location = new System.Drawing.Point(37, 427);
            this.StAddbtn.Name = "StAddbtn";
            this.StAddbtn.Size = new System.Drawing.Size(75, 23);
            this.StAddbtn.TabIndex = 26;
            this.StAddbtn.Text = "Add";
            this.StAddbtn.UseVisualStyleBackColor = true;
            this.StAddbtn.Click += new System.EventHandler(this.StAddbtn_Click);
            // 
            // Stremovebtn
            // 
            this.Stremovebtn.Location = new System.Drawing.Point(142, 472);
            this.Stremovebtn.Name = "Stremovebtn";
            this.Stremovebtn.Size = new System.Drawing.Size(75, 23);
            this.Stremovebtn.TabIndex = 27;
            this.Stremovebtn.Text = "Remove";
            this.Stremovebtn.UseVisualStyleBackColor = true;
            this.Stremovebtn.Click += new System.EventHandler(this.Stremovebtn_Click);
            // 
            // Stsearchbtn
            // 
            this.Stsearchbtn.Location = new System.Drawing.Point(142, 427);
            this.Stsearchbtn.Name = "Stsearchbtn";
            this.Stsearchbtn.Size = new System.Drawing.Size(75, 23);
            this.Stsearchbtn.TabIndex = 28;
            this.Stsearchbtn.Text = "Search";
            this.Stsearchbtn.UseVisualStyleBackColor = true;
            this.Stsearchbtn.Click += new System.EventHandler(this.Stsearchbtn_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(545, 161);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 29;
            this.button5.Text = "Browse";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Sitxt
            // 
            this.Sitxt.Enabled = false;
            this.Sitxt.Location = new System.Drawing.Point(120, 32);
            this.Sitxt.Name = "Sitxt";
            this.Sitxt.Size = new System.Drawing.Size(120, 20);
            this.Sitxt.TabIndex = 31;
            // 
            // Silb
            // 
            this.Silb.AutoSize = true;
            this.Silb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Silb.Location = new System.Drawing.Point(35, 35);
            this.Silb.Name = "Silb";
            this.Silb.Size = new System.Drawing.Size(61, 13);
            this.Silb.TabIndex = 30;
            this.Silb.Text = "Student ID:";
            // 
            // StudentRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(765, 521);
            this.Controls.Add(this.Sitxt);
            this.Controls.Add(this.Silb);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Stsearchbtn);
            this.Controls.Add(this.Stremovebtn);
            this.Controls.Add(this.StAddbtn);
            this.Controls.Add(this.Stupdatebtn);
            this.Controls.Add(this.StDGV);
            this.Controls.Add(this.Imbox);
            this.Controls.Add(this.Dbtxt);
            this.Controls.Add(this.Cotxt);
            this.Controls.Add(this.Gntxt);
            this.Controls.Add(this.stimlb);
            this.Controls.Add(this.Adtxt);
            this.Controls.Add(this.stadlb);
            this.Controls.Add(this.Pntxt);
            this.Controls.Add(this.stpnlb);
            this.Controls.Add(this.Stclb);
            this.Controls.Add(this.Stglb);
            this.Controls.Add(this.Stdblb);
            this.Controls.Add(this.Sntxt);
            this.Controls.Add(this.Stsnlb);
            this.Controls.Add(this.Fntxt);
            this.Controls.Add(this.Stfnlb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studentregistrationform";
            this.Load += new System.EventHandler(this.StudentRegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Imbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Fntxt;
        private System.Windows.Forms.Label Stfnlb;
        private System.Windows.Forms.TextBox Sntxt;
        private System.Windows.Forms.Label Stsnlb;
        private System.Windows.Forms.Label Stdblb;
        private System.Windows.Forms.Label Stglb;
        private System.Windows.Forms.Label Stclb;
        private System.Windows.Forms.Label stimlb;
        private System.Windows.Forms.TextBox Adtxt;
        private System.Windows.Forms.Label stadlb;
        private System.Windows.Forms.TextBox Pntxt;
        private System.Windows.Forms.Label stpnlb;
        private System.Windows.Forms.ComboBox Gntxt;
        private System.Windows.Forms.ComboBox Cotxt;
        private System.Windows.Forms.DateTimePicker Dbtxt;
        private System.Windows.Forms.PictureBox Imbox;
        private System.Windows.Forms.DataGridView StDGV;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Stupdatebtn;
        private System.Windows.Forms.Button StAddbtn;
        private System.Windows.Forms.Button Stremovebtn;
        private System.Windows.Forms.Button Stsearchbtn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox Sitxt;
        private System.Windows.Forms.Label Silb;
    }
}