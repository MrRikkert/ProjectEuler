using System;
using System.Collections.Generic;

namespace _12
{
	class Program
	{
		static void Main(string[] args)
		{
			long triangleNumber = 0;
			long i = 1;
			int maxDividers = 0;
			int dividers = 0;
			while(dividers < 500)
			{
				if (dividers > maxDividers)
					maxDividers = dividers;
				dividers = 0;
				triangleNumber += i;

				for(long k = 1; k <= triangleNumber / 2; k++)
				{
					if (triangleNumber % k == 0)
						dividers++;
				}

				i++;
			}
			Console.WriteLine(triangleNumber);
		}
	}
}
