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
    public partial class MisForm : Form
    {
        public MisForm()
        {
            InitializeComponent();
            ShowSR();
            ShowSR2();
            getcourseId();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mhamz\Documents\FinalYearProjectdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void label1_Click(object sender, EventArgs e)
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
            Citxt2.ValueMember = "CourseId";
            Citxt2.DataSource = dt;
            Con.Close();


        }
        public void getcoursename()
        {
            Con.Open();
            string Qeruy = "Select * from CourseTable where CourseId=" + Citxt2.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Qeruy, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Cntxt2.Text = dr["Coursename"].ToString();

            }
            Con.Close();
        }
        private void ShowSR()
        {
            Con.Open();
            String Query = "Select * from CourseTable";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ShowSR2()
        {
            Con.Open();
            String Query = "Select * from ModuleTable";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StDGV2.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            Citxt.Text = "";
            Cntxt.Text = "";
            Cftxt.Text = "";
            
        }
        private void Reset2()
        {
            Citxt2.Text = "";
            Cntxt2.Text = "";
            Mntxt.Text = "";

        }

        private void StDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StDGV.CurrentRow.Selected = true;
            Citxt.Text = StDGV.Rows[e.RowIndex].Cells["CourseId"].Value.ToString();
            Cntxt.Text = StDGV.Rows[e.RowIndex].Cells["Coursename"].Value.ToString();
            Cftxt.Text = StDGV.Rows[e.RowIndex].Cells["Coursefee"].Value.ToString();
            
        }

        private void StDGV2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StDGV2.CurrentRow.Selected = true;
            Mntxt.Text = StDGV2.Rows[e.RowIndex].Cells["Modulename"].Value.ToString();
            Citxt2.Text = StDGV2.Rows[e.RowIndex].Cells["CourseId"].Value.ToString();
            Cntxt2.Text = StDGV2.Rows[e.RowIndex].Cells["Coursename"].Value.ToString();
        }

        private void Cbtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void lobnt_Click(object sender, EventArgs e)
        {
            ShowSR();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reset2();
        }

        private void lobnt2_Click(object sender, EventArgs e)
        {
            ShowSR2();
        }

        private void Stremovebtn_Click(object sender, EventArgs e)
        {
            if (Citxt.Text.Length > 0)
            {
                Con.Open();
                SqlCommand cmd = Con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from CourseTable where CourseId='" + Citxt.Text + "'";
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
            if (Citxt.Text == "" || Cntxt.Text == "" || Cftxt.Text == "")
            {
                MessageBox.Show("Missing Inforamtion");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into CourseTable(CourseId,Coursename,Coursefee)Values(@CI,@CN,@CF)", Con);
                    cmd.Parameters.AddWithValue("@CI", Citxt.Text);
                    cmd.Parameters.AddWithValue("@CN", Cntxt.Text);
                    cmd.Parameters.AddWithValue("@CF", Cftxt.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Course Added Sucessfully");
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
                if (Citxt.Text.Length > 0)
                {

                    cmd.CommandText = "select * from CourseTable where CourseId='" + Citxt.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    StDGV.DataSource = dt;
                }

                else if (Cntxt.Text.Length > 0)
                {


                    cmd.CommandText = "select * from CourseTable where Coursename='" + Cntxt.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    StDGV.DataSource = dt;
                }

                else if (Cftxt.Text.Length > 0)
                {


                    cmd.CommandText = "select * from CourseTable where Coursefee='" + Cftxt.Text + "'";
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

        private void Stupdatebtn_Click(object sender, EventArgs e)
        {
            if (Citxt.Text == "" || Cntxt.Text == "" || Cftxt.Text == "")
            {
                MessageBox.Show("Missing Inforamtion");
            }
            else
            {
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter();
                    Con.Open();

                    sda.UpdateCommand = new SqlCommand("update CourseTable set CourseId='" + Citxt.Text + "',Coursename= '" + Cntxt.Text + "', Coursefee='" + Cftxt.Text + "' where CourseId='" + Citxt.Text + "' ", Con);
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

        private void StAddbtn2_Click(object sender, EventArgs e)
        {
            if (Mntxt.Text == "" )//|| Cntxt2.Text == "" || Citxt2.Text == "")
            {
                MessageBox.Show("Missing Inforamtion");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into ModuleTable(Modulename,CourseId,Coursename)Values(@MN,@CI,@CN)", Con);
                    cmd.Parameters.AddWithValue("@MN", Mntxt.Text);
                    cmd.Parameters.AddWithValue("@CI", Citxt2.Text);
                    cmd.Parameters.AddWithValue("@CN", Cntxt2.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Module Added Sucessfully");
                    Con.Close();
                    ShowSR2();
                    Reset2();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Stremovebtn2_Click(object sender, EventArgs e)
        {
            if (Mntxt.Text.Length > 0)
            {
                Con.Open();
                SqlCommand cmd = Con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from ModuleTable where Modulename='" + Mntxt.Text + "'";
                cmd.ExecuteNonQuery();
                Con.Close();
                ShowSR2();
                MessageBox.Show("Record deleted Successfully");
                Reset2();
            }
            else
            {
                MessageBox.Show("No record is selscted");
            }
        }

        private void Stupdatebtn2_Click(object sender, EventArgs e)
        {
            if (Mntxt.Text == "")// || Cntxt.Text == "" || Cftxt.Text == "")
            {
                MessageBox.Show("Missing Inforamtion");
            }
            else
            {
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter();
                    Con.Open();

                    sda.UpdateCommand = new SqlCommand("update ModuleTable set Modulename='" + Mntxt.Text + "',CourseId= '" + Citxt2.Text + "', Coursename='" + Cntxt2.Text + "' where Modulename='" + Mntxt.Text + "' ", Con);
                    sda.UpdateCommand.ExecuteNonQuery();

                    Con.Close();
                    MessageBox.Show("record updated");
                    ShowSR2();
                    Reset2();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Stsearchbtn2_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = Con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            try
            {
                if (Mntxt.Text.Length > 0)
                {

                    cmd.CommandText = "select * from ModuleTable where Modulename='" + Mntxt.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    StDGV2.DataSource = dt;
                }

                else if (Citxt.Text.Length > 0)
                {


                    cmd.CommandText = "select * from ModuleTable where CourseId='" + Citxt.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    StDGV2.DataSource = dt;
                }

                else if (Cntxt.Text.Length > 0)
                {


                    cmd.CommandText = "select * from ModuleTable where Coursename='" + Cntxt.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    StDGV2.DataSource = dt;
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

        private void Citxt2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getcoursename();
        }
    }
}
