using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    public class Program
    {
        static void Main(string[] args)
        {
            int inputNumber;
            int inputPower;
            do
            {
                Console.WriteLine("Enter the Number ");
                bool isIntNumber= Int32.TryParse(Console.ReadLine(), out inputNumber);
                Console.WriteLine("Enter the Power ");
                bool isIntPower = Int32.TryParse(Console.ReadLine(), out inputPower);
                if (isIntNumber&& isIntPower)
                {
                    CalPower power = new CalPower();
                   double result= power.FindPower(inputNumber, inputPower);
                    Console.WriteLine("Result ={0}", result);
                }
                else
                {
                    Console.WriteLine("Enter valid Input");
                }
            } while (inputNumber != -1);
        }
    }
}
