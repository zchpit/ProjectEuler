using System;

namespace ProjectEulerInC
{
	public class Problem15
	{
		public Problem15 ()
		{
		}
		//Fatorial formula
		public static double GetSolution()
		{
			double fact20 = 1;
			double fact40 = 1;

			for (double i = 1; i <= 40; i++)
			{
				fact40 *= i;

				if (i == 20)
					fact20 = fact40;
			}

			var solution = fact40 / (fact20 * fact20);
			return solution;
		}
	}
}

