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
                 sum +=  temp[i] - '0';
            }            

            if (input % sum == 0)
            {
                return true;
            }

            return false;
        }
    }
}
