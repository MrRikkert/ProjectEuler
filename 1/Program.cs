using System;

namespace _1
{
	class Program
	{
		static void Main(string[] args)
		{
			int answer = 0;
			for(int i = 3; i < 1000; i++)
			{
				if (i % 3 == 0 || i % 5 == 0)
					answer += i;
			}
			Console.WriteLine(answer);
		}
	}
}
