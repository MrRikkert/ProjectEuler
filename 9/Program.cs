using System;

namespace _9
{
	class Program
	{
		static void Main(string[] args)
		{
			Program p = new Program();
			int equals = 1000;

			for (int a = 1; a <= equals / 3; a++)
			{
				for(int b = a + 1; b <= (equals - a) / 2; b++)
				{
					for(int c = b + 1; c <= equals - a- b; c++)
					{
						if(p.IsTriplet(a, b, c) && a + b + c == equals)
						{
							Console.WriteLine(a * b * c);
							break;
						}

					}
				}
			}
		}

		private bool IsTriplet(int a, int b, int c)
		{
			if (a < b && b < c && (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2)))
				return true;
			return false;
		}
	}
}
