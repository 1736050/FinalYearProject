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
        }

        private void Teacherattendencedashbtn_Click(object sender, EventArgs e)
        {
            Panelnav.Height = Teacherattendencedashbtn.Height;
            Panelnav.Top = Teacherattendencedashbtn.Top;
            Panelnav.Left = Teacherattendencedashbtn.Left;
            Teacherattendencedashbtn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Teacherattendencedashbtn_Leave(object sender, EventArgs e)
        {
            Teacherattendencedashbtn.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
