using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    public class Program
    {
        static void Main(string[] args)
        {
            string toReverse = "";
            do
            {
                Console.WriteLine("Enter the String ");
                toReverse = Console.ReadLine();
                Reverse reverseString = new Reverse();
              string reversed=  reverseString.StringReverse(toReverse);
                Console.WriteLine("Reverse String is \n" + reversed);
            } while (toReverse != "-1");
        }
    }
}
