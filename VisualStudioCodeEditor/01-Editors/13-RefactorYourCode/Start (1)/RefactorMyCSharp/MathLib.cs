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

        double area = PI * radius * radius;

        return area / paintPerUnit;
    }

  }
}
