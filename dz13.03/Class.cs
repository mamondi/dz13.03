using Interface;

namespace Class
{
    public class Array : IOutput
    {
        private int[] arr;
        public Array(int size)
        {
            arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = i;
            }
        }
        public void Show()
        {
            foreach (int i in arr)
            {
                System.Console.Write(i + " ");
            }
            System.Console.WriteLine();
        }
        public void Show(string info)
        {
            System.Console.Write(info + " ");
            Show();
        }
    }
}   