namespace CyclicRotation.Core
{
    public class Solution
    {
        public int[] CyclicRotation(int[] a, int k)
        {
            var array = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                array[(i + k) % a.Length] = a[i];
            }
            return array;
        }
    }
}
