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
                case 2:
                    Console.WriteLine("Enter The Number");
                    int num = Convert.ToInt32(Console.ReadLine());
                    PerfectNumber perfectNumber = new PerfectNumber();
                    perfectNumber.perfectno(num);
                    break;
                case 3:
                    PrimeNumber primeNumber = new PrimeNumber();
                    primeNumber.Prime();
                    break;
                case 4:
                    ReverseNumber reverseNumber = new ReverseNumber();
                    reverseNumber.Reverse();
                    break;
                case 5:
                    CoupanNumber coupanNumber = new CoupanNumber();
                    coupanNumber.Coupan();
                    break;


            }
            Console.ReadLine();
        }
    }
}
