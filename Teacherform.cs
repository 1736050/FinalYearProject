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
    public partial class Teacherform : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottemRect,
           int nWidthEllipse,
           int nHeightEllipse);
        public Teacherform()
        {
            InitializeComponent();
            loadformpv(new AttendenceForm());
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            Panelnav.Height = Teacherattendencedashbtn.Height;
            Panelnav.Top = Teacherattendencedashbtn.Top;
            Panelnav.Left = Teacherattendencedashbtn.Left;
            Teacherattendencedashbtn.BackColor = Color.FromArgb(46, 51, 73);
        }

       
        private void AdminFormlobtn_Click(object sender, EventArgs e)
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

        private void Teacherattendencedashbtn_Click(object sender, EventArgs e)
        {
            loadformpv(new AttendenceForm());
            Panelnav.Height = Teacherattendencedashbtn.Height;
            Panelnav.Top = Teacherattendencedashbtn.Top;
            Panelnav.Left = Teacherattendencedashbtn.Left;
            Teacherattendencedashbtn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Teacherattendencedashbtn_Leave(object sender, EventArgs e)
        {
            Teacherattendencedashbtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        public void loadformpv(object Form)
        {
            if (this.panelteachermain.Controls.Count > 0)
                this.panelteachermain.Controls.RemoveAt(0);
            Form forminpv = Form as Form;
            forminpv.TopLevel = false;
            forminpv.Dock = DockStyle.Fill;
            this.panelteachermain.Controls.Add(forminpv);
            this.panelteachermain.Tag = forminpv;
            forminpv.Show();
        }
    }
}
