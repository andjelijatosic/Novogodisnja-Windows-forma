using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using poklon;

namespace poklon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        poklon p;
        Color boja1;
        Color boja2;
        Random r = new Random();
        Point polozaj;
        int a = 50;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 500;
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            boja1 = Color.FromArgb(r.Next(256), r.Next(0), r.Next(0));
            boja2 = Color.FromArgb(r.Next(0), r.Next(240), r.Next(0));
            Graphics g = CreateGraphics();
            polozaj = new Point(r.Next(a, ClientRectangle.Width - a), r.Next(a, ClientRectangle.Height - a));
            p = new poklon(polozaj, a , boja1, boja2);
            p.Crtaj(g);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
