using System;

namespace ProjectEulerInC
{
	public class Problem1
	{
		public Problem1 ()
		{
		}
		public static int GetSolution(bool isProdMode)
		{
			int numberBelow = isProdMode ? 1000 : 10;
			int solution = 0;
			for (int i = 0; i < numberBelow; i++) 
			{
				if(i % 3 == 0 || i%5 ==0)
				{
					solution += i;
				}
			}
			return solution;
		}
	}
}