using Interface;

namespace Class
{
    public class Array : IOutput2
    {
        private int[] arr = new int[20];
        public Array()
        {
            for (int i = 0; i < 20; i++)
            {
                arr[i] = i + 1;
            }
        }
        public void ShowEven()
        {
            for (int i = 0; i < 20; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();
        }
        public void ShowOdd()
        {
            for (int i = 0; i < 20; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();
        }
        public void Show(int[] arr)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}