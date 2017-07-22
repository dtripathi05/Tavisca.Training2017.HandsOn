using System;

namespace CommandLineArgs
{
    public class Parameter
    {
        public void ParameterOfRectangle(int length, int breadth)
        {
            Console.WriteLine("Parameter Of Rectangle for Length = {0} and Breadth = {1} \n {2}", length, breadth, 2 *(length + breadth));
        }
    }
}
