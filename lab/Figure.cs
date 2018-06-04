using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    abstract class Figure
    {
        public int x;
        public int y;

        public Figure(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        abstract public void Draw(System.Drawing.Graphics formgraphics, System.Drawing.Pen pen);
    }
}
