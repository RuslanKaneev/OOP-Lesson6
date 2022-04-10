using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson6_2
{
    internal class Circle : Point
    {
        public double RadiusCircle { get; set; }

        public double calculatingAreaCircle()
        {

            return Math.Pow(RadiusCircle, 2) * Math.PI;

        }
        public Circle(int x, int y, double radius) : base(x, y) 
        { 
        
            RadiusCircle = radius;
        
        }
        public override string ToString()
        {
            return base.ToString() + "Радиус: " + RadiusCircle + " Площадь: " + calculatingAreaCircle();
        }


        public override Point MoveFigure(int x, int y)
        {
            return base.MoveFigure(x, y);
        }
    }
}
