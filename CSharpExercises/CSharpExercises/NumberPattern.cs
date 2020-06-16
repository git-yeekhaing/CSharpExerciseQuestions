using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    public class NumberPattern
    {
        public static void Pattern1()
        {
            Console.WriteLine("Enter size");
            int rowCnt = Convert.ToInt32(Console.ReadLine());

            int startOdd = 1;
            for (int row = 1; row <= rowCnt; row++)
            {
                // print space
                for (int space = 1; space <= (rowCnt - row) + 1; space++)
                {
                    Console.Write(" ");
                }

                // for number
                bool bCenter = false; int outputNum = 1;
                for(int num = 1; num <= startOdd; num++)
                {
                    Console.Write(outputNum);
                    if (outputNum == row)
                    {
                        bCenter = true;
                    }

                    outputNum = (bCenter) ? --outputNum : ++outputNum;
                }

                startOdd += 2;
                Console.WriteLine();
            }            
        }
    }
}