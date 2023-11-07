using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_2._4
{
    public partial class PaintEventExample : Form
    {
        private Random random = new Random();
        public PaintEventExample()
        {
            InitializeComponent();
            this.Click += new EventHandler(PaintEventExample_Click);
            this.Paint += new PaintEventHandler(PaintEventExample_Paint);
        }

        private void PaintEventExample_Paint(object sender, PaintEventArgs e)
        {
            
                Graphics g = e.Graphics;
                int x = random.Next(0, this.Height - 100);
                int y = random.Next(0, this.Width - 100);
                Brush brush = new SolidBrush(Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255))==Color.White? Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)) : Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)));
                g.DrawString("Paint Event!", new Font("Arial", 12), brush, x, y);
            
        }

        private void PaintEventExample_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
