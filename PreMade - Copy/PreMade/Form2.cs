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
    public partial class Form2 : Form
    {
        List<Color> colorPalette = new List<Color>
        {
            Color.Red,
            Color.Orange,
            Color.Yellow,
            Color.Green,
            Color.Blue,
            Color.Indigo,
            Color.Violet
        };

        int currentIndex = 0;
        double progress = 0.0;
        double fadeSpeed = 0.01;
        public Form2()
        {
            InitializeComponent();
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Color fromColor = colorPalette[currentIndex];
            Color toColor = colorPalette[(currentIndex + 1) % colorPalette.Count];
            this.BackColor = InterpolateColor(fromColor, toColor, progress);
            progress += fadeSpeed;

            if (progress >= 1.0)
            {
                progress = 0.0;
                currentIndex = (currentIndex + 1) % colorPalette.Count;
            }
        }
        private Color InterpolateColor(Color color1, Color color2, double fraction)
        {
            int r = (int)(color1.R + (color2.R - color1.R) * fraction);
            int g = (int)(color1.G + (color2.G - color1.G) * fraction);
            int b = (int)(color1.B + (color2.B - color1.B) * fraction);
            return Color.FromArgb(r, g, b);
        }

        private void btnGradeChecker_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form3().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form5().Show();
        }
    }
}
