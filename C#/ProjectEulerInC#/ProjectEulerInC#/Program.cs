using System;

namespace ProjectEulerInC
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Problem3.SpeedTest ();
			var solution = Problem3.GetSolution (true);
			Console.WriteLine (solution);
			Console.ReadKey ();
		}

	}
}
