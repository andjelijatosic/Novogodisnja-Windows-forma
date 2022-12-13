using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace novogodisnja
{
    internal class jelka
    {
        private int x, y, a;
        public jelka(int x, int y, int a)
        {
            this.x = x;
            this.y = y;
            this.a = a;
        }
        public void crtaj(Graphics g)
        {
            SolidBrush cetka = new SolidBrush(Color.MediumSpringGreen);
            Point t1 = new Point(x, y);
            Point t2 = new Point(x + a, y - a);
            Point t3 = new Point(x+2*a, y);
            Point[] niz = { t1, t2, t3 };
            g.FillPolygon(cetka, niz);
            Point t4 = new Point(x+a/4, y-a+(3*a)/4);
            Point t5 = new Point(x + a/2, y - a+10-a/2);
            Point t6 = new Point(x+a/4+a/2, y-a+10);
            Point[] niz2 = { t4, t5, t6 };
            g.FillPolygon(cetka, niz2);
            Point t7 = new Point(x+a/8, y-a/2+10);
            Point t8 = new Point(x + a/4, y-a/2+10);
            Point t9 = new Point(x+a/8+a/4, y-a/2+10);
            Point[] niz3 = { t7, t8, t9 };
            g.FillPolygon(cetka, niz3);
        }
    }
}

