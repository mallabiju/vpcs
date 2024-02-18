namespace d_array_sort_string;

class Program
{
    static void Main(string[] args)
    {
        string[] names = new string[] { "Ram", "Sita", "Hari", "Gita", "Nita" };
        int len = names.Length;
        Array.Sort(names);
        Array.Reverse(names);
        Console.WriteLine("The length of array elements = " + len);
        for (int i = 0; i < len; i++)
        {
            Console.WriteLine("Name [{0}] = {1}", i, names[i]);
        }
    }
}
