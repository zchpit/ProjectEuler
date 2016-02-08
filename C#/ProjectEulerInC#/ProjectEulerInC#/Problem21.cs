using System;
using System.Collections.Generic;

namespace ProjectEulerInC
{
	public class Problem21
	{
		public Problem21 ()
		{
			
		}
		public static double GetSolution()
		{
			List<int> amicableNumbers = new List<int> ();
			int s1, s2;
			for (int i = 0; i < 10000; i++)
			{
				s1 = FastSum(i);
				s2 = (s1 > i) ? FastSum(s1) : 0;
				if (s2 == i) {
					amicableNumbers.Add (s1);
					amicableNumbers.Add (s2);
				}
			}
			double sumOfAmicableNumbers = 0;
			foreach (int i in amicableNumbers) {
				sumOfAmicableNumbers += i;
			}
			return sumOfAmicableNumbers;
		}
		public static int FastSum(int n)
		{
			int sum = 1;
			int sqrt = (int)Math.Sqrt(n);
			for (int i = 2; i <= 1 + sqrt; i++)
				if (n % i == 0) sum = sum + i + n / i;
			return sum;
		}
	}
}

