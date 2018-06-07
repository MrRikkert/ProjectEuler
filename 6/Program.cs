using System;
using System.Collections.Generic;
using System.Linq;

namespace _6
{
	class Program
	{
		static void Main(string[] args)
		{
			List<double> numbers = new List<double>();
			List<double> numbers2 = new List<double>();
			for (int i = 1; i <= 100; i++)
			{
				numbers.Add(Math.Pow(i, 2));
				numbers2.Add(i);
			}

			double SumOfSquares = numbers.Sum();
			double SquareOfSum = Math.Pow(numbers2.Sum(), 2);

			Console.WriteLine(SquareOfSum - SumOfSquares);
		}
	}
}
