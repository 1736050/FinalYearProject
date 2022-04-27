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
    public partial class Studentform : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottemRect,
            int nWidthEllipse,
            int nHeightEllipse);
        public Studentform()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            Panelnav.Height = Studentattendencedashbtn.Height;
            Panelnav.Top = Studentattendencedashbtn.Top;
            Panelnav.Left = Studentattendencedashbtn.Left;
            Studentattendencedashbtn.BackColor = Color.FromArgb(46, 51, 73);
        }

        
        private void Studentattendencedashbtn_Click(object sender, EventArgs e)
        {
            Panelnav.Height = Studentattendencedashbtn.Height;
            Panelnav.Top = Studentattendencedashbtn.Top;
            Panelnav.Left = Studentattendencedashbtn.Left;
            Studentattendencedashbtn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Studentattendencedashbtn_Leave(object sender, EventArgs e)
        {
            Studentattendencedashbtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void StudentFormlobtn_Click(object sender, EventArgs e)
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
    }
}
