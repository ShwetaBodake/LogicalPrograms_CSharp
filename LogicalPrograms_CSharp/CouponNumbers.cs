using System;
namespace LogicalPrograms_CSharp
{
	public class CouponNumbers
	{
		public static void CouponNumberDisplay()
		{
			int count = 0;
			int arrCount = 0;
			bool[] arr = new bool[3];

			Random random = new Random();
			while(arrCount != arr.Length)
			{
				int input = random.Next(0, 3);
				count++;
				if (!arr[input])
				{
					arr[input] = true;
					arrCount++;
				}
			}
			Console.WriteLine("Random count :" + count + " in order genersate all 3 distinct coupon number");
		}
	}
}

