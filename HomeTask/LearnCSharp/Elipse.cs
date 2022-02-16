using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    public class Elipse
    {
        public Point LeftTopPoint { get; private set; }
        public Point RightBottomPoint { get; private set; }
        public double Horizontal { get; private set; }
        public double Vertical { get; private set; }

        public Elipse(Point lefttopPoint, Point rightbottomPoint)
        {  
            LeftTopPoint = lefttopPoint;
            RightBottomPoint = rightbottomPoint;
            Horizontal = (RightBottomPoint.X - LeftTopPoint.X) / 2;
            Vertical = (LeftTopPoint.Y - RightBottomPoint.Y) / 2;
            if (Horizontal < 0)
            {
                throw new ArgumentException(
                    "Горизонтальный радиус должен быть больше нуля"
                );
            }
            if ( Vertical < 0)
            {
                throw new ArgumentException(
                    "Вертикальный радиус должен быть больше нуля"
                );
            }
        }
        public double GetPerimeter()
        {
            double Perimeter = 2 * Math.PI * Math.Sqrt(((Math.Pow(Horizontal, 2)) + (Math.Pow(Vertical, 2))) / 2);
            return (Perimeter);
        }
        public double GetSquare()
        {
            double Square = Horizontal * Vertical * Math.PI;
            return (Square); 
        }
    }
}
