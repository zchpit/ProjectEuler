using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace ProjectEulerInC
{
	public class Problem10
	{
		public Problem10 ()
		{
		}
		public static double GetSolution()
		{
			//var primes = GetPrimeFactors (2000000);
			var primes = ESieve (2000000);
			double sumOfPrimes = primes.Sum();
			return sumOfPrimes;
		}
		public static List<int> GetPrimeFactors(int num)
		{
			List<int> allItems = Enumerable.Range (0, num).ToList();
			for(int toCheck = 2; toCheck < num; toCheck++)
			{
				allItems.RemoveAll (j => j != toCheck && j % toCheck == 0);
			}
			return allItems;
		}
		//Solution taken from http://www.mathblog.dk/sum-of-all-primes-below-2000000-problem-10/
		public static double[] ESieve(int upperLimit) {
			int sieveBound = (int)(upperLimit - 1) / 2;
			int upperSqrt = ((int)Math.Sqrt(upperLimit) - 1) / 2;

			BitArray PrimeBits = new BitArray(sieveBound + 1, true);

			for (int i = 1; i <= upperSqrt; i++) {
				if (PrimeBits.Get(i)) {
					for (int j = i * 2 * (i + 1); j <= sieveBound; j += 2 * i + 1) {
						PrimeBits.Set(j, false);
					}
				}
			}

			List<double> numbers = new List<double>((int)(upperLimit / (Math.Log(upperLimit) - 1.08366)));
			numbers.Add(2);

			for (int i = 1; i <= sieveBound; i++) {
				if (PrimeBits.Get(i)) {
					numbers.Add(2 * i + 1);
				}
			}

			return numbers.ToArray();
		}
	}
}