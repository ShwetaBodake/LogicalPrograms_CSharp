namespace LogicalPrograms_CSharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("WelCome to Logical Programs");
            Console.WriteLine("Choose any one program from below option: ");
            Console.WriteLine("1:Harmonic Series \n 2:Perfect Nmuber \n 3:Prime Number \n4.Reverse Number \n5:Coupon Numbers");
            int Options=Convert.ToInt32(Console.ReadLine());
            switch (Options)
            {
                case 1:
                    HarmonicSeries.HarmonicSeriesDisplay();
                    break;
                case 2:
                    PerfectNumber.PerfectNumberDisplay();
                    break;
                case 3:
                    PrimeNumber.PrimeNumberDisplay();
                    break;
                case 4:
                    ReverseNumber.ReverseNumberDisplay();
                    break;
                case 5:
                    CouponNumbers.CouponNumberDisplay();
                    break;
                default:
                    Console.WriteLine("Enter option within given range");
                    break;
            }
        }
    }
}
