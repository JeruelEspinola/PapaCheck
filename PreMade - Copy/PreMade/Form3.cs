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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void rbtnAlex_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void UpdateLabel(string text)
        {
            lblblank.Text = text;
        }
    }
}
