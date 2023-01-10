using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram236
{
    class Fibbonacciseries
    {
        public void fibo()
        {
            int var1 = 0, var2 = 1, var3;
            Console.WriteLine("Enter The Number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(var1 + " ");
            Console.WriteLine(var2 + " ");
            for (int i = 2; i < n; ++i)
            {
                var3 = var1 + var2;
                Console.WriteLine(var3 + " ");
                var1 = var2;
                var2 = var3;
            }
        }
    }
}
