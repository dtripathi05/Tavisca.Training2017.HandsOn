using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] argument = new int[args.Length];
            for(int index = 0; index < args.Length; index++)
            {
                int.TryParse(args[index],out argument[index]);
            }
            Area rectangleArea = new Area();
            rectangleArea.AreaOfRectangle(argument[0], argument[1]);
            Parameter rectangleParameter = new Parameter();
            rectangleParameter.ParameterOfRectangle(argument[0], argument[1]);
            Console.ReadKey();
        }
    }
}
