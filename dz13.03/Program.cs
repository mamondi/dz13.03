using Class;

class Program
    {
    static void Main(string[] args)
        {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Class.Array array = new Class.Array(arr);
        System.Console.WriteLine(array.Max());
        System.Console.WriteLine(array.Min());
        System.Console.WriteLine(array.Avg());
        System.Console.WriteLine(array.Search(5));
        }
    }
