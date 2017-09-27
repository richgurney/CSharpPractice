using System;
namespace RoomCalculator
{
    
    public class Rectangle : Shape
    {
        double width;
        public double Width
        {
            get {
                return width;
            }
            set {
                width = value;
            }
        }
        double height;
        public double Height { 
            get {
                return height;
            }
            set {
                width = value;
            } 
        }

        public Rectangle(double w, double h)
        {
            Width = w;
            Height = h;
        }

        override public double CalculateArea()
        {
            return this.width * this.height;
        }

        override public string DescribeYourself()
        {
            return $"I am a rectangle with {this.width} {this.width}";
        }

        //virtual public double GetWidth() {
        //    return this._width;
        //}

        //virtual public void SetWidth(double w) {
        //    this._width = w;
        //}
    }
}
