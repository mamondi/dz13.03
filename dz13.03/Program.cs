using Class;

namespace dz13._03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Class.Array array = new Class.Array(arr);
            System.Console.WriteLine(array.Less(5));
            System.Console.WriteLine(array.Greater(5));
        }
    }
}