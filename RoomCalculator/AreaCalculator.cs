using System;
using System.Collections.Generic;

namespace RoomCalculator
{
	public class Area_Calculator
	{
        IList<IArea> shapes;

		public Area_Calculator(IList<IArea> shp)
		{
            //shapes = new List<IArea>();
            this.shapes = shp;
		}

		virtual public void AddShape(IArea shp)
		{
			this.shapes.Add(shp);
		}

		virtual public double GetTotalArea()
		{
			double total = 0;

			foreach (IArea s in shapes)
			{
				total += s.CalculateArea();
			}

			return total;
		}
	}
}