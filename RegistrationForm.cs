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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            ShowSR();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mhamz\Documents\FinalYearProjectdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void Reset()
        {
            Ustxt.Text = "";
            Pstxt.Text = "";
            Uttxt.Text = "";
            Pstxt2.Text = "";

        }
        private void SubLoginbt_Click(object sender, EventArgs e)
        {
            if (Ustxt.Text == ""|| Pstxt.Text == "" || Uttxt.Text == ""|| Pstxt2.Text =="")
            {
                MessageBox.Show("Missing Inforamtion");
            }
            else if (Pstxt.Text != Pstxt2.Text )
            {
                MessageBox.Show("your passwords do not match");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into UserTable(Username,Password,Usertype)Values(@UN,@UP,@UT)", Con);
                    cmd.Parameters.AddWithValue("@UN", Ustxt.Text);
                    cmd.Parameters.AddWithValue("@UP", Pstxt.Text);
                    cmd.Parameters.AddWithValue("@UT", Uttxt.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Login detials added Sucessfully");
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

        private void StDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StDGV.CurrentRow.Selected = true;
            Ustxt.Text = StDGV.Rows[e.RowIndex].Cells["Username"].Value.ToString();
            Pstxt.Text = StDGV.Rows[e.RowIndex].Cells["Password"].Value.ToString();
            Uttxt.Text = StDGV.Rows[e.RowIndex].Cells["UserType"].Value.ToString();
        }
        private void ShowSR()
        {
            Con.Open();
            String Query = "Select * from  UserTable";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StDGV.DataSource = ds.Tables[0];
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

        private void Stremovebtn_Click(object sender, EventArgs e)
        {
            if (Ustxt.Text.Length > 0)
            {
                Con.Open();
                SqlCommand cmd = Con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from UserTable where Username='" + Ustxt.Text + "'";
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

        private void Stsearchbtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = Con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            try
            {
                if (Ustxt.Text.Length > 0)
                {

                    cmd.CommandText = "select * from UserTable where Username='" + Ustxt.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    StDGV.DataSource = dt;
                }

                else if (Uttxt.Text.Length > 0)
                {


                    cmd.CommandText = "select * from UserTable where Usertype='" + Uttxt.Text + "'";
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
            if (Ustxt.Text == "" || Pstxt.Text == "" || Uttxt.Text == "")
            {
                MessageBox.Show("Missing Inforamtion");
            }
            else
            {
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter();
                    Con.Open();

                    sda.UpdateCommand = new SqlCommand("update UserTable set Username='" + Ustxt.Text + "',Password= '" + Pstxt.Text + "', usertype='" + Uttxt.Text + "' where Username='" + Ustxt.Text + "' ", Con);
                    sda.UpdateCommand.ExecuteNonQuery();

                    Con.Close();
                    MessageBox.Show("record updated");
                    ShowSR();
                    Reset();
                }
                catch 
                {

                    MessageBox.Show("This user name has been register before");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
