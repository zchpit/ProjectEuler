using System;

namespace ProjectEulerInC
{
	public class Problem12
	{
		public Problem12 ()
		{
			
		}
		public static double GetSolution()
		{
			var solultion = GetSolutionBruteForceTrialDivision (500);
			return Convert.ToDouble (solultion);
		}
		public static double GetSolutionBruteForceTrialDivision(int num)
		{
			int solution = 0;
			for (int i = 1; i <  Int32.MaxValue; i++) {
				solution += i;

				if (NumberOfDivisors (solution) >= num)
					return solution;
			}
			return -1;
		}
		private static int NumberOfDivisors(int number) {
			int nod = 0;
			int sqrt = (int) Math.Sqrt(number);

			for(int i = 1; i<= sqrt; i++){
				if(number % i == 0){
					nod += 2;
				}
			}
			//Correction if the number is a perfect square
			if (sqrt * sqrt == number) {
				nod--;
			}

			return nod;
		}
		public static double GetSolutionBruteForce(int num)
		{
			double solution = 0;
			int numOfDiv = 0;

			for (double i = 1; i <  double.MaxValue; i++) {
				numOfDiv = 0;
				solution += i;

				for (double j = 1; j <= solution; j++) {
					if (solution % j == 0) {
						numOfDiv++;

						if (numOfDiv > num) {
							return solution;
						}
					}
				}
			}
			return solution;
		}
	}
}

