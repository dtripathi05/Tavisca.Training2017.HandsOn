using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowCount;
            Console.Write("Enter the Count of Rows\n");
            bool isIntNumber = Int32.TryParse(Console.ReadLine(), out rowCount);
            if (isIntNumber)
            {
                Draw pattern = new Draw();
                pattern.DisplayPattern(rowCount);
                Console.ReadKey();
            }
        }
    }
}
