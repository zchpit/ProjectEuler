using System;
using System.Linq;

namespace ProjectEulerInC
{
	public class Problem16
	{
		public Problem16 ()
		{
		}
		public static double GetSolution()
		{
			int numForSolution = 1000;
			double power = 1;
			for (double i = 1; i <= numForSolution; i++)
			{
				power *= 2;
			}
			//var test = DoubleConverter.ToExactString (power);
			var charArray = DoubleConverter.ToExactString (power).ToCharArray ();
			var sumOfDigits = charArray.Sum(a => Char.GetNumericValue(a));

			return sumOfDigits;
		}
	}
}

