using Microsoft.VisualBasic;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "samplemail@gmail.com" && txtPassword.Text == "12345678")
            {
                this.Hide();
                new Form3().Show();
                new Form4().Show();
            }
            else
            {
                MessageBox.Show("Incorrect Email or Password. Please try again.");
            }
        }
    }
}
