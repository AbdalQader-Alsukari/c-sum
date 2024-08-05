using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUM_NUMBERS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter Number 1 : ");
            num1 =Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number 2 : ");
            num2 =Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("The result is {0}",sum);
        }
    }
}
