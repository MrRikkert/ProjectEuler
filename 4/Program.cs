using System;

namespace _4
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Program p = new Program();
			int palindrome = 0;

			for (int i = 100; i <= 999; i++)
			{
				for(int k = 100; k <= 999; k++)
				{
					int product = i * k;
					if (p.IsPalindrome(product) && product > palindrome)
						palindrome = product;
				}
			}

			Console.WriteLine(palindrome);
		}

		private bool IsPalindrome(int number)
		{
			string numberString = number.ToString();
			string firstHalve = numberString.Substring(0, numberString.Length / 2);
			string secondHalve = Reverse(numberString).Substring(0, numberString.Length / 2);
			if (firstHalve == secondHalve)
				return true;
			return false;
		}

		private string Reverse(string s)
		{
			char[] array = s.ToCharArray();
			Array.Reverse(array);
			return new string(array);
		}
	}
}