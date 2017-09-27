using System;
namespace RoomCalculator
{
    public class Circle : Shape
    {

        double Radius;

        public Circle(double rad)
        {
            this.Radius = rad;
        }

        override public double CalculateArea() {
            return Math.PI * Math.Pow(this.Radius, 2);
        }

        override public string DescribeYourself()
        {
            return $"I am a circle with as radius {this.Radius}";
        }


    }

}
