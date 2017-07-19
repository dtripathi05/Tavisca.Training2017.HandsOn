using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            do
            {
                Console.WriteLine("Enter first Numbers to Swap ");
                bool isIntFirst = Int32.TryParse(Console.ReadLine(), out firstNumber);
                Console.WriteLine("Enter second Numbers to Swap ");
                bool isIntSecond = Int32.TryParse(Console.ReadLine(), out secondNumber);
                if (isIntFirst && isIntSecond)
                {
                    Swapping swapNumbers = new Swapping();
                    swapNumbers.Swap(firstNumber, secondNumber);
                }
                else
                {
                    Console.WriteLine("\nEnter valid Input");
                }
            } while ((firstNumber != -1)&& (secondNumber != -1));
        }
    }
}
