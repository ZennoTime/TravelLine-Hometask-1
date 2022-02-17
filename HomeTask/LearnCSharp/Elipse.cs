using System;

namespace LearnCSharp
{
    public class Elipse
    {
        public double HorizontalRadius { get; private set; }
        public double VerticalRadius { get; private set; }

        public Elipse(Point leftTopPoint, Point rightBottomPoint)
        {  
            HorizontalRadius = (rightBottomPoint.X - leftTopPoint.X) / 2;
            VerticalRadius = (leftTopPoint.Y - rightBottomPoint.Y) / 2;
            if (HorizontalRadius <= 0)
            {
                throw new ArgumentException(
                    "Горизонтальный радиус должен быть больше нуля"
                );
            }
            if (VerticalRadius <= 0)
            {
                throw new ArgumentException(
                    "Вертикальный радиус должен быть больше нуля"
                );
            }
        }
        public double GetPerimeter()
        {
            return  2 * Math.PI * Math.Sqrt(((Math.Pow(HorizontalRadius, 2)) + (Math.Pow(VerticalRadius, 2))) / 2);
        }
        public double GetSquare()
        {
            return HorizontalRadius * VerticalRadius * Math.PI; 
        }
    }
}
