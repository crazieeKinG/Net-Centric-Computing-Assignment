using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    public class ChessBox
    {
        public void Draw(Graphics g, float x, float y, Brush colorName)
        {
            g.FillRectangle(colorName, x, y, Width, Height);
        }

        public float Width { get; set; }

        public float Height { get; set; }
    }
}
