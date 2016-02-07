using System;

namespace ProjectEulerInC
{
	public class Problem14
	{
		public Problem14 ()
		{
		}
		public static double GetSolution()
		{
			double solution = 0;
			double numOfChain = 0;
			for(double i=1; i<1000000; i++)
			{
				int iteration = 0;
				var tmpNumOfChain = GetNextNumber (i, ref iteration);
				if (tmpNumOfChain > numOfChain) {
					solution = i;
					numOfChain = tmpNumOfChain;
				}
			}
			return solution;
		}
		private static double GetNextNumber(double number, ref int iteration)
		{
			iteration++;
			if (number == 1)
				return iteration;

			if (number % 2 == 0) {
				GetNextNumber (number / 2, ref iteration);
			} else {
				GetNextNumber (3 * number + 1, ref iteration);
			}
			return iteration;
		}
	}
}

