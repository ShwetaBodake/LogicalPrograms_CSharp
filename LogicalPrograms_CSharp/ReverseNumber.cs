using System;
namespace LogicalPrograms_CSharp
{
	public class ReverseNumber
	{
		public static void ReverseNumberDisplay()
		{
			Console.WriteLine("Enter the number");
			int num = Convert.ToInt32(Console.ReadLine());
			int ReverseNumber = 0;
			int reminder = 0;
			while (num != 0)
			{
				reminder = num % 10;
			ReverseNumber = (ReverseNumber * 10) + reminder;
				num = num / 10;
			}
			Console.WriteLine("After the reversing the number:{0}", ReverseNumber);
		}
	}
}

