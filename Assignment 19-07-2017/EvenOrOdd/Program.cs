using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber;
            do
            {
                Console.WriteLine("Enter the Number To be Checked if Even and Odd");

                bool isInt = Int32.TryParse(Console.ReadLine(), out inputNumber);
                if (isInt)
                {
                    CheckEvenOdd evenOdd = new CheckEvenOdd();
                   bool result= evenOdd.EvenOdd(inputNumber);
                    if (result)
                    {
                        Console.WriteLine(inputNumber + " is Even\n");
                    }
                    else
                    {
                        Console.WriteLine(inputNumber + " is Odd\n");
                    }
                }
                else
                {
                    Console.WriteLine("Enter valid Input");
                }
            } while (inputNumber!=-1);
        }
    }
}
