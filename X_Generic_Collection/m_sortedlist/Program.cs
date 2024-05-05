namespace m_sortedlist;

class Program
{
    static void Main(string[] args)
    {
        //Creating a SortedList of string keys, string values
        //using collection-initializer syntax
        SortedList<string, string> cities = new SortedList<string, string>()
        {
            { "London", "Nepal" },
            { "Delhi", "India" },
            { "Beijing", "China" },
            { "Tokyo", "Japan" }
        };
        foreach (var kvp in cities)
            Console.WriteLine("Key:{0}, Value:{1}", kvp.Key, kvp.Value);
    }
}
