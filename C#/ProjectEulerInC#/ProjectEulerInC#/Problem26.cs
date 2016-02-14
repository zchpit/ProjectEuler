using System;
using System.Linq;
using System.Collections.Generic;

namespace ProjectEulerInC
{
	public class Problem26
	{
		public Problem26 ()
		{
		}
		public static int GetSolution()
		{
			int limit = 1000;
			int[] primelist = Problem23.ESieve(limit);
			primelist = primelist.Where(a => a != 2 || a != 5).ToArray();

			int sequenceLength = 0;
			int i = 0;
			//for (int i = 1000; i > 1; i--) {
			//{
			for(int j = primelist.Length-1; j > 1; j--){
			{
				i = primelist[j];
				if (sequenceLength >= i) {
					break;
				}

				int[] foundRemainders = new int[i];
				int value = 1;
				int position = 0;

				while (foundRemainders[value] == 0 && value != 0) {
					foundRemainders[value] = position;
					value *= 10;
					value %= i;
					position++;
				}

				if (position - foundRemainders[value] > sequenceLength) {
					sequenceLength = position - foundRemainders[value];
				}
			}
		}
		return sequenceLength;
	}
	}
}
