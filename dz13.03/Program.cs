using Class;

namespace dz13._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Class.Array arr = new Class.Array();
            Console.WriteLine("Count of distinct elements: " + arr.CountDistinct());
            Console.WriteLine("Count of elements equal to 5: " + arr.EqualToValue(5));
        }
    }
}