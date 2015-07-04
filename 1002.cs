using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
	class Program
	{
		static Dictionary<char, char> d = new Dictionary<char, char>()
		{
			{'i', '1' }, { 'j', '1' },
			{'a', '2' }, { 'b', '2' }, { 'c', '2' },
			{'d', '3' }, { 'e', '3' }, { 'f', '3' },
			{'g', '4' }, { 'h', '4' },
			{'k', '5' }, { 'l', '5' },
			{'m', '6' }, { 'n', '6' },
			{'p', '7' }, { 'r', '7' }, { 's', '7' },
			{'t', '8' }, { 'u', '8' }, { 'v', '8' },
			{'w', '9' }, { 'x', '9' }, { 'y', '9' },
			{'o', '0' }, { 'q', '0' }, { 'z', '0' }
		};

		static Dictionary<String, String> wordsDic = new Dictionary<String, String>() { };

		static Dictionary<String, String> bestNumbers = new Dictionary <String, String>() { };

		static void Main(string[] args)
		{
			string input = Console.In.ReadToEnd();
			char[] charSeparators = new char[] { ' ', '\n', '\r' };
			String[] inputArray = input.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);

			int currentPhoneLineNum = 0;
			String phoneNumber = "";
			int numberOfWords = 0;

			while(currentPhoneLineNum<inputArray.Length-1)
			{
				phoneNumber = inputArray[currentPhoneLineNum];
				numberOfWords = Int32.Parse(inputArray[currentPhoneLineNum+1]);

				String wrd, wrdNums;
				for (int i = 0; i< numberOfWords; i++)
				{
					wrd = inputArray[i+2];
					wrdNums = toPhoneNumber(wrd);
					if (!wordsDic.ContainsKey(wrdNums))
						wordsDic.Add(toPhoneNumber(inputArray[i+2]), inputArray[i+2]);
				}

				Console.WriteLine(searchSubWords(phoneNumber).Replace("-1", "No solution."));

				currentPhoneLineNum += (numberOfWords + 2);
				bestNumbers.Clear();
				wordsDic.Clear();
			}
		}

		static String searchSubWords(String subPhoneNumber)
		{
			if (bestNumbers.ContainsKey(subPhoneNumber))
				return bestNumbers[subPhoneNumber];

			if (wordsDic.ContainsKey(subPhoneNumber))
				return wordsDic[subPhoneNumber];

			int len = subPhoneNumber.Length;
			String currentResult = "-1";
			String endingWords;
			
			for (int i = 0; i<len; i++)
			{
				if (wordsDic.ContainsKey(subPhoneNumber.Substring(0, len-i)))
				{
					endingWords = searchSubWords(subPhoneNumber.Substring(len-i));
					if (endingWords != "-1" && (currentResult.Equals("-1") || compareWordCount(endingWords, currentResult)))
						currentResult = wordsDic[subPhoneNumber.Substring(0, len-i)] + " " + endingWords;
				}
			}

			bestNumbers.Add(subPhoneNumber, currentResult);

			return currentResult;
		}

		static bool compareWordCount(String str1, String str2)
		{
			int i1 = 0, i2 = 0;
			foreach(char c in str1)
				if (c == ' ') i1++;
			foreach(char c in str2)
				if (c == ' ') i2++;
				
			return !(i1+1 > i2);
		}

		static String toPhoneNumber(String theWord)
		{
			StringBuilder sb = new StringBuilder("", 100);

			foreach(char c in theWord)
				sb.Append(d[c]);
			return sb.ToString();
		}
	}
}