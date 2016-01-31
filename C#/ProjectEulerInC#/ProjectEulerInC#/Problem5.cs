using System;

namespace ProjectEulerInC
{
	public class Problem5
	{
		public Problem5 ()
		{
			
		}
		public static int GetSolution()
		{
			int allDevideNum = 20;
			for(int i=25; i < Int32.MaxValue; i++)
			{
				for(int j=1; j<=allDevideNum; j++)
				{
					if (i % j != 0)
						break;

					if (j == allDevideNum)
						return i;
				}
			}
			return -1;
		}
	}
}