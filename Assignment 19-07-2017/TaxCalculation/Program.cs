using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputMoney;
            do
            {
                Console.WriteLine("Enter the Amount/Money");
                bool isDouble = double.TryParse(Console.ReadLine(), out inputMoney);
                if (isDouble)
                {
                    TaxCalculator cal = new TaxCalculator();
                    double tax = cal.Caculator(inputMoney);
                    Console.WriteLine("Amout of tax you have to pay={0}", tax);
                }
                else
                {
                    Console.WriteLine("Enter valid Input");
                }
            } while (inputMoney != -1);
        }
    }
}
