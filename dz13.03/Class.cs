using Interface;

namespace Class
{
    //Створити масив з 20 елементів, що реалізує методи інтерфейсу ICalc2
    public class Array : ICalc2
    {
        private int[] arr = new int[20];
        public Array()
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 10);
            }
        }
        public int CountDistinct()
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                bool isDistinct = true;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isDistinct = false;
                        break;
                    }
                }
                if (isDistinct)
                {
                    count++;
                }
            }
            return count;
        }
        public int EqualToValue(int valueToCompare)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }

    }
}