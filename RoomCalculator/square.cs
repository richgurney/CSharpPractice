using System;
namespace RoomCalculator
{
    public class Square : Rectangle
    {
        
        public Square(double sl) : base(sl, sl)
        {

        }


		override public string DescribeYourself()
		{
            return $"I am a sqaure with a sidelength {this.Width}";
		}
    }
}
