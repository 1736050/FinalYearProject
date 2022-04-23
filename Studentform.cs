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
    public partial class Studentform : Form
    {
        public Studentform()
        {
            InitializeComponent();
        }

        private void StudentFormlo_Click(object sender, EventArgs e)
        {
            SubLogin subLoginlo = new SubLogin();
            subLoginlo.Show();
            this.Hide();
        }

        private void CloseWindowbt2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
