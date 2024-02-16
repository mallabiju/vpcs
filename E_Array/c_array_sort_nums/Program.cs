namespace c_array_sort_nums;

class Program
{
    static void Main(string[] args)
    {
        int[] myarray = { 23, 45, 67, 89, 90, 4 };
        Array.Sort(myarray); // sorting an existing array in ascending order
        Array.Reverse(myarray); // sorting an existing array in decending order without sorting first
        foreach (var item in myarray)
        {
            Console.WriteLine(item);
        }
    }
}
