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
    public partial class AttendenceForm : Form
    {
        public AttendenceForm()
        {
            InitializeComponent();
            ShowSR();
            getstudentId();
            getcourseId();
          //  getModulename();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mhamz\Documents\FinalYearProjectdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void AttendenceForm_Load(object sender, EventArgs e)
        {

        }
        private void getstudentId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select StudentId from StudentRegistrationTable", Con);
            SqlDataReader r;
            r = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(r);
            // dt.Columns.Add("CourseId", typeof(int));
            Sitxt.ValueMember = "StudentId";
            Sitxt.DataSource = dt;
            Con.Close();


        }
        public void getstudentfname()
        {
            Con.Open();
            string Qeruy = "Select * from StudentRegistrationTable where StudentId=" + Sitxt.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Qeruy, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Fntxt.Text = dr["Firstname"].ToString();

            }
            Con.Close();
        }
        public void getstudentsname()
        {
            Con.Open();
            string Qeruy = "Select * from StudentRegistrationTable where StudentId=" + Sitxt.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Qeruy, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Sntxt.Text = dr["Surname"].ToString();

            }
            Con.Close();
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
            string Qeruy = "Select * from ModuleTable where CourseId=" + Citxt.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Qeruy, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Mdtxt.Text = dr["Modulename"].ToString();

            }
            Con.Close();

            /* Con.Open();
             SqlCommand cmd = new SqlCommand("Select Modulename from ModuleTable", Con);
             SqlDataReader r;
             r = cmd.ExecuteReader();
             DataTable dt = new DataTable();
             dt.Load(r);
             // dt.Columns.Add("CourseId", typeof(int));
             Mdtxt.ValueMember = "Modulename";
             Mdtxt.DataSource = dt;
             Con.Close();
            */

        }

        private void ShowSR()
        {
            Con.Open();
            String Query = "Select * from AttendenceTable";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            Attxt.Text = "";
            Sitxt.Text = "";
            Fntxt.Text = "";
            Sntxt.Text = "";
            Datxt.Text = "";
            Cotxt.Text = "";
            Citxt.Text = "";
            Mdtxt.Text = "";
            Sttxt.Text = "";

        }

        private void StDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StDGV.CurrentRow.Selected = true;
            Sitxt.Text = StDGV.Rows[e.RowIndex].Cells["AttendenceId"].Value.ToString();
            Sitxt.Text = StDGV.Rows[e.RowIndex].Cells["StudentId"].Value.ToString();
            Fntxt.Text = StDGV.Rows[e.RowIndex].Cells["Firstname"].Value.ToString();
            Sntxt.Text = StDGV.Rows[e.RowIndex].Cells["Surname"].Value.ToString();
            Datxt.Text = StDGV.Rows[e.RowIndex].Cells["Date"].Value.ToString();
            Cotxt.Text = StDGV.Rows[e.RowIndex].Cells["Coursename"].Value.ToString();
            Citxt.Text = StDGV.Rows[e.RowIndex].Cells["CourseId"].Value.ToString();
            Mdtxt.Text = StDGV.Rows[e.RowIndex].Cells["Modulename"].Value.ToString();
            Sttxt.Text = StDGV.Rows[e.RowIndex].Cells["Status"].Value.ToString();

        }

        private void Sitxt_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getstudentfname();
            getstudentsname();
        }

        private void Citxt_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getcoursename();
            getModulename();
        }

        private void Cbtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void lobnt_Click(object sender, EventArgs e)
        {
            ShowSR();
        }

        private void Stremovebtn_Click(object sender, EventArgs e)
        {
            if (Fntxt.Text.Length > 0)
            {
                Con.Open();
                SqlCommand cmd = Con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from AttendenceTable where Firstname='" + Fntxt.Text + "'";
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

        private void Stupdatebtn_Click(object sender, EventArgs e)
        {
            if (Cotxt.Text == "" || Citxt.Text == "" || Sttxt.Text == "" || Mdtxt.Text == "" || Fntxt.Text == "" || Sntxt.Text == "")
            {
                MessageBox.Show("Missing Inforamtion");
            }
            else
            {
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter();
                    Con.Open();

                    sda.UpdateCommand = new SqlCommand("update AttendenceTable set CourseId='" + Citxt.Text + "',Coursename='" + Cotxt.Text + "',Modulename='" + Mdtxt.Text + "',Status='" + Sttxt.Text + "' where AttendenceId='" + Attxt.Text + "' ", Con);
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

        private void StAddbtn_Click(object sender, EventArgs e)
        {
            if (Fntxt.Text == "" || Sntxt.Text == "" || Datxt.Text == "" || Citxt.Text == "" || Sttxt.Text == "" || Mdtxt.Text == "")
            {
                MessageBox.Show("Missing Inforamtion");
            }
            else
            {
                
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into AttendenceTable(StudentId,Firstname,Surname,Date,CourseId,Coursename,Modulename,Status)Values(@SI,@DF,@DS,@DA,@DI,@DC,@DN,@DSA)", Con);
                    cmd.Parameters.AddWithValue("@SI", Sitxt.Text);
                    cmd.Parameters.AddWithValue("@DF", Fntxt.Text);
                    cmd.Parameters.AddWithValue("@DS", Sntxt.Text);
                    cmd.Parameters.AddWithValue("@DA", Datxt.Text);
                    cmd.Parameters.AddWithValue("@DI", Citxt.Text);
                    cmd.Parameters.AddWithValue("@DC", Cotxt.Text);
                    cmd.Parameters.AddWithValue("@DN", Mdtxt.Text);
                    cmd.Parameters.AddWithValue("@DSA", Sttxt.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendence recorded Sucessfully");
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

        private void Stsearchbtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = Con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            try
            {
                if (Fntxt.Text.Length > 0)
                {

                    cmd.CommandText = "select * from AttendenceTable where Firstname='" + Fntxt.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    StDGV.DataSource = dt;
                }

                else if (Sntxt.Text.Length > 0)
                {


                    cmd.CommandText = "select * from AttendenceTable where Surname='" + Sntxt.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    StDGV.DataSource = dt;
                }

                else if (Datxt.Text.Length > 0)
                {


                    cmd.CommandText = "select * from AttendenceTable where Date='" + Datxt.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    StDGV.DataSource = dt;
                }
                
                else if (Citxt.Text.Length > 0)
                {


                    cmd.CommandText = "select * from AttendenceTable where CourseId='" + Citxt.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    StDGV.DataSource = dt;
                }
                else if (Cotxt.Text.Length > 0)
                {


                    cmd.CommandText = "select * from AttendenceTable where Coursename='" + Cotxt.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    StDGV.DataSource = dt;
                }
                else if (Mdtxt.Text.Length > 0)
                {


                    cmd.CommandText = "select * from AttendenceTable where Modulename='" + Mdtxt.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    StDGV.DataSource = dt;
                }
                else if (Sttxt.Text.Length > 0)
                {


                    cmd.CommandText = "select * from AttendenceTable where Status='" + Sttxt.Text + "'";
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
    }

}
