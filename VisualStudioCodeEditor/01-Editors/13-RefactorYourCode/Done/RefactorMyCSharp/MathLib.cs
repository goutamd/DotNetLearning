using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefactorMyCSharp
{
  class MathLib
  {
        const double PI = 3.141592;

    double CalculatePaintNeeded(double paintPerUnit, double radius)
		{

			// Extract Method

			double area = CalculateArea(radius);

			return area / paintPerUnit;
		}

		private static double CalculateArea(double radius)
		{
			return GetArea(radius);
		}

		private static double GetArea(double radius)
		{
			return PI * radius * radius;
		}
	}
}
