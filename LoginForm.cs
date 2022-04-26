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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mhamz\Documents\FinalYearProjectdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Loginbt_Click(object sender, EventArgs e)
        {
          
            

            if (Ustxt.Text == "" || Pstxt.Text == "" || Uttxt.Text == "")
            {
                MessageBox.Show("Missing Fields");
            }
            else 
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(0) From [dbo].[UserTable] where Username='" + Ustxt.Text + "' and Password= '" + Pstxt.Text + "' and usertype='" + Uttxt.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    if (Uttxt.Text == "Student")
                    {
                        Studentform st = new Studentform();
                        st.Show();

                    }
                    else if (Uttxt.Text == "Teacher")
                    {
                        Teacherform tt = new Teacherform();
                        tt.Show();
                    }

                    else if (Uttxt.Text == "Admin")
                    {
                        Adminform aa = new Adminform();
                        aa.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Please check Username and Password, invalid Username Or Password");
                }
            }
            
           

           

        }
    }
}
