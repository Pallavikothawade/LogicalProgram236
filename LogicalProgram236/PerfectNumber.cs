using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram236
{
    class PerfectNumber
    {
        public void perfectno(int number)
        {
            int sum = 0;

            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                    sum += i;
            }
            if (sum == number)
                Console.WriteLine("{0} This is Perfect Number", number);
            else
                Console.WriteLine("{1} This is Not Perfect Number", number);
        }
    }
}
