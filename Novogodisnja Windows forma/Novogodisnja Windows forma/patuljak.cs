using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Novogodisnja_Windows_forma
{
    internal class patuljak
    {
        private int w;
        private int h;
        private Point a;

        public void Setsve(int W, int H, Point A)
        {
            w = W;
            h = H;
            a = A;

        }
        public void nacrtaj(Graphics g)
        {
            Pen olibi = new Pen(Color.Black);
            SolidBrush debeliolibi = new SolidBrush(Color.Green);
            SolidBrush koza = new SolidBrush(Color.Beige);
            /* Torso */
            Point a1 = new Point(a.X - w / 2, a.Y + h / 2);
            Point a2 = new Point(a.X - w / 2, a.Y - h / 2);
            Point a3 = new Point(a.X + w / 2, a.Y - h / 2);
            Point a4 = new Point(a.X + w / 2, a.Y + h / 2);
            Point[] torso = { a1, a2, a3, a4 };
            g.FillPolygon(debeliolibi, torso);
            g.DrawPolygon(olibi, torso);
            /* Leva Noga */
            Point b1 = new Point(a.X - w / 2, a.Y + h / 2);
            Point b2 = new Point(a.X - w / 6, a.Y + h / 2);
            Point b3 = new Point(a.X - w / 2, a.Y + (h / 3) * 2);
            Point b4 = new Point(a.X - w / 6, a.Y + (h / 3) * 2);
            Point b5 = new Point(a.X - w / 2, a.Y + h);
            Point b6 = new Point(a.X - w / 6, a.Y + h);
            Point[] levanoga1 = { b1, b2, b4, b3 };
            Point[] levanoga2 = { b4, b3, b5, b6 };
            g.FillPolygon(debeliolibi, levanoga1);
            g.FillPolygon(debeliolibi, levanoga2);
            g.DrawPolygon(olibi, levanoga1);
            g.DrawPolygon(olibi, levanoga2);
            /* Desna Noga */
            Point c1 = new Point(a.X + w / 2, a.Y + h / 2);
            Point c2 = new Point(a.X + w / 6, a.Y + h / 2);
            Point c3 = new Point(a.X + w / 2, a.Y + (h / 3) * 2);
            Point c4 = new Point(a.X + w / 6, a.Y + (h / 3) * 2);
            Point c5 = new Point(a.X + w / 2, a.Y + h);
            Point c6 = new Point(a.X + w / 6, a.Y + h);
            Point[] desnanoga1 = { c1, c2, c4, c3 };
            Point[] desnanoga2 = { c4, c3, c5, c6 };
            g.FillPolygon(debeliolibi, desnanoga1);
            g.FillPolygon(debeliolibi, desnanoga2);
            g.DrawPolygon(olibi, desnanoga1);
            g.DrawPolygon(olibi, desnanoga2);
            /* Leva Ruka */
            Point d1 = new Point(a.X - w / 2, a.Y - h / 2);
            Point d2 = new Point(a.X - w / 2, a.Y - h / 3);
            Point d3 = new Point(a.X - w - w / 3, a.Y - h / 3);
            Point d4 = new Point(a.X - w - w / 3, a.Y - h / 6);
            Point d5 = new Point(a.X - w / 2, a.Y - h / 6);
            Point d6 = new Point(a.X - w / 2, a.Y);
            Point[] levaruka1 = { d1, d2, d4, d3 };
            Point[] levaruka2 = { d4, d3, d5, d6 };
            g.FillPolygon(debeliolibi, levaruka1);
            g.FillPolygon(koza, levaruka2);
            g.DrawPolygon(olibi, levaruka1);
            g.DrawPolygon(olibi, levaruka2);
            g.FillPolygon(debeliolibi, levaruka1);
            /* Desna Ruka */
            Point e1 = new Point(a.X + w / 2, a.Y - h / 2);
            Point e2 = new Point(a.X + w / 2, a.Y - h / 3);
            Point e3 = new Point(a.X + w + w / 3, a.Y - h / 3);
            Point e4 = new Point(a.X + w + w / 3, a.Y - h / 6);
            Point e5 = new Point(a.X + w / 2, a.Y - h / 6);
            Point e6 = new Point(a.X + w / 2, a.Y);
            Point[] desnaruka1 = { e1, e2, e4, e3 };
            Point[] desnaruka2 = { e4, e3, e5, e6 };
            g.FillPolygon(koza, desnaruka2);
            g.FillPolygon(debeliolibi, desnaruka1);
            g.DrawPolygon(olibi, desnaruka1);
            g.DrawPolygon(olibi, desnaruka2);
            g.FillPolygon(debeliolibi, desnaruka1);

            /* Glava */
            Point f1 = new Point(a.X - (w / 2 + w / 4) / 2, a.Y - h / 2 - w / 2 - w / 4);
            g.FillEllipse(koza, f1.X, f1.Y, w / 2 + w / 4, w / 2 + w / 4);
            g.DrawEllipse(olibi, f1.X, f1.Y, w / 2 + w / 4, w / 2 + w / 4);
            /* Kapa */
            Point g1 = new Point(a.X - w / 2, a.Y - h / 2 - w / 2);
            Point g2 = new Point(a.X - w / 2, a.Y - h / 2 - w / 2 - h / 8);
            Point g3 = new Point(a.X + w / 2, a.Y - h / 2 - w / 2);
            Point g4 = new Point(a.X + w / 2, a.Y - h / 2 - w / 2 - h / 8);
            Point g5 = new Point(a.X - w / 2 + w / 8, a.Y - h / 2 - w / 2 - h / 8);
            Point g6 = new Point(a.X + w / 2 - w / 8, a.Y - h / 2 - w / 2 - h / 8);
            Point g7 = new Point(a.X, a.Y - h / 2 - h / 4 - w / 2 - h / 8);
            Point[] DonjiDeoKape = { g1, g2, g4, g3 };
            Point[] GornjiDeoKape = { g5, g6, g7 };
            g.FillPolygon(debeliolibi, DonjiDeoKape);
            g.FillPolygon(debeliolibi, GornjiDeoKape);
            g.DrawPolygon(olibi, GornjiDeoKape);
            g.DrawPolygon(olibi, DonjiDeoKape);
        }
    }
}
