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
    public partial class Adminform : Form
    {
        public Adminform()
        {
            InitializeComponent();
        }

        private void StudentFormlb_Click(object sender, EventArgs e)
        {

        }

        private void StudentFormlo_Click(object sender, EventArgs e)
        {
            SubLogin subLoginlo = new SubLogin();
            subLoginlo.Show();
            this.Hide();
        }

        private void closebt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
