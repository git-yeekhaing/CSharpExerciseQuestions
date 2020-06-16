﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    public class DiamondPattern
    {
        public static void Pattern1()
        {
            Console.WriteLine("input max stars sizes.");
            int maxStar = Convert.ToInt32(Console.ReadLine());

            int starCnt = 1;
            // upper loop
            for (int row = 1; row <= maxStar; row++)
            {
                // print space
                for (int space = 1; space < (maxStar - row) + 1; space++)
                {
                    Console.Write(" ");
                }

                // print stars
                for (int star = 1; star <= starCnt; star++)
                {
                    Console.Write("*");
                }

                starCnt += 2;

                Console.WriteLine();
            }

            // below loop
            starCnt = starCnt - 4; int belowSpace = 1;

            // upper loop
            for (int row = 1; row <= maxStar; row++)
            {
                // print space
                for (int space = 1; space <= belowSpace; space++)
                {
                    Console.Write(" ");
                }

                // print stars
                for (int star = 1; star <= starCnt; star++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

                starCnt -= 2;
                belowSpace += 1;
            }
        }


        public static void Pattern2()
        {
            Console.WriteLine("Enter max row count");
            int rowCnt = Convert.ToInt32(Console.ReadLine());

            // for upper loop
            char printChar = 'A';
            int innerSpaceCnt = 1;

            // Top Loop
            for (int row = 1; row <= rowCnt; row++)
            {
                // print space 
                for (int space = 0; space < (rowCnt - row) + 1; space++)
                {
                    Console.Write(" ");
                }

                // print start char
                Console.Write(printChar);

                if (row != 1)
                {
                    // print inner space
                    for (int innerSpace = 1; innerSpace <= innerSpaceCnt; innerSpace++)
                    {
                        Console.Write(" ");
                    }

                    innerSpaceCnt += 2;
                    // print end char
                    Console.Write(printChar);
                }

                printChar++;
                Console.WriteLine();
            }

            innerSpaceCnt -= 4; printChar--;
            // Below Loop
            for (int row = 1; row <= rowCnt - 1; row++)
            {
                printChar--;
                // print space
                for (int space = 1; space <= row + 1; space++)
                {
                    Console.Write(" ");
                }

                // print start char
                Console.Write(printChar);

                if (row != rowCnt - 1)
                {
                    // print inner space
                    for (int innerSpace = 1; innerSpace <= innerSpaceCnt; innerSpace++)
                    {
                        Console.Write(" ");
                    }

                    innerSpaceCnt -= 2;
                    // print end char
                    Console.Write(printChar);

                }

                Console.WriteLine();
            }
        }
    }
}