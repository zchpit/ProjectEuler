using System;
using System.Numerics;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ProjectEulerInC
{
	public class Problem24
	{
		static int[] perm = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
		public Problem24 ()
		{
			
		}
		//Best solution is taken from: http://www.mathblog.dk/project-euler-24-millionth-lexicographic-permutation/
		public static string GetSolution()
		{
			//int[] perm = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			int N = perm.Length;
			string permNum = "";
			int remain = 1000000 - 1;

			List<int> numbers = new List<int>();
			for (int i = 0; i < N; i++) {
				numbers.Add(i);
			}

			for (int i = 1; i < N; i++) {
				int j = remain / Factor(N - i);
				remain = remain % Factor(N - i);
				permNum = permNum + numbers[j];
				numbers.RemoveAt(j);
				if (remain == 0) {
					break;
				}
			}

			for (int i = 0; i < numbers.Count; i++) {
				permNum = permNum + numbers[i];
			}
			return permNum;
		}
		private static int Factor(int i) {
			if (i < 0) {
				return 0;
			}

			int p = 1;
			for (int j = 1; j <= i; j++) {
				p *= j;
			}
			return p;
		}
		public static string GetSolutionBruteForce()
		{
			int count = 1;
			int numPerm = 1000000;
			while (count < numPerm) {
				int N = perm.Length;
				int i = N-1;
				while (perm[i - 1] >= perm[i]) {
					i = i - 1;

				}
				int j = N;
				while (perm[j - 1] <= perm[i - 1]) {
					j = j - 1;
				}
				// swap values at position i-1 and j-1
				swap(i - 1, j - 1);

				i++;
				j = N;
				while (i < j) {
					swap(i - 1, j - 1);
					i++;
					j--;
				}
				count++;
			}

			string permNum = "";
			for (int k = 0; k < perm.Length; k++) {
				permNum = permNum + perm[k];
			}
			return permNum;
		}
		private static void swap(int i, int j) {
			int k = perm[i];
			perm[i] = perm[j];
			perm[j] = k;
		}
	}
}

