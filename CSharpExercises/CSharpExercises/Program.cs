﻿using System;
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
            Console.WriteLine("Enter the number.");
            int input = Convert.ToInt32(Console.ReadLine());
            bool result = HarshadNumber.IsHarshadNumber(input);

            if (result == true)
              Console.WriteLine($"{input} is a Harshad number");

            Console.ReadLine();
        }
    }
}
