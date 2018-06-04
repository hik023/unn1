using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    class Rect: Figure
    {
        public int width;
        public int height;
        public Rect(int x, int y, int width, int height) : base(x ,y) {
            this.width = width;
            this.height = height;
        }
        public override void Draw(System.Drawing.Graphics formgraphics, System.Drawing.Pen pen)
        {
            formgraphics.DrawRectangle(pen, this.x, this.y, this.width, this.height);
        }
    }
}
