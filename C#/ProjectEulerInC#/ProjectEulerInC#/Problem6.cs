using System;

namespace ProjectEulerInC
{
	public class Problem6
	{
		public Problem6 ()
		{
		}
		public static int GetSolution()
		{
			int sumOfSquare = 0;
			int squareOfSum = 0;

			for (int i = 1; i <= 100; i++) {
				int square = i * i;
				sumOfSquare += square;
				squareOfSum += i;
			}
			squareOfSum = squareOfSum * squareOfSum;

			int solution = squareOfSum - sumOfSquare;
			return solution;
		}
	}
}

