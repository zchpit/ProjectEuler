using System;
using System.Linq;
using System.Collections.Generic;

namespace ProjectEulerInC
{
	public class Problem7
	{
		public Problem7 ()
		{
		}
		public static int GetSolution()
		{
			var primes = GetPrimeFactors (150000);
			return primes [10000];
		}
		public static List<int> GetPrimeFactors(int num)
		{
			List<int> allItems = Enumerable.Range(2,num).ToList();
			for(int toCheck = 2; toCheck < num; toCheck++)
			{
				allItems.RemoveAll (j => j != toCheck && j % toCheck == 0);
			}
			return allItems;
		}
	}
}