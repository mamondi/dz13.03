using Interface;

namespace Class
{
    public class Array : IMath
    {
        private int[] arr;
        public Array(int[] arr)
        {
            this.arr = arr;
        }
        public int Max()
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        public int Min()
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
        public int Avg()
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum / arr.Length;
        }
        public bool Search(int ValueToSearch)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == ValueToSearch)
                {
                    return true;
                }
            }
            return false;
        }

    }
}