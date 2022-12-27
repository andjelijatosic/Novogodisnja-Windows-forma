using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Novogodisnja_Windows_forma
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
            this.boja_trake = boja_trake;
        }
        public poklon()
        {
            centar = new Point(0, 0);
        }
        public Point getPolozaj()
        {
            return centar;
        }
        public void Crtaj(Graphics g)
        {
            SolidBrush cetkica1 = new SolidBrush(boja_omotaca);
            SolidBrush cetkica2 = new SolidBrush(boja_trake);
            Pen crna = new Pen(Color.Black, 3);
            SolidBrush trakica = new SolidBrush(boja_trake);
            //crtanje pocetnog kradrata

            Point t1 = new Point(centar.X - 3 * a / 2, centar.Y + 2 * a);
            Point t2 = new Point(centar.X + 3 * a / 2, centar.Y + 2 * a);
            Point t3 = new Point(centar.X - 3 * a / 2, centar.Y);
            Point t4 = new Point(centar.X + 3 * a / 2, centar.Y);

            Point[] niz1 = { t1, t2, t4, t3 };
            g.DrawPolygon(crna, niz1);
            g.FillPolygon(cetkica1, niz1);


            //crtanje poklopca 
            Point t5 = new Point(centar.X - 3 * a / 2 - 8, centar.Y - a);
            Point t6 = new Point(centar.X + 3 * a / 2 + 8, centar.Y - a);
            Point t7 = new Point(centar.X - 3 * a / 2 - 8, centar.Y);
            Point t8 = new Point(centar.X + 3 * a / 2 + 8, centar.Y);

            Point[] niz2 = { t5, t6, t8, t7 };
            g.FillPolygon(cetkica1, niz2);
            g.DrawPolygon(crna, niz2);

            //crtanje trake 
            Point t9 = new Point(centar.X - a / 2, centar.Y - a);
            Point t10 = new Point(centar.X + a / 2, centar.Y - a);
            Point t11 = new Point(centar.X - a / 2, centar.Y + 2 * a);
            Point t12 = new Point(centar.X + a / 2, centar.Y + 2 * a);

            Point[] niz3 = { t9, t10, t12, t11 };
            g.FillPolygon(cetkica2, niz3);
            g.DrawPolygon(crna, niz3);

            //crtanje masnice
            g.FillEllipse(trakica, centar.X - a - 11, centar.Y - 3 * a / 2, 3 * a / 2, a / 2);
            g.FillEllipse(trakica, centar.X - a / 2 + 11, centar.Y - 3 * a / 2, 3 * a / 2, a / 2);
            g.DrawEllipse(crna, centar.X - a - 11, centar.Y - 3 * a / 2, 3 * a / 2, a / 2);
            g.DrawEllipse(crna, centar.X - a / 2 + 11, centar.Y - 3 * a / 2, 3 * a / 2, a / 2);
        }
        public void smanjiY(int d)
        {
            int x = centar.X;
            int y = centar.Y + d;
            Point p = new Point(x, y);
            centar = p;
        }
    }
}
