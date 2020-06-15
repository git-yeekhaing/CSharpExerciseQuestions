using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    class HarshadNumber
    {
        public static bool IsHarshadNumber(int input)
        {
            int sum = 0;
            String temp = input.ToString();

            for (int i = 0; i < temp.Length; i++)
            {
                sum += temp[i] - '0';
            }

            if (input % sum == 0)
            {
                return true;
            }

            return false;
        }

        public static void checkForHarshad(int inputNumber)
        {
            int copyOfInputNumber = inputNumber;

            int sum = 0; int lastDigit = 0;

            //Calculating the sum of digits of inputNumber
            while (inputNumber != 0)
            {
                lastDigit = inputNumber % 10;

                sum = sum + lastDigit;

                inputNumber = inputNumber / 10;
            }

            //Checking whether inputNumber is divisible by sum
            if ((copyOfInputNumber % sum) == 0)
            {
                Console.WriteLine(copyOfInputNumber + " is a Harshad number");
            }
            else
            {
                Console.WriteLine(copyOfInputNumber + " is not a Harshad number");
            }
        }
    }
}