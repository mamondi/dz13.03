using Class;

namespace dz13._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Class.Array arr = new Class.Array();
            arr.ShowEven();
            arr.ShowOdd();
            arr.Show(arr.arr);
        }
    }
}