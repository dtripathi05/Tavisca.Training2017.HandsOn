using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            int thirdNumber;
            int fourthNumber;
        
            do
            {
                Console.WriteLine("Enter the First Number ");
                bool isIntNumber = Int32.TryParse(Console.ReadLine(), out firstNumber);
                Console.WriteLine("Enter the Second Number ");
                bool isIntNumber1 = Int32.TryParse(Console.ReadLine(), out secondNumber);
                Console.WriteLine("Enter the Third Number ");
                bool isIntNumber2 = Int32.TryParse(Console.ReadLine(), out thirdNumber);
                Console.WriteLine("Enter the Third Number ");
                bool isIntNumber3 = Int32.TryParse(Console.ReadLine(), out fourthNumber);
                if (isIntNumber && isIntNumber1&& isIntNumber2&& isIntNumber3)
                {
                    MathFunction math = new MathFunction();
                    Console.WriteLine("multiplication of input Numbers is ={0}", math.Mult(firstNumber, secondNumber , thirdNumber, fourthNumber));
                    Console.WriteLine("Addition of input Numbers is ={0}", math.Add(firstNumber, secondNumber, thirdNumber, fourthNumber));
                    Console.WriteLine("Subtraction of input Numbers is ={0}", math.Sub(firstNumber, secondNumber, thirdNumber, fourthNumber));
                }
                else
                {
                    Console.WriteLine("Enter valid Input");
                }
            } while ((firstNumber != -1) && (secondNumber != -1));
        }
    }
}
