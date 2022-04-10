using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_2
{
    internal class Point : Figure
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override Point MoveFigure(int x,int y)
            
        {  var koordinataPoint = new Point(x,y);
            X += x;
            Y += y;
            return koordinataPoint;
        }

 

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return base.ToString() + "Координаты: "+ X + " , " + Y;

        }

    }
}
