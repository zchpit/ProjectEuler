using System;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

namespace ProjectEulerInC
{
	public class Problem4
	{
		public Problem4 ()
		{
		}
		public static void SpeedTest()
		{
			var watch = Stopwatch.StartNew();
			var sol1 = IsPalidrome1 (90109);
			watch.Stop();
			var time1 = watch.ElapsedMilliseconds;
			watch = Stopwatch.StartNew();
			var sol12 = IsPalidrome2 (90109);
			watch.Stop();
			var time2 = watch.ElapsedMilliseconds;
			bool is1Faster =  time1 < time2 ? true : false;

		}
		public static int GetSolution()
		{
			int min = 100;
			int max = 999;
			List<int> solutions = new List<int>(100);

			for (int i = min; i <= max; i++) {
				for (int j = min; j <= max; j++) {
					int propableSolution = i * j;
					if(IsPalidrome2(propableSolution))
						solutions.Add(propableSolution);
				}
			}

			return solutions.Max();
		}
		private static bool IsPalidrome1(int toCheck)
		{
			string myString = toCheck.ToString ();
			string first = myString.Substring(0, myString.Length / 2);
			char[] arr = myString.ToCharArray();
			Array.Reverse(arr);
			string temp = new string(arr);
			string second = temp.Substring(0, temp.Length / 2);
			return first.Equals(second);
		}
		private static bool IsPalidrome2(int toCheck)
		{
			string myString = toCheck.ToString ();
			return myString.SequenceEqual(myString.Reverse());
		}
	}
}