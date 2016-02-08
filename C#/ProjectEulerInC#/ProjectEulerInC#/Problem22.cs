using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEulerInC
{
	public class Problem22
	{
		public Problem22 ()
		{
		}
		public static BigInteger GetSolution()
		{
			var nameList = GetNamesFromFile (@"p022_names.txt");
			var sortedNameList = nameList.OrderBy (a => a).ToList();
			BigInteger sum = 0;
			for (int i = 0; i < sortedNameList.Count; i++) {
				if (sortedNameList [i].Contains("COLIN")) {
					string test = "test";
				}

				BigInteger numberSum = 0;
				var charArray = sortedNameList [i].ToCharArray ();
				for (int j = 0; j < charArray.Length; j++) {
					var letterNumber = char.ToUpper(charArray [j]) - 'A' + 1;
					numberSum += letterNumber;
				}
				numberSum *= (i+1);
				sum += numberSum;
			}

			return sum;
		}
		private static string[] GetNamesFromFile(string fileName)
		{
			string text;
			using (var streamReader = new StreamReader(fileName, Encoding.UTF8))
			{
				text = streamReader.ReadToEnd();
			}
			var nameList = text.Replace("\"", "").Split (',');
			return nameList;
		}
	}
}

