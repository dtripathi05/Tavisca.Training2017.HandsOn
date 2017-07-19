using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyArrayElememt
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayCopy copying = new ArrayCopy();
            int[] copied = copying.Copy();
            Console.WriteLine("Original Array");
            foreach(int original in copying.original)
            {
                Console.WriteLine(original);
            }
            Console.WriteLine("Copied Array");
            foreach(int copy in copied)
            {
                Console.WriteLine(copy);
            }
            Console.ReadKey();

        }
    }
}
