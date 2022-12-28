using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bezi_od_poklona;
namespace bezi_od_poklona
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
        int ipsilon;
        poklon[] Pniz = new poklon[4];
        bool goleft;
        bool goright;

        patuljak patuljak = new patuljak();
        jelka jelkaa = new jelka(70, 50, 90);
        private void Form1_Load(object sender, EventArgs e)
        {
            boja1 = Color.FromArgb(r.Next(256), r.Next(0), r.Next(0));
            boja2 = Color.FromArgb(r.Next(0), r.Next(240), r.Next(0));
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer2.Enabled = true;
            timer2.Interval = 500;
            for (int br = 0; br < n; br++)
            {
                polozaj = new Point(r.Next(a, ClientRectangle.Width - a), 0);
                poklon p = new poklon(polozaj, a, boja1, boja2);
                Pniz[br] = p;
            }
            Graphics g = CreateGraphics();
            jelkaa = new jelka(70, ClientRectangle.Height - 30, 170);
            jelkaa.crtaj(g);
            patuljak.Setsve(50, 100, new Point(200, ClientRectangle.Height - 100));

        }
        int m=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            ipsilon = ClientRectangle.Height - 100;
            Graphics g = CreateGraphics();
            for (int br = 0; br < n; br++)
            {
                poklon p = new poklon();            
                Pniz[br].smanjiY(50);
                Pniz[br].Crtaj(g);

                p = Pniz[br];
                if (p.getPolozaj().Y > ClientRectangle.Height)
                {
                    Pniz[br].smanjiY(-ClientRectangle.Height);        
                }
                if ((p.getPolozaj().X > iks -70  && p.getPolozaj().X < iks + 70) && (p.getPolozaj().Y > ipsilon-100  && p.getPolozaj().Y < ipsilon + 100))
                {
                    m = 1;
                    MessageBox.Show("SKUPIO SI POKLON, BRAVO");
                }
                if (m!=0)
                {
                    Close();
                }
            
                Refresh();
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


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            
        }
        int iks = 200;
        private void timer2_Tick(object sender, EventArgs e)
        {
            ipsilon = ClientRectangle.Height - 100;
            if (goleft == true)
            {
                iks -= 40;
            }
            else if (goright == true)
            {
                iks += 40;
            }
            patuljak.Setsve(50, 100, new Point(iks,ClientRectangle.Height - 100));
            Graphics g = CreateGraphics();
            patuljak.nacrtaj(g);

        }
    }
}
