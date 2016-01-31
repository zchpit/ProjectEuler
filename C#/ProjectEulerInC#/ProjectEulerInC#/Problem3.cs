using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Timers;
using System.Diagnostics;

namespace ProjectEulerInC
{
	public class Problem3
	{
		public Problem3 ()
		{
		}
		public static void SpeedTest()
		{
			var watch = Stopwatch.StartNew();
			var sol1 = GetPrimeFactors1 ();
			watch.Stop();
			var time1 = watch.ElapsedMilliseconds;
			watch = Stopwatch.StartNew();
			var sol12 = GetPrimeFactors2 ();
			watch.Stop();
			var time2 = watch.ElapsedMilliseconds;
			bool is1Faster =  time1 > time2 ? true : false;

		}

		public static long GetSolution(bool isProductionMode)
		{
			long num = isProductionMode ? 600851475143 : 13195;
				
			var primes = GetPrimeFactors1 ();
			for (int i = primes.Count; i > 0; i--) {
				if(num % i == 0)
					return i;
			}
			return 1;
		}
		public static List<int> GetPrimeFactors2()
		{
			int num = 13195;
			//int num2 = 100000;
			//List<long> allItems = Enumerable.Range(2.0,num).ToList();
			var allItems = new List<int>(num){};
			int i = 0;
			while (i < num) {
				i++;
				allItems.Add (i);
			}

			for(long toCheck = 2; toCheck < num; toCheck++)
			{
				allItems.RemoveAll (j => j != toCheck && j % toCheck == 0);
			}
			return allItems;
		}

		public static List<int> GetPrimeFactors1()
		{
			int num = 13195;
			List<int> primes = Enumerable.Range(0, Convert.ToInt32(Math.Floor(2.52*Math.Sqrt(num)/Math.Log(num))) ).Aggregate(
				Enumerable.Range(2, num-1).ToList(), 
				(result, index) => { 
					var bp = result[index]; var sqr = bp * bp;
					result.RemoveAll(i => i >= sqr && i % bp == 0); 
					return result; 
				}
			);
			return primes;
		}
	}
}

