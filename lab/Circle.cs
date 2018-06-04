using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    class Circle: Figure
    {
        public int r;
        public Circle(int x, int y, int r) : base(x ,y) {
            this.r = r;
        }
        public override void Draw(System.Drawing.Graphics formgraphics, System.Drawing.Pen pen)
        {
            formgraphics.DrawEllipse(pen, this.x, this.y, this.r*2, this.r*2);

        }
    }
}
