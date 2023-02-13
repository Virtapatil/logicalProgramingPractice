using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammingProblems
{
    internal class FibonnciSeries
    {
        public static void Fibo()
        {
            int a = 0, b = 1, c;
            Console.WriteLine("Enter the number:");
            int num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + " " + b + " ");
            for (int i = 2; i < +num; i++)
            {
                /*Console.Write("{0}", a);
                c = a + b;
                a = b;
                b = c;*/
                c = a + b;
                Console.WriteLine(c + "");
                a=b;
                b=c;
            }
            Console.ReadLine();
        }
    }
}
