using System;

namespace ProjectEulerInC
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Problem4.SpeedTest ();
			var solution = Problem16.GetSolution ();
			Console.WriteLine (solution);
			Console.ReadKey ();
		}
	}
}
