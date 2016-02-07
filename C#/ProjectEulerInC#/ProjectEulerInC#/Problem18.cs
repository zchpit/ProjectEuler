using System;

namespace ProjectEulerInC
{
	public class Problem18
	{
		public Problem18 ()
		{
			
		}
		public static double GetSolution()
		{
			int[,] list = new int[15,16];
			string input = @"75
							95 64
							17 47 82
							18 35 87 10
							20 04 82 47 65
							19 01 23 75 03 34
							88 02 77 73 07 63 67
							99 65 04 28 06 16 70 92
							41 41 26 56 83 40 80 70 33
							41 48 72 33 47 32 37 16 94 29
							53 71 44 65 25 43 91 52 97 51 14
							70 11 33 28 77 73 17 78 39 68 17 57
							91 71 52 38 17 14 91 43 58 50 27 29 48
							63 66 04 68 89 53 67 30 73 16 69 87 40 31
							04 62 98 27 23 09 70 98 73 93 38 53 60 04 23";
			var charArray = input.Split ('\n');

			for (int i=0; i < charArray.Length; i++) {
				var numArr = charArray[i].Trim().Split(' ');

				for (int j = 0; j<numArr.Length; j++)
				{
					int number = Convert.ToInt32 (numArr[j]);
					list [i, j] = number;
				}
			}

			for (int i = 13; i >= 0; i--) {
				for (int j = 0; j < 15; j++) {
					list[i,j] = Math.Max(list[i, j] + list[i+1, j], list[i,j] + list[i+1, j+1]);
				}
			}
			return list [0, 0];
		}
		public static double GetSolutionRosetaCode()
		{
			int[,] list = new int[18,19];
			string input = @"55
	                        94 48
	                       95 30 96
	                     77 71 26 67
	                    97 13 76 38 45
	                  07 36 79 16 37 68
	                 48 07 09 18 70 26 06
	               18 72 79 46 59 79 29 90
	              20 76 87 11 32 07 07 49 18
	            27 83 58 35 71 11 25 57 29 85
	           14 64 36 96 27 11 58 56 92 18 55
	         02 90 03 60 48 49 41 46 33 36 47 23
	        92 50 48 02 36 59 42 79 72 20 82 77 42
	      56 78 38 80 39 75 02 71 66 66 01 03 55 72
	     44 25 67 84 71 67 11 61 40 57 58 89 40 56 36
	   85 32 25 85 57 48 84 35 47 62 17 01 01 99 89 52
	  06 71 28 75 94 48 37 10 23 51 06 48 53 18 74 98 15
	27 02 92 23 08 71 76 84 15 52 92 63 81 10 44 10 69 93";
			var charArray = input.Split ('\n');

			for (int i=0; i < charArray.Length; i++) {
				var numArr = charArray[i].Trim().Split(' ');

				for (int j = 0; j<numArr.Length; j++)
				{
					int number = Convert.ToInt32 (numArr[j]);
					list [i, j] = number;
				}
			}

			for (int i = 16; i >= 0; i--) {
				for (int j = 0; j < 18; j++) {
					list[i,j] = Math.Max(list[i, j] + list[i+1, j], list[i,j] + list[i+1, j+1]);
				}
			}
			return list [0, 0];
		}
		public static double GetTestSolution()
		{
			int[,] list = new int[4,5];
			string input = @"3
							7 4
							2 4 6
							8 5 9 3";
			var charArray = input.Split ('\n');

			for (int i=0; i < charArray.Length; i++) {
				var numArr = charArray[i].Trim().Split(' ');

				for (int j = 0; j<numArr.Length; j++)
				{
					int number = Convert.ToInt32 (numArr[j]);
					list [i, j] = number;
				}
			}
				
			for (int i = 2; i >= 0; i--) {
				for (int j = 0; j < 4; j++) {
					list[i,j] = Math.Max(list[i, j] + list[i+1, j], list[i,j] + list[i+1, j+1]);
				}
			}
			return list [0, 0];
		}
	}
}