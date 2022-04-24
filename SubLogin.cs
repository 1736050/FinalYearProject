using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalYearProject
{
    public partial class SubLogin : Form
    {
        public SubLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SubLogin_Load(object sender, EventArgs e)
        {

        }

        private void SubLoginbt_Click(object sender, EventArgs e) // by clicking this button I can navigate to Student, Teacher and Admin Form
        {
            if (SubUsertypeCb.Text == "Student")
            {
                Studentform studentformop = new Studentform();
                studentformop.Show();
                this.Hide();
            }

            else if (SubUsertypeCb.Text == "Teacher")
            {
                Teacherform teacherformop = new Teacherform();
                teacherformop.Show();
                this.Hide();
            }
            
            else if (SubUsertypeCb.Text == "Admin")
            {
                Adminform adminformop = new Adminform();
                adminformop.Show();
                this.Hide();
            }
            
            else
                MessageBox.Show("please select a user type");

            
        }
      

        private void AdminFormlobtn_Click(object sender, EventArgs e)
        {

        }

        private void Closewindowbt_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
