using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number you want to check: ");
            int number = Int32.Parse(Console.ReadLine());
            int divisor = 0;

            for ( var i = 1; i <= number; i++)
            {
                if (number %i== 0)
                {
                    divisor++;
                }
            }
            if (divisor == 2)
            {
                Console.WriteLine("Entered Numbe is a Prime Number");
            }else
            {
                Console.WriteLine("Entered Number is not a Prime Number");
            }
            Console.ReadLine();
        }
    }
}
