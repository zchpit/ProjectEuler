using System;

namespace ProjectEulerInC
{
	public class Problem19
	{
		public Problem19 ()
		{
		}
		public static double GetSolution()
		{
			int counter = 0;
			DateTime date = new DateTime (1901, 01, 01);
			DateTime endDate = new DateTime (2000, 12, 31);
			while(date < endDate)
			{
				if (date.DayOfWeek == DayOfWeek.Sunday)
					counter++;
					
				date = date.AddMonths (1);
			}
			return counter;
		}
	}
}

