﻿using System;
namespace LogicalPrograms_CSharp
{
	public class HarmonicSeries
	{
        public static void HarmonicSeriesDisplay()
        {
            Console.WriteLine("Enter the number ");
            int num = Convert.ToInt32(Console.ReadLine());
            int n1 = 0, n2 = 1, n3;
            Console.WriteLine("Harmoni series :- {0}", n1);
            Console.WriteLine("Harmoni series :- {0}", n2);
            for (int i = 0; i <= num; i++)
            {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;


                Console.WriteLine("Harmoni series :- {0}", n3);
            }
        }
}
}

