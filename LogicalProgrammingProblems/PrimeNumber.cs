using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammingProblems
{
    internal class PrimeNumber
    {
        public static void PrimeNum()
        {
            int sum = 0;
            Console.WriteLine("Enter the Number: ");
            int num=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    sum++;
                }
            }
            if (sum == 2)
            {
                Console.WriteLine("The Number is Prime");
            }
            else
            {
                Console.WriteLine("The number is not prime");
            }
            Console.ReadLine();
        }
    }
}
