using System;
namespace LogicalPrograms_CSharp
{
	public class PrimeNumber
	{
		public static void PrimeNumberDisplay()
		{
			int count = 0;
			Console.WriteLine("Enter the nmuber");
			int num = Convert.ToInt32(Console.ReadLine());
			for (int i = 1; i <= num; i++)
			{
				if (num%i == 0)
				{
					count++;
				}
              
            }
            Console.WriteLine(count);
            if (count==2)
			{
				Console.WriteLine("The given number {0} is prime number",num);
			}
		}
	}
}

