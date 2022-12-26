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
        Color boja1;
        Color boja2;
        Random r = new Random();
        Point polozaj;
        int a = 30;
        int n = 4;
        poklon[] Pniz = new poklon[4];
        private void Form1_Load(object sender, EventArgs e)
        {
            boja1 = Color.FromArgb(r.Next(256), r.Next(0), r.Next(0));
            boja2 = Color.FromArgb(r.Next(0), r.Next(240), r.Next(0));
            timer1.Enabled = true;
            timer1.Interval = 500;
            for (int br = 0; br < n; br++)
            {
                polozaj = new Point( r.Next(a, ClientRectangle.Width - a), 0);
                poklon p = new poklon(polozaj, a, boja1, boja2);
                Pniz[br] = p;

            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = CreateGraphics();
            for (int br = 0; br < n; br++)
            {
                Pniz[br].Crtaj(g);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            for (int br = 0; br < n; br++)
            {
                poklon p = new poklon();
                p = Pniz[br];
                Pniz[br].smanjiY(50);
                Pniz[br].Crtaj(g);
                Refresh();
                if (p.getPolozaj().Y > ClientRectangle.Height)
                {
                    Pniz[br].smanjiY(-ClientRectangle.Height);
                   
                }
            }

        }
    }
}
