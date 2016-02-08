using System;

namespace ProjectEulerInC
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Problem4.SpeedTest ();
			var solution = Problem22.GetSolution ();
			Console.WriteLine (solution);
			Console.ReadKey ();
		}
	}
}
