using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram236
{
    class CoupanNumber
    {
        public void Coupan()
        {
            int[] Numbers = { 1234, 5678, 8910, 1112, 1314, 1516, 1718, 1920, 9513, 7531 };
            int count = 0;

            while (count < Numbers.Length)
            {
                Console.WriteLine("Count of {0} Number is {1}", count, Numbers[count]);
                count++;
            }
            Console.WriteLine("The numbers of times each coupan is shown:", +count);
        }
    }
}
