namespace Lab2_22520098_2._4_2._6
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int x = random.Next(0, this.ClientSize.Width);
            int y = random.Next(0, this.ClientSize.Height);

            g.DrawString("Paint Event", new Font("Arial", 12), Brushes.Black, x, y);
        }
    }
}