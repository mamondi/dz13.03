using Interface;

namespace Class
{
        public class Array : ICalc
        {
            public int[] arr;
            public Array(int[] arr)
        {
                this.arr = arr;
            }
            public int Less(int ValueToCompare)
        {
                int count = 0;
                foreach (int i in arr)
            {
                    if (i < ValueToCompare)
                {
                        count++;
                    }
                }
                return count;
            }
            public int Greater(int ValueToCompare)
        {
                int count = 0;
                foreach (int i in arr)
            {
                    if (i > ValueToCompare)
                {
                        count++;
                    }
                }
                return count;
        }
        }
    }
