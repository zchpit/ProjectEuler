using System;

namespace ProjectEulerInC
{ 
	public class Problem9
	{
		public Problem9 ()
		{
			
		}
		public static double GetSolution()
		{
			for (int i = 1; i < 1000; i++) {
				for (int j = 1; j < 1000; j++) {
					for (int k = 1; k < 1000; k++) {
						if(i + j + k == 1000)
						{
							if(IsPitagorianTriplet(i, j,k))
							{
								return i * j * k;
							};
						}
					}
				}
			}
			return -1;
		}
		private static bool IsPitagorianTriplet(int i, int j, int k)
		{
			if(i * i + j *j == k * k)
				return true;
			else
				return false;
		}
	}
}

