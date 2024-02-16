namespace a_array_nums;

class Program
{
    static void Main(string[] args)
    {
        int[] myarray = { 23, 45, 67, 89, 90, 45 };
        foreach (var item in myarray)
        {
            Console.WriteLine(item);
        }
    }
}
