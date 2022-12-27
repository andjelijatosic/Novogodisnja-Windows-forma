using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Novogodisnja_Windows_forma
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
            SolidBrush cetka = new SolidBrush(Color.ForestGreen);
            Point t1 = new Point(x, y);
            Point t2 = new Point(x + a, y - a);
            Point t3 = new Point(x + 2 * a, y);
            Point[] niz = { t1, t2, t3 };
            g.FillPolygon(cetka, niz);
            Point t4 = new Point(x + a / 2, y - a + a / 4);
            Point t5 = new Point(x + a, y - a - a / 2 + a / 4);
            Point t6 = new Point(x + a / 2 + a, y - a + a / 4);
            Point[] niz2 = { t4, t5, t6 };
            g.FillPolygon(cetka, niz2);
            Point t7 = new Point(x + a / 2 + a / 4, y - a - a / 2 + a / 4 + a / 8);
            Point t8 = new Point(x + a, y - a - a / 2 - a / 4 + a / 4 + a / 8);
            Point t9 = new Point(x + a + a / 4, y - a - a / 2 + a / 4 + a / 8);
            Point[] niz3 = { t7, t8, t9 };
            g.FillPolygon(cetka, niz3);
            SolidBrush cetkica = new SolidBrush(Color.Brown);
            g.FillRectangle(cetkica, x + a - a / 8, y, a / 4, a / 4);
        }
        public bool SadrziTacku(Point m)
        {
            Point t1 = new Point(x, y);
            Point t2 = new Point(x + a, y - a);
            Point t3 = new Point(x + 2 * a, y);
            Point d1 = new Point(t1.X - m.X, t1.Y - m.Y);
            Point d2 = new Point(t2.X - m.X, t2.Y - m.Y);
            Point d3 = new Point(t3.X - m.X, t3.Y - m.Y);
            Point n1 = new Point(t3.X - t1.X, t3.Y - t1.Y);
            Point n2 = new Point(t2.X - t1.X, t2.Y - t1.Y);
            int povrsina;
            int p;
            povrsina = Math.Abs(n1.X * n2.X - n1.Y * n2.Y);
            p = Math.Abs(d1.X * d2.Y - d1.Y * d2.X) + Math.Abs(d2.X * d3.Y - d2.Y * d3.X) + Math.Abs(d3.X * d1.Y - d3.Y * d1.X);
            return p == povrsina;
            Point t4 = new Point(x + a / 2, y - a + a / 4);
            Point t5 = new Point(x + a, y - a - a / 2 + a / 4);
            Point t6 = new Point(x + a / 2 + a, y - a + a / 4);
            Point d4 = new Point(t4.X - m.X, t4.Y - m.Y);
            Point d5 = new Point(t5.X - m.X, t5.Y - m.Y);
            Point d6 = new Point(t6.X - m.X, t6.Y - m.Y);
            Point n3 = new Point(t6.X - t4.X, t6.Y - t4.Y);
            Point n4 = new Point(t5.X - t4.X, t5.Y - t4.Y);
            int povrsina2;
            int p2;
            povrsina2 = Math.Abs(n3.X * n4.X - n3.Y * n4.Y);
            p2 = Math.Abs(d4.X * d5.Y - d4.Y * d5.X) + Math.Abs(d5.X * d6.Y - d5.Y * d6.X) + Math.Abs(d6.X * d4.Y - d6.Y * d4.X);
            return p2 == povrsina2;
            Point t7 = new Point(x + a / 2 + a / 4, y - a - a / 2 + a / 4 + a / 8);
            Point t8 = new Point(x + a, y - a - a / 2 - a / 4 + a / 4 + a / 8);
            Point t9 = new Point(x + a + a / 4, y - a - a / 2 + a / 4 + a / 8);
            Point d7 = new Point(t7.X - m.X, t7.Y - m.Y);
            Point d8 = new Point(t8.X - m.X, t8.Y - m.Y);
            Point d9 = new Point(t9.X - m.X, t9.Y - m.Y);
            Point n5 = new Point(t9.X - t7.X, t9.Y - t7.Y);
            Point n6 = new Point(t8.X - t7.X, t8.Y - t7.Y);
            int povrsina3;
            int p3;
            povrsina3 = Math.Abs(n5.X * n6.X - n5.Y * n6.Y);
            p3 = Math.Abs(d7.X * d8.Y - d7.Y * d8.X) + Math.Abs(d8.X * d9.Y - d8.Y * d9.X) + Math.Abs(d9.X * d7.Y - d9.Y * d7.X);
            return p3 == povrsina3;
        }
    }
}
