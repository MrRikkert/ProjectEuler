using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
			Program p = new Program();

			bool divised = false;
			int i = 0;

			while(!divised)
			{
				i++;
				if (p.IsDivised(i))
					divised = true;
			}
			Console.WriteLine(i);
        }

		private bool IsDivised(int i)
		{
			for(int k = 1; k <= 20; k++)
			{
				if (i % k != 0)
				{
					return false;
				}
			}
			return true;
		}
    }
}
