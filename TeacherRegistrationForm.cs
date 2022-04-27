using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace FinalYearProject
{
    public partial class TeacherRegistrationForm : Form
    {
        public TeacherRegistrationForm()
        {
            InitializeComponent();
            ShowSR();
            getcourseId();
            getModulename();


        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mhamz\Documents\FinalYearProjectdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TeacherRegistrationForm_Load(object sender, EventArgs e)
        {

        }
        private void getcourseId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select CourseId from CourseTable", Con);
            SqlDataReader r;
            r = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(r);
           // dt.Columns.Add("CourseId", typeof(int));
            Citxt.ValueMember = "CourseId";
            Citxt.DataSource = dt;
            Con.Close();


        }
        public void getcoursename()
        {
            Con.Open();
            string Qeruy = "Select * from CourseTable where CourseId=" + Citxt.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Qeruy, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Cotxt.Text = dr["Coursename"].ToString();

            }
            Con.Close();
        }
        private void getModulename()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select Modulename from ModuleTable", Con);
            SqlDataReader r;
            r = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(r);
            // dt.Columns.Add("CourseId", typeof(int));
            Mdtxt.ValueMember = "Modulename";
            Mdtxt.DataSource = dt;
            Con.Close();


        }
        private void ShowSR()
        {
            Con.Open();
            String Query = "Select * from TeacherRegistrationTable";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            Sitxt.Text = "";
            Fntxt.Text = "";
            Sntxt.Text = "";
            Dbtxt.Text = "";
            Gntxt.Text = "";
            Cotxt.Text = "";
            Citxt.Text = "";
            Mdtxt.Text = "";
            Pntxt.Text = "";
            Adtxt.Text = "";
            Imbox.Image = null;
        }

        private void StDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StDGV.CurrentRow.Selected = true;
            Sitxt.Text = StDGV.Rows[e.RowIndex].Cells["TeacherId"].Value.ToString();
            Fntxt.Text = StDGV.Rows[e.RowIndex].Cells["Firstname"].Value.ToString();
            Sntxt.Text = StDGV.Rows[e.RowIndex].Cells["Surname"].Value.ToString();
            Dbtxt.Text = StDGV.Rows[e.RowIndex].Cells["Dob"].Value.ToString();
            Gntxt.Text = StDGV.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
            Cotxt.Text = StDGV.Rows[e.RowIndex].Cells["Course"].Value.ToString();
            Citxt.Text = StDGV.Rows[e.RowIndex].Cells["CourseId"].Value.ToString();
            Mdtxt.Text = StDGV.Rows[e.RowIndex].Cells["Modulename"].Value.ToString();
            Pntxt.Text = StDGV.Rows[e.RowIndex].Cells["Phonenumber"].Value.ToString();
            Adtxt.Text = StDGV.Rows[e.RowIndex].Cells["Address"].Value.ToString();
           // MemoryStream m = new MemoryStream((byte[])StDGV.CurrentRow.Cells[8].Value);
         //   Imbox.Image = Image.FromStream(m);
        }

        private void lobnt_Click(object sender, EventArgs e)
        {
            ShowSR();
        }

        private void Cbtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Stremovebtn_Click(object sender, EventArgs e)
        {
            if (Fntxt.Text.Length > 0)
            {
                Con.Open();
                SqlCommand cmd = Con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from TeacherRegistrationTable where Firstname='" + Fntxt.Text + "'";
                cmd.ExecuteNonQuery();
                Con.Close();
                ShowSR();
                MessageBox.Show("Record deleted Successfully");
                Reset();
            }
            else
            {
                MessageBox.Show("No record is selscted");
            }            
        }

        private void StAddbtn_Click(object sender, EventArgs e)
        {
            if (Fntxt.Text == "" || Sntxt.Text == "" || Dbtxt.Text == "" || Gntxt.Text == "" || Pntxt.Text == "" || Adtxt.Text == "")
            {
                MessageBox.Show("Missing Inforamtion");
            }
            else
            {
                byte[] Imbox = null;
                FileStream Streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(Streem);
                Imbox = brs.ReadBytes((int)Streem.Length);
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into TeacherRegistrationTable(Firstname,Surname,Dob,Gender,CourseId,Course,Modulename,Phonenumber,Address,Image)Values(@DF,@DS,@DB,@DG,@DI,@DC,@DN,@DP,@DA,@images)", Con);
                    cmd.Parameters.AddWithValue("@DF", Fntxt.Text);
                    cmd.Parameters.AddWithValue("@DS", Sntxt.Text);
                    cmd.Parameters.AddWithValue("@DB", Dbtxt.Text);
                    cmd.Parameters.AddWithValue("@DG", Gntxt.Text);
                    cmd.Parameters.AddWithValue("@DI", Citxt.Text);
                    cmd.Parameters.AddWithValue("@DC", Cotxt.Text);
                    cmd.Parameters.AddWithValue("@DN", Mdtxt.Text);
                    cmd.Parameters.AddWithValue("@DP", Pntxt.Text);
                    cmd.Parameters.AddWithValue("@DA", Adtxt.Text);
                    cmd.Parameters.Add(new SqlParameter("@images", Imbox));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher Registered Sucessfully");
                    Con.Close();
                    ShowSR();
                    Reset();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Stupdatebtn_Click(object sender, EventArgs e)
        {
            if (Fntxt.Text == "" || Sntxt.Text == "" || Dbtxt.Text == "" || Gntxt.Text == "" || Pntxt.Text == "" || Adtxt.Text == "")
            {
                MessageBox.Show("Missing Inforamtion");
            }
            else
            {
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter();
                    Con.Open();

                    sda.UpdateCommand = new SqlCommand("update TeacherRegistrationTable set Firstname='" + Fntxt.Text + "',Surname= '" + Sntxt.Text + "', Dob='" + Dbtxt.Text + "'," +
                        " Gender='" + Gntxt.Text + "',CourseId='" + Citxt.Text + "',Course='" + Cotxt.Text + "',Modulename='" + Mdtxt.Text + "',Phonenumber='" + Pntxt.Text + "',Address='" + Pntxt.Text + "' where TeacherId='" + Sitxt.Text + "' ", Con);
                    sda.UpdateCommand.ExecuteNonQuery();

                    Con.Close();
                    MessageBox.Show("record updated");
                    ShowSR();
                    Reset();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Stsearchbtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = Con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            try
            {
                if (Fntxt.Text.Length > 0)
                {

                    cmd.CommandText = "select * from TeacherRegistrationTable where Firstname='" + Fntxt.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    StDGV.DataSource = dt;
                }

                else if (Sntxt.Text.Length > 0)
                {


                    cmd.CommandText = "select * from TeacherRegistrationTable where Surname='" + Sntxt.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    StDGV.DataSource = dt;
                }

                else if (Dbtxt.Text.Length > 0)
                {


                    cmd.CommandText = "select * from TeacherRegistrationTable where Dob='" + Dbtxt.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    StDGV.DataSource = dt;
                }
                else if (Gntxt.Text.Length > 0)
                {


                    cmd.CommandText = "select * from TeacherRegistrationTable where Gender='" + Gntxt.Text + "'";

                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    StDGV.DataSource = dt;
                }
                else if (Citxt.Text.Length > 0)
                {


                    cmd.CommandText = "select * from TeacherRegistrationTable where CourseId='" + Citxt.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    StDGV.DataSource = dt;
                }
                else if (Cotxt.Text.Length > 0)
                {


                    cmd.CommandText = "select * from TeacherRegistrationTable where Course='" + Cotxt.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    StDGV.DataSource = dt;
                }
                else if (Mdtxt.Text.Length > 0)
                {


                    cmd.CommandText = "select * from TeacherRegistrationTable where Module='" + Mdtxt.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    StDGV.DataSource = dt;
                }
                else if (Pntxt.Text.Length > 0)
                {


                    cmd.CommandText = "select * from TeacherRegistrationTable where Phonenumber='" + Pntxt.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    StDGV.DataSource = dt;
                }
                else if (Adtxt.Text.Length > 0)
                {


                    cmd.CommandText = "select * from TeacherRegistrationTable where Address='" + Adtxt.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    StDGV.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Information is provided to search the records");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }



            Con.Close();

        }
        string imgLocation = "";
        private void Imbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *jpe, *jfif, *.png, *.bmp) | *.jpg; *.jpeg; *jpe; *jfif; *.png; *.bmp";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                Imbox.ImageLocation = imgLocation;
            }

        
        }

        private void Citxt_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getcoursename();
        }
    }
}
