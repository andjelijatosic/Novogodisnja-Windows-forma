using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace WindowsFormsApp1
{
    internal class poklon
    {
        private Point centar;
        private int a;
        private Color boja_omotaca;
        private Color boja_trake;

        public poklon(Point centar, int a, Color boja_omotaca, Color boja_trake)
        {
            this.centar = centar;
            this.a = a;
            this.boja_omotaca = boja_omotaca;
            this.boja_omotaca = boja_trake;
        }
        public poklon()
        {
            centar  new Point(0,0)
        }

        public void Crtaj(Graphics g)
        {
            Pen olovka = new Pen(Color.Black);

            Point t1 = new Point(centar.X - 3 * a / 2, centar.Y + 2 * a);
            Point t2 = new Point(centar.X + 3 * a / 2, centar.Y + 2 * a);
            Point t3 = new Point(centar.X - 3 * a / 2, centar.Y); 
            Point t4 = new Point(centar.X + 3 * a / 2, centar.Y);

            Point[] niz1 = { t1, t2, t3, t4 };
            g.FillPollygon(olovka, niz1);
        }


    }
}
