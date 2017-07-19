using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            int thirdNumber;

            do
            {
                Console.WriteLine("Enter the First Number ");
                bool isIntNumber = Int32.TryParse(Console.ReadLine(), out firstNumber);
                Console.WriteLine("Enter the Second Number ");
                bool isIntNumber1 = Int32.TryParse(Console.ReadLine(), out secondNumber);
                Console.WriteLine("Enter the Third Number ");
                bool isIntNumber2 = Int32.TryParse(Console.ReadLine(), out thirdNumber);
                if (isIntNumber && isIntNumber1 && isIntNumber2)
                {
                    MultAdd math = new MultAdd();
                    Subtract mathsub = new Subtract();
                    Console.WriteLine("multiplication of input Numbers is ={0}", math.Mult(firstNumber, secondNumber, thirdNumber));
                    Console.WriteLine("Addition of input Numbers is ={0}", math.Add(firstNumber, secondNumber, thirdNumber));
                    Console.WriteLine("Subtraction of input Numbers is ={0}", mathsub.Sub(firstNumber, secondNumber, thirdNumber));
                }
                else
                {
                    Console.WriteLine("Enter valid Input");
                }
            } while ((firstNumber != -1) && (secondNumber != -1));
        }
    }
}
