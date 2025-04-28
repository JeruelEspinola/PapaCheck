namespace PreMade
{
    public partial class Form1 : Form
    {
        Color startColor = Color.DarkRed;
        Color endColor = Color.Lime;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 1;
                lbltitle.BackColor = InterpolateColor(startColor, endColor, progressBar1.Value / 100.0);
            }
            else
            {
                timer1.Stop();
                this.Hide();
                new Form2().Show();
            }
            
        }
        private Color InterpolateColor(Color color1, Color color2, double fraction)
        {
            int r = (int)(color1.R + (color2.R - color1.R) * fraction);
            int g = (int)(color1.G + (color2.G - color1.G) * fraction);
            int b = (int)(color1.B + (color2.B - color1.B) * fraction);
            return Color.FromArgb(r, g, b);
        }
    }
}
