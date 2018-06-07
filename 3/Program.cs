using System;
using System.Collections.Generic;
using System.Linq;

namespace _3
{
	class Program
	{
		static void Main(string[] args)
		{
			Program p = new Program();

			List<long> primes = new List<long>();

			bool factored = false;
			long i = 2;
			long currentNumber = 600851475143;

			while (!factored)
			{
				if (currentNumber % i == 0)
				{
					primes.Add(i);
					currentNumber /= i;
					i = 2;
				}
				else if (p.IsPrime(currentNumber))
				{
					primes.Add(currentNumber);
					factored = true;
				}
				else
					i = p.NextPrime(i);
			}

			Console.WriteLine(primes.Max());
		}

		public bool IsPrime(long number)
		{
			if (number == 1 || number == 2 || number == 3)
				return true;

			for(int i = 2; i < Math.Sqrt(number); i++)
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
