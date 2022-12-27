using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Novogodisnja_Windows_forma
{
    internal class korpa
    {
        private int x, y, a;
        public korpa(int x, int y, int a)
        {
            this.x = x;
            this.y = y;
            this.a = a;
        }
        public void crtaj(Graphics g)
        {
            SolidBrush cetka = new SolidBrush(Color.SaddleBrown);
            Pen olovcica = new Pen(Color.Black, 5);
            Point t1 = new Point(x, y);
            Point t2 = new Point(x - a / 8, y - a);
            Point t3 = new Point(x + 2 * a + a / 8, y - a);
            Point t4 = new Point(x + 2 * a, y);
            Point[] niz = { t1, t2, t3, t4 };
            g.FillPolygon(cetka, niz);
            Pen olovka = new Pen(Color.SaddleBrown, 5);
            Point t5 = new Point(x, y - a);
            Point t6 = new Point(x + 2 * a, y - a);
            Point t7 = new Point(x + a / 8, y - a - a / 2);
            Point t8 = new Point(x + 2 * a - a / 8, y - a - a / 2);
            Point[] niz2 = { t5, t6, t7, t8 };
            g.DrawPolygon(olovka, niz2);
        }
    }
}
