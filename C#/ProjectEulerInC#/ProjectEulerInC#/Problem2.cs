using System;

namespace ProjectEulerInC
{
	public class Problem2
	{
		public Problem2 ()
		{
		}
		public static int GetSolution(bool isProductionMode)
		{
			int numberBelow = isProductionMode ? 4000000 : 90;
			int solution = 2;
			int currentNumber = 2;
			int prevNumber = 1;
			int nextNumber = 0;

			while (currentNumber < numberBelow) {
				nextNumber = GetNextNumber (currentNumber, prevNumber);
				if (nextNumber % 2 == 0) {
					solution += nextNumber;
				}
				prevNumber = currentNumber;
				currentNumber = nextNumber;
			}
			return solution;
		}
		public static int GetNextNumber(int currentNumber, int previusNumber)
		{
			/*if (currentNumber <= 2)
				return 1;
			else*/
				return currentNumber + previusNumber;
		}
	}
}

