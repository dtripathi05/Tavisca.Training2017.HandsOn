using System;

namespace SwapTwoNumbers
{
    public class Swapping
    {
        public void Swap(int first,int second)
        {
            first = first + second;
            second = first - second;
            first = first - second;
            Console.WriteLine("Numbers Before Swapping\nfirst={0}\nsecond={1}", second, first);
            Console.WriteLine("Numbers After Swapping\nfirst={0}\nsecond={1}", first, second);
        }
    }
}
