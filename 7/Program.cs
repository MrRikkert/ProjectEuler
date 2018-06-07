using System;
using System.Collections.Generic;

namespace _7
{
	class Program
	{
		static void Main(string[] args)
		{
			Program p = new Program();
			List<long> primes = new List<long> { 2 };

			while(primes.Count != 10001)
			{
				primes.Insert(0, p.NextPrime(primes[0]));
			}

			Console.WriteLine(primes[0]);
		}

		public bool IsPrime(long number)
		{
			if (number == 1 || number == 2 || number == 3)
				return true;

			for (int i = 2; i <= Math.Sqrt(number); i++)
			{
				if (number % i == 0)
					return false;
			}
			return true;
		}

		public long NextPrime(long currentPrime)
		{
			long i = currentPrime + 1;
			while (!IsPrime(i))
				i++;
			return i;
		}
	}
}
