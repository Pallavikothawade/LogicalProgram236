using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram236
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n*****************Welcome The Logical Program**********************");
            Console.WriteLine("Plz Choose Any One Option In Below Program");
            Console.WriteLine("1:Fibbonacci Series\n2:Perfect Number\n3:Prime Number\n4:Reverse Number\n5:Coupon Number\n6:Stopwatch Program\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:Fibbonacciseries fibbonacciseries = new Fibbonacciseries();
                    fibbonacciseries.fibo();
                    break;
            }
            Console.ReadLine();
        }
    }
}
