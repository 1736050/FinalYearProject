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
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mhamz\Documents\FinalYearProjectdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void StudentRegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void ShowSR()
        {
            Con.Open();

            Con.Close();
        }
            
        private void StAddbtn_Click(object sender, EventArgs e)
        {
            if (Fntxt.Text == "" || Sntxt.Text == "" || Dbtxt.Text == "" ||  Pntxt.Text == "" || Adtxt.Text == "")
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
                    //  cmd.Parameters.AddWithValue("@DI", Imbox.Image);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Registered Sucessfully");
                    Con.Close();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void Stremovebtn_Click(object sender, EventArgs e)
        {

        }

        private void Stupdatebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
