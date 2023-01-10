using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram236
{
    class ReverseNumber
    {
        public void Reverse()
        {
            int rem, rev = 0;
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                rev = (rev * 10) + rem;
                n = n / 10;
            }
            Console.WriteLine("Reverse Number is :" + rev);
        }
    }
}
