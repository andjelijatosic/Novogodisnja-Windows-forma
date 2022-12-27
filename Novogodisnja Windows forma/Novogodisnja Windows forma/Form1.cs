using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Novogodisnja_Windows_forma;

namespace Novogodisnja_Windows_forma
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
        int x;
        poklon[] Pniz = new poklon[4];

        patuljak patuljak = new patuljak();
        jelka jelkaa = new jelka(70, 200, 90);
        korpa korp = new korpa(20, 0, 0);
        private void Form1_Load(object sender, EventArgs e)
        {
            boja1 = Color.FromArgb(r.Next(256), r.Next(0), r.Next(0));
            boja2 = Color.FromArgb(r.Next(0), r.Next(240), r.Next(0));
            timer1.Enabled = true;
            timer1.Interval = 500;
            for (int br = 0; br < n; br++)
            {
                polozaj = new Point(r.Next(a, ClientRectangle.Width - a), 0);
                poklon p = new poklon(polozaj, a, boja1, boja2);
                Pniz[br] = p;
            }
            patuljak.Setsve(50, 100, new Point(ClientRectangle.Width-100, ClientRectangle.Height-100));
            jelkaa = new jelka(70, ClientRectangle.Height - 30, 70);
            korp = new korpa(x, ClientRectangle.Height - 10, 30);
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

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = CreateGraphics();
            for (int br = 0; br < n; br++)
            {
                Pniz[br].Crtaj(g);
            }
            patuljak.nacrtaj(g);
            jelkaa.crtaj(g);
            korp.crtaj(g);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            x = e.X;
        }
    }
}
