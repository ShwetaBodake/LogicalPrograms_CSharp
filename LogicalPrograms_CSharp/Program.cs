namespace LogicalPrograms_CSharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("WelCome to Logical Programs");
            Console.WriteLine("Choose any one program from below option: ");
            Console.WriteLine("1:Harmonic Series \n 2:Perfect Nmuber \n 3:Prime Number");
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
                default:
                    Console.WriteLine("Enter option within given range");
                    break;
            }
        }
    }
}
