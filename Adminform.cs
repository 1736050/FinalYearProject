using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FinalYearProject
{
    public partial class Adminform : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottemRect,
            int nWidthEllipse,
            int nHeightEllipse);
        public Adminform()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0, Width, Height, 25, 25));


            // when form open the panel nav will highlight the side of dash button
            loadformpv(new StudentRegistrationForm());
            Panelnav.Height = Studentdashbtn.Height;
            Panelnav.Top = Studentdashbtn.Top;
            Panelnav.Left = Studentdashbtn.Left;
            Studentdashbtn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void StudentFormlb_Click(object sender, EventArgs e)
        {

        }

        private void AdminFormlo_Click(object sender, EventArgs e)
        {
            SubLogin subLoginlo = new SubLogin();
            subLoginlo.Show();
            this.Hide();

          /*  Use this code to logeout onto the user loginpage instead of sublogin.
           * LoginForm lg = new LoginForm();
            lg.Show();
            this.Hide();
          */
        }

        private void Adminform_Load(object sender, EventArgs e)
        {

        }

        private void Studentdashbtn_Click(object sender, EventArgs e)
        {
            loadformpv(new StudentRegistrationForm());

            // when buttonis clicked panel nav will highlight the side of this button.
            Panelnav.Height = Studentdashbtn.Height;
            Panelnav.Top = Studentdashbtn.Top;
            Panelnav.Left = Studentdashbtn.Left;
            Studentdashbtn.BackColor = Color.FromArgb(46, 51, 73);

           
        }

        private void Teacherdashbtn_Click(object sender, EventArgs e)
        {
            loadformpv(new TeacherRegistrationForm());

            Panelnav.Height = Teacherdashbtn.Height;
            Panelnav.Top = Teacherdashbtn.Top;
            Panelnav.Left = Teacherdashbtn.Left;
            Teacherdashbtn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Feedashbtn_Click(object sender, EventArgs e)
        {
            loadformpv(new FeeForm());
            Panelnav.Height = Feedashbtn.Height;
            Panelnav.Top = Feedashbtn.Top;
            Panelnav.Left = Feedashbtn.Left;
            Feedashbtn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Examdashbtn_Click(object sender, EventArgs e)
        {
            loadformpv(new ExamForm());
            Panelnav.Height = Examdashbtn.Height;
            Panelnav.Top = Examdashbtn.Top;
            Panelnav.Left = Examdashbtn.Left;
            Examdashbtn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Traindashbtn_Click(object sender, EventArgs e)
        {
            loadformpv(new TrainStudentImagesForm());
            Panelnav.Height = Traindashbtn.Height;
            Panelnav.Top = Traindashbtn.Top;
            Panelnav.Left = Traindashbtn.Left;
            Traindashbtn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Attendencedashbtn_Click(object sender, EventArgs e)
        {
            loadformpv(new AttendenceForm());
            Panelnav.Height = Attendencedashbtn.Height;
            Panelnav.Top = Attendencedashbtn.Top;
            Panelnav.Left = Attendencedashbtn.Left;
            Attendencedashbtn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Misdashbtn_Click_1(object sender, EventArgs e)
        {
            loadformpv(new MisForm());

            Panelnav.Height = Misdashbtn.Height;
            Panelnav.Top = Misdashbtn.Top;
            Panelnav.Left = Misdashbtn.Left;
            Misdashbtn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Studentdashbtn_Leave(object sender, EventArgs e)
        {
            // the colour of the button will be same as panel once another button is clicked.
            Studentdashbtn.BackColor = Color.FromArgb(24, 30, 54); 
        }

        private void Teacherdashbtn_Leave(object sender, EventArgs e)
        {
            Teacherdashbtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Feedashbtn_Leave(object sender, EventArgs e)
        {
            Feedashbtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Examdashbtn_Leave(object sender, EventArgs e)
        {
            Examdashbtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Traindashbtn_Leave(object sender, EventArgs e)
        {
            Traindashbtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Attendencedashbtn_Leave(object sender, EventArgs e)
        {
            Attendencedashbtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Misdashbtn_Leave(object sender, EventArgs e)
        {
            Misdashbtn.BackColor = Color.FromArgb(24, 30, 54);
        }


        public void loadformpv (object Form)
        {
            if (this.paneladminmain.Controls.Count > 0)
                this.paneladminmain.Controls.RemoveAt(0);
            Form forminpv = Form as Form;
            forminpv.TopLevel = false;
            forminpv.Dock = DockStyle.Fill;
            this.paneladminmain.Controls.Add(forminpv);
            this.paneladminmain.Tag = forminpv;
            forminpv.Show(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationformop = new RegistrationForm();
            registrationformop.Show();
            
        }
    }
}
