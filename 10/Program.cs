using System;
using System.Collections.Generic;
using System.Linq;

namespace _10
{
	class Program
	{
		static void Main(string[] args)
		{
			Program p = new Program();
			List<long> primes = new List<long> { 2 };

			while (primes[0] < 2000000)
			{
				primes.Insert(0, p.NextPrime(primes[0]));
			}
			primes.RemoveAt(0);
			Console.WriteLine(primes.Sum());
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
