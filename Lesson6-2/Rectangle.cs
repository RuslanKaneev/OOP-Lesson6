using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_2
{
    internal class Rectangle : Point

    { 
        public int Leight {get; set; }
        public int Height { get; set; }

        public Rectangle(int x, int y, int leight, int height) : base(x,y)
        {
            var x1y1 = new Point(X, Y);
            var x1y2 = new Point(X, Y + height);
            var x2y1 = new Point(X + leight, Y);
            var x2y2 = new Point(X + leight, Y + height);
            
        }

        public double SquareArea(int leight, int height)
        {
            return leight * height;
        }
        public override Point MoveFigure(int x, int y)
        {
            return base.MoveFigure(x, y);
        }
        public override string ToString()
        {
            return base.ToString()+ "Длина: "+ Leight+ " Ширина: " + Height + " Площадь: " + SquareArea(Leight, Height);
        }

    }
}
