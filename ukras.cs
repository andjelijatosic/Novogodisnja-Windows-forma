using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace ukras
{
    internal class ukras
    {
        private int x, y;
        private Color boja;
        public ukras(int x, int y, Color boja)
        {
            this.x = x;
            this.y = y;
            this.boja = boja;
        }
        public void crtaj (Graphics g)
        {
            SolidBrush cetka = new SolidBrush(boja);
            g.FillEllipse(cetka, x, y, 10, 10);
        }
    }
}
