namespace ReverseString
{
    public class Reverse
    {
        public string StringReverse(string toREverse)
        {
            char[] reverse = toREverse.ToCharArray();
            string reversed = "";
            for (int index= reverse.Length-1; index >= 0; index--)
            {
                reversed = reversed + reverse[index];
            }
            return reversed;
        }
    }
}
