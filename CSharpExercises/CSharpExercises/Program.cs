using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("Enter the number.");
            int input = Convert.ToInt32(Console.ReadLine());
            bool result = HarshadNumber.IsHarshadNumber(input);

            if (result == true)
              Console.WriteLine($"{input} is a Harshad number");

            // 2nd methods
            HarshadNumber.checkForHarshad(input);
           */
            // diamond pattern1
            DiamondPattern.Pattern3();
            Console.ReadLine();
        }
    }
}