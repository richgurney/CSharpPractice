using System;
using System.Collections.Generic;

namespace RoomCalculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            List<IArea> shapes = new List<IArea>();
           
            Area_Calculator calc = new Area_Calculator(shapes);

            //List<Shape> shapes = new List<Shape>();

            calc.AddShape(new Square(5));
            calc.AddShape(new Square(5));
            calc.AddShape(new Square(5));
            calc.AddShape(new Circle(15));
            calc.AddShape(new Rectangle(5, 10));

            double total = calc.GetTotalArea();

            Console.WriteLine($"Total area: {total}");

            Circle cir = new Circle(10);
            Square sq = new Square(5);

            MainClass.TellMeWhoYouAre(cir);
			MainClass.TellMeWhoYouAre(sq);

		}

        public static void TellMeWhoYouAre(IDescribable thing) {
            Console.Write(thing.DescribeYourself());
        }
    }
}
