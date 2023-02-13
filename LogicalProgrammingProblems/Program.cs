namespace LogicalProgrammingProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logical Programing Problem");
            Console.WriteLine("Please Enter Below Number");
            Console.WriteLine("1.FibonacciSeries \n2.PerfectNumber \n3.PrimeNumber \n10.exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    FibonnciSeries.Fibo();
                    break;
                case 2:
                    PerfectNumber.PerfectNum();
                    break;
                    case 3:
                        PrimeNumber.PrimeNum();
                    break;
                default:
                    Console.WriteLine("Please Enter the option from Above");
                    break;
            }
            Console.ReadLine();
        }
    }
}