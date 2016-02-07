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
			double pow20 = 1;
			double pow40 = 1;

			for (double i = 1; i <= 40; i++)
			{
				pow40 *= i;

				if (i == 20)
					pow20 = pow40;
			}

			var solution = pow40 / (pow20 * pow20);
			return solution;
		}
	}
}

