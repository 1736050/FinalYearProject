namespace FinalYearProject
{
    partial class TeacherRegistrationForm
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
            this.StDGV = new System.Windows.Forms.DataGridView();
            this.Dbtxt = new System.Windows.Forms.DateTimePicker();
            this.Cotxt = new System.Windows.Forms.ComboBox();
            this.Gntxt = new System.Windows.Forms.ComboBox();
            this.Teimlb = new System.Windows.Forms.Label();
            this.Adtxt = new System.Windows.Forms.TextBox();
            this.Teadlb = new System.Windows.Forms.Label();
            this.Pntxt = new System.Windows.Forms.TextBox();
            this.Tepnlb = new System.Windows.Forms.Label();
            this.Teclb = new System.Windows.Forms.Label();
            this.Teglb = new System.Windows.Forms.Label();
            this.Tedblb = new System.Windows.Forms.Label();
            this.Sntxt = new System.Windows.Forms.TextBox();
            this.Tesnlb = new System.Windows.Forms.Label();
            this.Fntxt = new System.Windows.Forms.TextBox();
            this.Tefnlb = new System.Windows.Forms.Label();
            this.Sitxt = new System.Windows.Forms.TextBox();
            this.Silb = new System.Windows.Forms.Label();
            this.lobnt = new System.Windows.Forms.Button();
            this.Cbtn = new System.Windows.Forms.Button();
            this.Stsearchbtn = new System.Windows.Forms.Button();
            this.Stremovebtn = new System.Windows.Forms.Button();
            this.StAddbtn = new System.Windows.Forms.Button();
            this.Stupdatebtn = new System.Windows.Forms.Button();
            this.Mdtxt = new System.Windows.Forms.ComboBox();
            this.lablemd = new System.Windows.Forms.Label();
            this.Citxt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Imbox = new System.Windows.Forms.PictureBox();
            this.Imbtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.StDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imbox)).BeginInit();
            this.SuspendLayout();
            // 
            // StDGV
            // 
            this.StDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StDGV.Location = new System.Drawing.Point(274, 203);
            this.StDGV.Name = "StDGV";
            this.StDGV.Size = new System.Drawing.Size(479, 250);
            this.StDGV.TabIndex = 45;
            this.StDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StDGV_CellClick);
            // 
            // Dbtxt
            // 
            this.Dbtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dbtxt.Location = new System.Drawing.Point(110, 127);
            this.Dbtxt.Name = "Dbtxt";
            this.Dbtxt.Size = new System.Drawing.Size(121, 18);
            this.Dbtxt.TabIndex = 43;
            // 
            // Cotxt
            // 
            this.Cotxt.FormattingEnabled = true;
            this.Cotxt.Location = new System.Drawing.Point(110, 217);
            this.Cotxt.Name = "Cotxt";
            this.Cotxt.Size = new System.Drawing.Size(121, 21);
            this.Cotxt.TabIndex = 42;
            // 
            // Gntxt
            // 
            this.Gntxt.FormattingEnabled = true;
            this.Gntxt.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Nobinary",
            "Others"});
            this.Gntxt.Location = new System.Drawing.Point(110, 157);
            this.Gntxt.Name = "Gntxt";
            this.Gntxt.Size = new System.Drawing.Size(121, 21);
            this.Gntxt.TabIndex = 41;
            // 
            // Teimlb
            // 
            this.Teimlb.AutoSize = true;
            this.Teimlb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Teimlb.Location = new System.Drawing.Point(271, 37);
            this.Teimlb.Name = "Teimlb";
            this.Teimlb.Size = new System.Drawing.Size(39, 13);
            this.Teimlb.TabIndex = 38;
            this.Teimlb.Text = "Image:";
            // 
            // Adtxt
            // 
            this.Adtxt.Location = new System.Drawing.Point(110, 307);
            this.Adtxt.Multiline = true;
            this.Adtxt.Name = "Adtxt";
            this.Adtxt.Size = new System.Drawing.Size(120, 71);
            this.Adtxt.TabIndex = 37;
            // 
            // Teadlb
            // 
            this.Teadlb.AutoSize = true;
            this.Teadlb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Teadlb.Location = new System.Drawing.Point(25, 307);
            this.Teadlb.Name = "Teadlb";
            this.Teadlb.Size = new System.Drawing.Size(48, 13);
            this.Teadlb.TabIndex = 36;
            this.Teadlb.Text = "Address:";
            // 
            // Pntxt
            // 
            this.Pntxt.Location = new System.Drawing.Point(110, 277);
            this.Pntxt.Name = "Pntxt";
            this.Pntxt.Size = new System.Drawing.Size(120, 20);
            this.Pntxt.TabIndex = 35;
            // 
            // Tepnlb
            // 
            this.Tepnlb.AutoSize = true;
            this.Tepnlb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Tepnlb.Location = new System.Drawing.Point(25, 277);
            this.Tepnlb.Name = "Tepnlb";
            this.Tepnlb.Size = new System.Drawing.Size(81, 13);
            this.Tepnlb.TabIndex = 34;
            this.Tepnlb.Text = "Phone Number:";
            // 
            // Teclb
            // 
            this.Teclb.AutoSize = true;
            this.Teclb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Teclb.Location = new System.Drawing.Point(25, 217);
            this.Teclb.Name = "Teclb";
            this.Teclb.Size = new System.Drawing.Size(43, 13);
            this.Teclb.TabIndex = 33;
            this.Teclb.Text = "Course:";
            // 
            // Teglb
            // 
            this.Teglb.AutoSize = true;
            this.Teglb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Teglb.Location = new System.Drawing.Point(25, 157);
            this.Teglb.Name = "Teglb";
            this.Teglb.Size = new System.Drawing.Size(45, 13);
            this.Teglb.TabIndex = 32;
            this.Teglb.Text = "Gender:";
            // 
            // Tedblb
            // 
            this.Tedblb.AutoSize = true;
            this.Tedblb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Tedblb.Location = new System.Drawing.Point(25, 127);
            this.Tedblb.Name = "Tedblb";
            this.Tedblb.Size = new System.Drawing.Size(69, 13);
            this.Tedblb.TabIndex = 31;
            this.Tedblb.Text = "Date of Birth:";
            // 
            // Sntxt
            // 
            this.Sntxt.Location = new System.Drawing.Point(110, 97);
            this.Sntxt.Name = "Sntxt";
            this.Sntxt.Size = new System.Drawing.Size(120, 20);
            this.Sntxt.TabIndex = 30;
            // 
            // Tesnlb
            // 
            this.Tesnlb.AutoSize = true;
            this.Tesnlb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Tesnlb.Location = new System.Drawing.Point(25, 97);
            this.Tesnlb.Name = "Tesnlb";
            this.Tesnlb.Size = new System.Drawing.Size(52, 13);
            this.Tesnlb.TabIndex = 29;
            this.Tesnlb.Text = "Surname:";
            // 
            // Fntxt
            // 
            this.Fntxt.Location = new System.Drawing.Point(110, 67);
            this.Fntxt.Name = "Fntxt";
            this.Fntxt.Size = new System.Drawing.Size(120, 20);
            this.Fntxt.TabIndex = 28;
            // 
            // Tefnlb
            // 
            this.Tefnlb.AutoSize = true;
            this.Tefnlb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Tefnlb.Location = new System.Drawing.Point(25, 67);
            this.Tefnlb.Name = "Tefnlb";
            this.Tefnlb.Size = new System.Drawing.Size(60, 13);
            this.Tefnlb.TabIndex = 27;
            this.Tefnlb.Text = "First Name:";
            // 
            // Sitxt
            // 
            this.Sitxt.Enabled = false;
            this.Sitxt.Location = new System.Drawing.Point(110, 37);
            this.Sitxt.Name = "Sitxt";
            this.Sitxt.Size = new System.Drawing.Size(120, 20);
            this.Sitxt.TabIndex = 47;
            // 
            // Silb
            // 
            this.Silb.AutoSize = true;
            this.Silb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Silb.Location = new System.Drawing.Point(25, 37);
            this.Silb.Name = "Silb";
            this.Silb.Size = new System.Drawing.Size(64, 13);
            this.Silb.TabIndex = 46;
            this.Silb.Text = "Teacher ID:";
            this.Silb.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lobnt
            // 
            this.lobnt.Location = new System.Drawing.Point(168, 459);
            this.lobnt.Name = "lobnt";
            this.lobnt.Size = new System.Drawing.Size(75, 23);
            this.lobnt.TabIndex = 53;
            this.lobnt.Text = "Load";
            this.lobnt.UseVisualStyleBackColor = true;
            this.lobnt.Click += new System.EventHandler(this.lobnt_Click);
            // 
            // Cbtn
            // 
            this.Cbtn.Location = new System.Drawing.Point(168, 430);
            this.Cbtn.Name = "Cbtn";
            this.Cbtn.Size = new System.Drawing.Size(75, 23);
            this.Cbtn.TabIndex = 52;
            this.Cbtn.Text = "Clear";
            this.Cbtn.UseVisualStyleBackColor = true;
            this.Cbtn.Click += new System.EventHandler(this.Cbtn_Click);
            // 
            // Stsearchbtn
            // 
            this.Stsearchbtn.Location = new System.Drawing.Point(87, 395);
            this.Stsearchbtn.Name = "Stsearchbtn";
            this.Stsearchbtn.Size = new System.Drawing.Size(75, 23);
            this.Stsearchbtn.TabIndex = 51;
            this.Stsearchbtn.Text = "Search";
            this.Stsearchbtn.UseVisualStyleBackColor = true;
            this.Stsearchbtn.Click += new System.EventHandler(this.Stsearchbtn_Click);
            // 
            // Stremovebtn
            // 
            this.Stremovebtn.Location = new System.Drawing.Point(87, 459);
            this.Stremovebtn.Name = "Stremovebtn";
            this.Stremovebtn.Size = new System.Drawing.Size(75, 23);
            this.Stremovebtn.TabIndex = 50;
            this.Stremovebtn.Text = "Remove";
            this.Stremovebtn.UseVisualStyleBackColor = true;
            this.Stremovebtn.Click += new System.EventHandler(this.Stremovebtn_Click);
            // 
            // StAddbtn
            // 
            this.StAddbtn.Location = new System.Drawing.Point(168, 395);
            this.StAddbtn.Name = "StAddbtn";
            this.StAddbtn.Size = new System.Drawing.Size(75, 23);
            this.StAddbtn.TabIndex = 49;
            this.StAddbtn.Text = "Add";
            this.StAddbtn.UseVisualStyleBackColor = true;
            this.StAddbtn.Click += new System.EventHandler(this.StAddbtn_Click);
            // 
            // Stupdatebtn
            // 
            this.Stupdatebtn.Location = new System.Drawing.Point(87, 430);
            this.Stupdatebtn.Name = "Stupdatebtn";
            this.Stupdatebtn.Size = new System.Drawing.Size(75, 23);
            this.Stupdatebtn.TabIndex = 48;
            this.Stupdatebtn.Text = "Update";
            this.Stupdatebtn.UseVisualStyleBackColor = true;
            this.Stupdatebtn.Click += new System.EventHandler(this.Stupdatebtn_Click);
            // 
            // Mdtxt
            // 
            this.Mdtxt.FormattingEnabled = true;
            this.Mdtxt.Location = new System.Drawing.Point(110, 247);
            this.Mdtxt.Name = "Mdtxt";
            this.Mdtxt.Size = new System.Drawing.Size(121, 21);
            this.Mdtxt.TabIndex = 55;
            // 
            // lablemd
            // 
            this.lablemd.AutoSize = true;
            this.lablemd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lablemd.Location = new System.Drawing.Point(25, 247);
            this.lablemd.Name = "lablemd";
            this.lablemd.Size = new System.Drawing.Size(76, 13);
            this.lablemd.TabIndex = 54;
            this.lablemd.Text = "Module Name:";
            // 
            // Citxt
            // 
            this.Citxt.FormattingEnabled = true;
            this.Citxt.Location = new System.Drawing.Point(110, 187);
            this.Citxt.Name = "Citxt";
            this.Citxt.Size = new System.Drawing.Size(121, 21);
            this.Citxt.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(25, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Course ID:";
            // 
            // Imbox
            // 
            this.Imbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Imbox.Location = new System.Drawing.Point(347, 37);
            this.Imbox.Name = "Imbox";
            this.Imbox.Size = new System.Drawing.Size(162, 149);
            this.Imbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imbox.TabIndex = 44;
            this.Imbox.TabStop = false;
            // 
            // Imbtn
            // 
            this.Imbtn.Location = new System.Drawing.Point(515, 163);
            this.Imbtn.Name = "Imbtn";
            this.Imbtn.Size = new System.Drawing.Size(75, 23);
            this.Imbtn.TabIndex = 58;
            this.Imbtn.Text = "Browse";
            this.Imbtn.UseVisualStyleBackColor = true;
            this.Imbtn.Click += new System.EventHandler(this.Imbtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TeacherRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(765, 521);
            this.Controls.Add(this.Imbtn);
            this.Controls.Add(this.Citxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Mdtxt);
            this.Controls.Add(this.lablemd);
            this.Controls.Add(this.lobnt);
            this.Controls.Add(this.Cbtn);
            this.Controls.Add(this.Stsearchbtn);
            this.Controls.Add(this.Stremovebtn);
            this.Controls.Add(this.StAddbtn);
            this.Controls.Add(this.Stupdatebtn);
            this.Controls.Add(this.Sitxt);
            this.Controls.Add(this.Silb);
            this.Controls.Add(this.StDGV);
            this.Controls.Add(this.Imbox);
            this.Controls.Add(this.Dbtxt);
            this.Controls.Add(this.Cotxt);
            this.Controls.Add(this.Gntxt);
            this.Controls.Add(this.Teimlb);
            this.Controls.Add(this.Adtxt);
            this.Controls.Add(this.Teadlb);
            this.Controls.Add(this.Pntxt);
            this.Controls.Add(this.Tepnlb);
            this.Controls.Add(this.Teclb);
            this.Controls.Add(this.Teglb);
            this.Controls.Add(this.Tedblb);
            this.Controls.Add(this.Sntxt);
            this.Controls.Add(this.Tesnlb);
            this.Controls.Add(this.Fntxt);
            this.Controls.Add(this.Tefnlb);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TeacherRegistrationForm";
            this.Load += new System.EventHandler(this.TeacherRegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StDGV;
        private System.Windows.Forms.PictureBox Imbox;
        private System.Windows.Forms.DateTimePicker Dbtxt;
        private System.Windows.Forms.ComboBox Cotxt;
        private System.Windows.Forms.ComboBox Gntxt;
        private System.Windows.Forms.Label Teimlb;
        private System.Windows.Forms.TextBox Adtxt;
        private System.Windows.Forms.Label Teadlb;
        private System.Windows.Forms.TextBox Pntxt;
        private System.Windows.Forms.Label Tepnlb;
        private System.Windows.Forms.Label Teclb;
        private System.Windows.Forms.Label Teglb;
        private System.Windows.Forms.Label Tedblb;
        private System.Windows.Forms.TextBox Sntxt;
        private System.Windows.Forms.Label Tesnlb;
        private System.Windows.Forms.TextBox Fntxt;
        private System.Windows.Forms.Label Tefnlb;
        private System.Windows.Forms.TextBox Sitxt;
        private System.Windows.Forms.Label Silb;
        private System.Windows.Forms.Button lobnt;
        private System.Windows.Forms.Button Cbtn;
        private System.Windows.Forms.Button Stsearchbtn;
        private System.Windows.Forms.Button Stremovebtn;
        private System.Windows.Forms.Button StAddbtn;
        private System.Windows.Forms.Button Stupdatebtn;
        private System.Windows.Forms.ComboBox Mdtxt;
        private System.Windows.Forms.Label lablemd;
        private System.Windows.Forms.ComboBox Citxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Imbtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}