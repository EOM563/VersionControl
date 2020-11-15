using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using week08.Abstractions;

namespace week08.Entities
{
    public class Present : Toy
    {
        public SolidBrush RibbonColor { get; private set; }
        public SolidBrush BoxColor { get; private set; }
        public Present(Color rColor, Color bColor)
        {
            RibbonColor = new SolidBrush(rColor);
            BoxColor = new SolidBrush(bColor);
        }
        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(BoxColor, 0, 0, Width, Height);
            g.FillRectangle(RibbonColor, 19, 0, Width/4, Height);
            g.FillRectangle(RibbonColor, 0, 19, Width, Height/4);
        }
    }
}
