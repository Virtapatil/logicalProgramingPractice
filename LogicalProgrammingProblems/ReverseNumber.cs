using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammingProblems
{
    internal class ReverseNumber
    {
        public static void ReverseNum()
        {
            int rem = 0, rev = 0;
            Console.WriteLine("Enter th number: ");
            int num=Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine("The reverse number is {0}", rev);
            Console.ReadLine();
        }

    }
}
