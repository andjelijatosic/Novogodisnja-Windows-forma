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
        public void crtaj (Graphics g)
        {
            SolidBrush cetka = new SolidBrush(Color.MediumSpringGreen);
            Point t1 = new Point(x, y);
            Point t2 = new Point(x + a, y - a);
        }
    }
}
