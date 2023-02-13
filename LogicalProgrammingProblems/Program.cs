namespace LogicalProgrammingProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logical Programing Problem");
            Console.WriteLine("Please Enter Below Number");
            Console.WriteLine("1.FibonacciSeries \n2.PerfectNumber");
            int choice = Convert.ToInt32(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    FibonnciSeries.Fibo();
                    break;
                case 2:
                    PerfectNumber.PerfectNum();
                    break;
                default:
                    Console.WriteLine("Please Enter the option from Above");
                    break;
            }
            Console.ReadLine();
        }
    }
}