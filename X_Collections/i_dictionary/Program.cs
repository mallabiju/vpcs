namespace i_dictionary;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> rollnames = new Dictionary<int, string>();
        rollnames.Add(1, "Ram");
        rollnames.Add(3, "Laxman");
        rollnames.Add(2, "Sita");

        foreach (KeyValuePair<int, string> kvp in rollnames)
        {
            Console.WriteLine("Key : {0} and value : {1} ", kvp.Key, kvp.Value);
        }
    }
}
