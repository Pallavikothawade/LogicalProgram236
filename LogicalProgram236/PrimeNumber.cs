using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram236
{
    class PrimeNumber
    {
        public void Prime()
        {
            int a = 0;
            Console.WriteLine("Enter The Number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
                Console.WriteLine("This is Prime Number");
            else
                Console.WriteLine("This is Not Prime Number");
        }
    }
}
