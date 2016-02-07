using System;
using System.Linq;
using System.Numerics;

namespace ProjectEulerInC
{
	public class Problem20
	{
		public Problem20 ()
		{
		}
		public static double GetSolution()
		{
			int num = 100;
			BigInteger factorial = 1;
			for (BigInteger i = 1; i <= num; i++)
			{
				factorial *= i;
			}
			string factString = factorial.ToString ();
			var solution = factString.ToCharArray ().Sum (a => Char.GetNumericValue (a));
			return solution;
		}
	}
}

