using System;

namespace Pattern
{
    public class Draw
    {
        public void DisplayPattern(int rowcount)
        {
            for (int row = 1; row <= rowcount; row++)
            {
                for(int col=1;col<=rowcount-row;col++)
                {
                    Console.Write(" ");
                }
                for(int col2 = 1; col2 <= row; col2++)
                {
                    Console.Write(col2);
                }
                for(int col3 = row - 1; col3 >= 1; col3--)
                {
                    Console.Write(col3);
                }
                Console.WriteLine();
            }

        }
    } 
}
