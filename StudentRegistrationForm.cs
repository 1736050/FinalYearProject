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


namespace FinalYearProject
{
    public partial class StudentRegistrationForm : Form
    {
        public StudentRegistrationForm()
        {
            InitializeComponent();
            ShowSR();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mhamz\Documents\FinalYearProjectdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void StudentRegistrationForm_Load(object sender, EventArgs e)
        {

        }
        
        
        private void ShowSR()
        {
            Con.Open();
            String Query = "Select * from StudentRegistrationTable";
            SqlDataAdapter sda = new SqlDataAdapter(Query,Con);
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
            Pntxt.Text = "";
            Adtxt.Text = "";
         //   Imbox.Image = null;
        }
        private void StAddbtn_Click(object sender, EventArgs e)
        {
            if (Fntxt.Text == "" || Sntxt.Text == "" || Dbtxt.Text == "" || Gntxt.Text == "" ||  Pntxt.Text == "" || Adtxt.Text == "" || Cotxt.Text == "")
            {
                MessageBox.Show("Missing Inforamtion");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into StudentRegistrationTable(Firstname,Surname,Dob,Gender,Course,Phonenumber,Address)Values(@DF,@DS,@DB,@DG,@DC,@DP,@DA)", Con);
                    cmd.Parameters.AddWithValue("@DF", Fntxt.Text);
                    cmd.Parameters.AddWithValue("@DS", Sntxt.Text);
                    cmd.Parameters.AddWithValue("@DB", Dbtxt.Text);
                    cmd.Parameters.AddWithValue("@DG", Gntxt.Text);
                   cmd.Parameters.AddWithValue("@DC", Cotxt.Text);
                    cmd.Parameters.AddWithValue("@DP", Pntxt.Text);
                    cmd.Parameters.AddWithValue("@DA", Adtxt.Text);
                  // cmd.Parameters.AddWithValue("@DI", Imbox.Image);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Registered Sucessfully");
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
        
        private void Stremovebtn_Click(object sender, EventArgs e)
        {

            if (Fntxt.Text.Length > 0)
            {
                Con.Open();
                SqlCommand cmd = Con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from StudentRegistrationTable where Firstname='" + Fntxt.Text + "'";
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
            if (Fntxt.Text == "" || Sntxt.Text == "" || Dbtxt.Text == "" || Gntxt.Text == "" || Pntxt.Text == "" || Adtxt.Text == ""|| Cotxt.Text == "")
            {
                MessageBox.Show("Missing Inforamtion");
            }
            else
            {
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter();
                    Con.Open();

                    sda.UpdateCommand = new SqlCommand("update StudentRegistrationTable set Firstname='" + Fntxt.Text + "',Surname= '" + Sntxt.Text + "', Dob='" + Dbtxt.Text + "'," +
                        " Gender='" + Gntxt.Text + "',Course='" + Cotxt.Text + "',Phonenumber='" + Pntxt.Text + "',Address='" + Pntxt.Text + "' where StudentId='" + Sitxt.Text + "' ", Con);
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

        private void StDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StDGV.CurrentRow.Selected = true;
            Sitxt.Text = StDGV.Rows[e.RowIndex].Cells["StudentId"].Value.ToString();
            Fntxt.Text = StDGV.Rows[e.RowIndex].Cells["Firstname"].Value.ToString();
            Sntxt.Text = StDGV.Rows[e.RowIndex].Cells["Surname"].Value.ToString();
            Dbtxt.Text = StDGV.Rows[e.RowIndex].Cells["Dob"].Value.ToString();
            Gntxt.Text = StDGV.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
            Cotxt.Text = StDGV.Rows[e.RowIndex].Cells["Course"].Value.ToString();
            Pntxt.Text = StDGV.Rows[e.RowIndex].Cells["Phonenumber"].Value.ToString();
            Adtxt.Text = StDGV.Rows[e.RowIndex].Cells["Address"].Value.ToString();
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

                    cmd.CommandText = "select * from StudentRegistrationTable where Firstname='" + Fntxt.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    StDGV.DataSource = dt;
                }

                else if (Sntxt.Text.Length > 0)
                {


                    cmd.CommandText = "select * from StudentRegistrationTable where Surname='" + Sntxt.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    StDGV.DataSource = dt;
                }

                   else if (Dbtxt.Text.Length > 0)
                       {


                             cmd.CommandText = "select * from StudentRegistrationTable where Dob='" + Dbtxt.Text + "'";
                cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    StDGV.DataSource = dt;
                }
                else if (Gntxt.Text.Length > 0)
                {


                    cmd.CommandText = "select * from StudentRegistrationTable where Gender='" + Gntxt.Text + "'";
                     
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    StDGV.DataSource = dt;
                }
                else if (Cotxt.Text.Length > 0)
                {


                    cmd.CommandText = "select * from StudentRegistrationTable where Course='" + Cotxt.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    StDGV.DataSource = dt;
                }
                else if (Pntxt.Text.Length > 0)
                {


                    cmd.CommandText = "select * from StudentRegistrationTable where Phonenumber='" + Pntxt.Text + "'";
                     cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    StDGV.DataSource = dt;
                }
                else if (Adtxt.Text.Length > 0)
                {


                    cmd.CommandText = "select * from StudentRegistrationTable where Address='" + Adtxt.Text + "'";
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

        private void Cbtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void lobnt_Click(object sender, EventArgs e)
        {
            ShowSR();
        }

       
    }
}
