using System;
using System.Collections.Generic;
using System.Linq;

namespace _2
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = new List<int> { 2, 1 };
			while(numbers[0] < 4000000)
			{
				numbers.Insert(0, numbers[0] + numbers[1]);
			}
			numbers[0] = 0;
			Console.WriteLine(numbers.Where(i => i % 2 == 0).Sum());
		}
	}
}
