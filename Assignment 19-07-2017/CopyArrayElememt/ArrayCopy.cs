namespace CopyArrayElememt
{
    public class ArrayCopy
    {
        public int[] original = new int[5];
        public int[] Copy()
        {
           
            for (int index = 0; index < original.Length; index++)
            {
                original[index] = index + 1;
            }
            int[] copy = new int[5];
            for(int index2=copy.Length-1;index2>=0;index2--)
            {
                copy[index2] = original[index2];
            }
            return copy;
        }
    }
}
