namespace FinalYearProject
{
    partial class AttendenceForm
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
            this.Tefnlb = new System.Windows.Forms.Label();
            this.Fntxt = new System.Windows.Forms.TextBox();
            this.Tesnlb = new System.Windows.Forms.Label();
            this.Sntxt = new System.Windows.Forms.TextBox();
            this.Teclb = new System.Windows.Forms.Label();
            this.Silb = new System.Windows.Forms.Label();
            this.Cotxt = new System.Windows.Forms.TextBox();
            this.lablemd = new System.Windows.Forms.Label();
            this.Mdtxt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Citxt = new System.Windows.Forms.ComboBox();
            this.Datxt = new System.Windows.Forms.DateTimePicker();
            this.Tedblb = new System.Windows.Forms.Label();
            this.Attxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lobnt = new System.Windows.Forms.Button();
            this.Cbtn = new System.Windows.Forms.Button();
            this.Stsearchbtn = new System.Windows.Forms.Button();
            this.Stremovebtn = new System.Windows.Forms.Button();
            this.StAddbtn = new System.Windows.Forms.Button();
            this.Stupdatebtn = new System.Windows.Forms.Button();
            this.Sttxt = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Sitxt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.StDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // StDGV
            // 
            this.StDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StDGV.Location = new System.Drawing.Point(231, 34);
            this.StDGV.Name = "StDGV";
            this.StDGV.Size = new System.Drawing.Size(507, 408);
            this.StDGV.TabIndex = 0;
            this.StDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StDGV_CellClick);
            // 
            // Tefnlb
            // 
            this.Tefnlb.AutoSize = true;
            this.Tefnlb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Tefnlb.Location = new System.Drawing.Point(9, 123);
            this.Tefnlb.Name = "Tefnlb";
            this.Tefnlb.Size = new System.Drawing.Size(60, 13);
            this.Tefnlb.TabIndex = 60;
            this.Tefnlb.Text = "First Name:";
            // 
            // Fntxt
            // 
            this.Fntxt.Location = new System.Drawing.Point(94, 123);
            this.Fntxt.Name = "Fntxt";
            this.Fntxt.Size = new System.Drawing.Size(120, 20);
            this.Fntxt.TabIndex = 61;
            // 
            // Tesnlb
            // 
            this.Tesnlb.AutoSize = true;
            this.Tesnlb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Tesnlb.Location = new System.Drawing.Point(9, 153);
            this.Tesnlb.Name = "Tesnlb";
            this.Tesnlb.Size = new System.Drawing.Size(52, 13);
            this.Tesnlb.TabIndex = 62;
            this.Tesnlb.Text = "Surname:";
            // 
            // Sntxt
            // 
            this.Sntxt.Location = new System.Drawing.Point(94, 153);
            this.Sntxt.Name = "Sntxt";
            this.Sntxt.Size = new System.Drawing.Size(120, 20);
            this.Sntxt.TabIndex = 63;
            // 
            // Teclb
            // 
            this.Teclb.AutoSize = true;
            this.Teclb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Teclb.Location = new System.Drawing.Point(9, 240);
            this.Teclb.Name = "Teclb";
            this.Teclb.Size = new System.Drawing.Size(43, 13);
            this.Teclb.TabIndex = 66;
            this.Teclb.Text = "Course:";
            // 
            // Silb
            // 
            this.Silb.AutoSize = true;
            this.Silb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Silb.Location = new System.Drawing.Point(9, 93);
            this.Silb.Name = "Silb";
            this.Silb.Size = new System.Drawing.Size(61, 13);
            this.Silb.TabIndex = 69;
            this.Silb.Text = "Student ID:";
            this.Silb.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Cotxt
            // 
            this.Cotxt.Enabled = false;
            this.Cotxt.Location = new System.Drawing.Point(95, 240);
            this.Cotxt.Name = "Cotxt";
            this.Cotxt.Size = new System.Drawing.Size(120, 20);
            this.Cotxt.TabIndex = 75;
            // 
            // lablemd
            // 
            this.lablemd.AutoSize = true;
            this.lablemd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lablemd.Location = new System.Drawing.Point(9, 270);
            this.lablemd.Name = "lablemd";
            this.lablemd.Size = new System.Drawing.Size(76, 13);
            this.lablemd.TabIndex = 71;
            this.lablemd.Text = "Module Name:";
            // 
            // Mdtxt
            // 
            this.Mdtxt.FormattingEnabled = true;
            this.Mdtxt.Location = new System.Drawing.Point(94, 270);
            this.Mdtxt.Name = "Mdtxt";
            this.Mdtxt.Size = new System.Drawing.Size(121, 21);
            this.Mdtxt.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(9, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Course ID:";
            // 
            // Citxt
            // 
            this.Citxt.FormattingEnabled = true;
            this.Citxt.Location = new System.Drawing.Point(94, 210);
            this.Citxt.Name = "Citxt";
            this.Citxt.Size = new System.Drawing.Size(121, 21);
            this.Citxt.TabIndex = 74;
            this.Citxt.SelectionChangeCommitted += new System.EventHandler(this.Citxt_SelectionChangeCommitted);
            // 
            // Datxt
            // 
            this.Datxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datxt.Location = new System.Drawing.Point(94, 183);
            this.Datxt.Name = "Datxt";
            this.Datxt.Size = new System.Drawing.Size(121, 18);
            this.Datxt.TabIndex = 68;
            // 
            // Tedblb
            // 
            this.Tedblb.AutoSize = true;
            this.Tedblb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Tedblb.Location = new System.Drawing.Point(9, 183);
            this.Tedblb.Name = "Tedblb";
            this.Tedblb.Size = new System.Drawing.Size(33, 13);
            this.Tedblb.TabIndex = 64;
            this.Tedblb.Text = "Date:";
            // 
            // Attxt
            // 
            this.Attxt.Enabled = false;
            this.Attxt.Location = new System.Drawing.Point(95, 58);
            this.Attxt.Name = "Attxt";
            this.Attxt.Size = new System.Drawing.Size(120, 20);
            this.Attxt.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(10, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "Attendence ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lobnt
            // 
            this.lobnt.Location = new System.Drawing.Point(118, 420);
            this.lobnt.Name = "lobnt";
            this.lobnt.Size = new System.Drawing.Size(75, 23);
            this.lobnt.TabIndex = 83;
            this.lobnt.Text = "Load";
            this.lobnt.UseVisualStyleBackColor = true;
            this.lobnt.Click += new System.EventHandler(this.lobnt_Click);
            // 
            // Cbtn
            // 
            this.Cbtn.Location = new System.Drawing.Point(118, 391);
            this.Cbtn.Name = "Cbtn";
            this.Cbtn.Size = new System.Drawing.Size(75, 23);
            this.Cbtn.TabIndex = 82;
            this.Cbtn.Text = "Clear";
            this.Cbtn.UseVisualStyleBackColor = true;
            this.Cbtn.Click += new System.EventHandler(this.Cbtn_Click);
            // 
            // Stsearchbtn
            // 
            this.Stsearchbtn.Location = new System.Drawing.Point(37, 356);
            this.Stsearchbtn.Name = "Stsearchbtn";
            this.Stsearchbtn.Size = new System.Drawing.Size(75, 23);
            this.Stsearchbtn.TabIndex = 81;
            this.Stsearchbtn.Text = "Search";
            this.Stsearchbtn.UseVisualStyleBackColor = true;
            this.Stsearchbtn.Click += new System.EventHandler(this.Stsearchbtn_Click);
            // 
            // Stremovebtn
            // 
            this.Stremovebtn.Location = new System.Drawing.Point(37, 420);
            this.Stremovebtn.Name = "Stremovebtn";
            this.Stremovebtn.Size = new System.Drawing.Size(75, 23);
            this.Stremovebtn.TabIndex = 80;
            this.Stremovebtn.Text = "Remove";
            this.Stremovebtn.UseVisualStyleBackColor = true;
            this.Stremovebtn.Click += new System.EventHandler(this.Stremovebtn_Click);
            // 
            // StAddbtn
            // 
            this.StAddbtn.Location = new System.Drawing.Point(118, 356);
            this.StAddbtn.Name = "StAddbtn";
            this.StAddbtn.Size = new System.Drawing.Size(75, 23);
            this.StAddbtn.TabIndex = 79;
            this.StAddbtn.Text = "Add";
            this.StAddbtn.UseVisualStyleBackColor = true;
            this.StAddbtn.Click += new System.EventHandler(this.StAddbtn_Click);
            // 
            // Stupdatebtn
            // 
            this.Stupdatebtn.Location = new System.Drawing.Point(37, 391);
            this.Stupdatebtn.Name = "Stupdatebtn";
            this.Stupdatebtn.Size = new System.Drawing.Size(75, 23);
            this.Stupdatebtn.TabIndex = 78;
            this.Stupdatebtn.Text = "Update";
            this.Stupdatebtn.UseVisualStyleBackColor = true;
            this.Stupdatebtn.Click += new System.EventHandler(this.Stupdatebtn_Click);
            // 
            // Sttxt
            // 
            this.Sttxt.FormattingEnabled = true;
            this.Sttxt.Items.AddRange(new object[] {
            "Present",
            "Absent"});
            this.Sttxt.Location = new System.Drawing.Point(93, 297);
            this.Sttxt.Name = "Sttxt";
            this.Sttxt.Size = new System.Drawing.Size(121, 21);
            this.Sttxt.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(8, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 84;
            this.label3.Text = "Status:";
            // 
            // Sitxt
            // 
            this.Sitxt.FormattingEnabled = true;
            this.Sitxt.Location = new System.Drawing.Point(95, 90);
            this.Sitxt.Name = "Sitxt";
            this.Sitxt.Size = new System.Drawing.Size(121, 21);
            this.Sitxt.TabIndex = 86;
            this.Sitxt.SelectionChangeCommitted += new System.EventHandler(this.Sitxt_SelectionChangeCommitted);
            // 
            // AttendenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(765, 521);
            this.Controls.Add(this.Sitxt);
            this.Controls.Add(this.Sttxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lobnt);
            this.Controls.Add(this.Cbtn);
            this.Controls.Add(this.Stsearchbtn);
            this.Controls.Add(this.Stremovebtn);
            this.Controls.Add(this.StAddbtn);
            this.Controls.Add(this.Stupdatebtn);
            this.Controls.Add(this.Attxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cotxt);
            this.Controls.Add(this.Citxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Mdtxt);
            this.Controls.Add(this.lablemd);
            this.Controls.Add(this.Silb);
            this.Controls.Add(this.Datxt);
            this.Controls.Add(this.Teclb);
            this.Controls.Add(this.Tedblb);
            this.Controls.Add(this.Sntxt);
            this.Controls.Add(this.Tesnlb);
            this.Controls.Add(this.Fntxt);
            this.Controls.Add(this.Tefnlb);
            this.Controls.Add(this.StDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AttendenceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttendenceForm";
            this.Load += new System.EventHandler(this.AttendenceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StDGV;
        private System.Windows.Forms.Label Tefnlb;
        private System.Windows.Forms.TextBox Fntxt;
        private System.Windows.Forms.Label Tesnlb;
        private System.Windows.Forms.TextBox Sntxt;
        private System.Windows.Forms.Label Teclb;
        private System.Windows.Forms.Label Silb;
        private System.Windows.Forms.TextBox Cotxt;
        private System.Windows.Forms.Label lablemd;
        private System.Windows.Forms.ComboBox Mdtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Citxt;
        private System.Windows.Forms.DateTimePicker Datxt;
        private System.Windows.Forms.Label Tedblb;
        private System.Windows.Forms.TextBox Attxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lobnt;
        private System.Windows.Forms.Button Cbtn;
        private System.Windows.Forms.Button Stsearchbtn;
        private System.Windows.Forms.Button Stremovebtn;
        private System.Windows.Forms.Button StAddbtn;
        private System.Windows.Forms.Button Stupdatebtn;
        private System.Windows.Forms.ComboBox Sttxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Sitxt;
    }
}