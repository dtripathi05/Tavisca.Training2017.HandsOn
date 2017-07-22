using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueRefType
{
    class ValueRefType
    {
        static void Main(string[] args)
        {
            ValueRefType val = new ValueRefType();
            int number1, number2;
            Console.WriteLine(" enter 1st element ");
            if (int.TryParse(Console.ReadLine(),out number1))
            {
            }
            Console.WriteLine(" enter 2nd element ");
            if (int.TryParse(Console.ReadLine(), out number2))
            {
            }
            //by reference
            Console.WriteLine("elements before swapping by reference" + "\n " + number1 + "  " + number2);
            val.Swap_By_Reference(ref number1, ref number2);
            Console.WriteLine("elements after swapping" +" \n "+ number1 + "  " + number2);
            //by value
            Console.WriteLine("elements before swapping by value"+  " \n " + number1 + "  " + number2);
            val.Swap_By_Value(number1, number2);
            Console.WriteLine("elements after swapping" + "  \n " + number1 + "  " + number2);
            Console.ReadKey(true);
        }
        void Swap_By_Value(int number1, int number2)
        {
            int temp;
            temp = number1;
            number1 = number2;
            number2 = temp;
        }
        void Swap_By_Reference(ref int number1, ref int number2)
        {
            int temp;
            temp = number1;
            number1 = number2;
            number2 = temp;
        }
    }
}
