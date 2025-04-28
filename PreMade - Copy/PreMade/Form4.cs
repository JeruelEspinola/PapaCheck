using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreMade
{
    public partial class Form4 : Form
    {
        private Form3 form3;
        public Form4()
        {
            InitializeComponent();
            form3 = new Form3();
            form3.Show();

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string input = txtAlexR.Text;
            if (form3 != null && !form3.IsDisposed)
            {
                form3.UpdateLabel(input);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form5().Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }
    }
}
