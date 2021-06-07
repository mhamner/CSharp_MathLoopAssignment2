using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_MathLoopAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Accept 2 variables, X and Y.  Accept a variable Z.  Adds (X+Y) Z times.
            Console.WriteLine("Please enter the first number (x).");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number (y).");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the third number (z).");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the limit.");
            int limit = Convert.ToInt32(Console.ReadLine());

            int answer = (x + y) * z;
            Console.WriteLine($"Result of ({x} + {y}) * {z} = {answer}.");

            if(answer > limit)
            {
                Console.WriteLine($"{answer} is greater than {limit}.");
            }
            else if (answer < limit)
            {
                Console.WriteLine($"{answer} is less than {limit}.");
            }
            else
            {
                Console.WriteLine($"{answer} is equal to {limit}.");
            }


            Console.ReadKey();
        }
    }
}
