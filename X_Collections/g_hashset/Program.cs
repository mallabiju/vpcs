namespace g_hashset;

class Program
{
    static void Main(string[] args)
    {
        HashSet<int> MyIntHash = new HashSet<int>() { 12, 34, 5, 6, 78, 90, 22 };
        Console.WriteLine("Elements in hashset : ");
        foreach (var item in MyIntHash)
        {
            Console.WriteLine(item);
        }
    }
}
