using System;
namespace LogicalPrograms_CSharp
{
	public class PerfectNumber
	{
		public static void PerfectNumberDisplay()
		{
            Console.WriteLine("Ennter the number :");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= num2; i++)
            {
                if (num2 % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == num2)
            {
                Console.WriteLine("Given number is perfect number");
            }
            else
                Console.WriteLine("Number is not perfect number");
        }
	}
}

