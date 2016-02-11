using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Collections;

namespace ProjectEulerInC
{
	public class Problem23
	{
		public Problem23 ()
		{
			
		}
		public static BigInteger GetSolution()
		{
			List<int> abundantNumbers = new List<int> ();
			const int limit = 28123;
			int[] primelist = ESieve((int)Math.Sqrt(limit));

			for (int i = 2; i <= limit; i++)
			{
				if (sumOfFactorsPrime(i, primelist) > i) {
					abundantNumbers.Add(i);
				}
			}
			//List<int> bruteForceSum =  new List<int> (abundantNumbers.Count() * abundantNumbers.Count());
			BitArray SelectedBits = new BitArray(limit, true);
			for (int i = 0; i < abundantNumbers.Count (); i++) {
				for (int j = 0; j < abundantNumbers.Count (); j++) {
					int k = abundantNumbers [i] + abundantNumbers [j];
					if (k < 28123) {
						SelectedBits.Set(k, false);
					}
				}
			}
			//bruteForceSum = bruteForceSum.Distinct ().OrderBy().ToList();
			BigInteger result = 0;
			for (int i = 1; i < 28123; i++) {
				if (SelectedBits.Get(i)) {
					result += i;
				}
			}

			return result;
		}
		private static int sumOfFactorsPrime(int number, int[] primelist) {
			int n = number;
			int sum = 1;
			int p = primelist[0];
			int j;
			int i = 0;

			while (p * p <= n && n > 1 && i < primelist.Length) {
				p = primelist[i];
				i++;
				if (n % p == 0) {
					j = p * p;
					n = n / p;
					while (n % p == 0) {
						j = j * p;
						n = n / p;
					}
					sum = sum * (j - 1) / (p - 1);
				}
			}

			//A prime factor larger than the square root remains
			if (n > 1) {
				sum *= n + 1;
			}
			return sum - number;
		}

		public static int[] ESieve(int upperLimit) {
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

			List<int> numbers = new List<int>((int)(upperLimit / (Math.Log(upperLimit) - 1.08366)));
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

