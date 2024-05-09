namespace h_hashset_string;

class Program
{
    static void Main(string[] args)
    {
        HashSet<string> names = new HashSet<string>();
        names.Add("Ram");
        names.Add("Sita");
        names.Add("Laxman");
        names.Add("Hari");
        names.Add("Gita");
        names.Add("Nita");
        names.Add("Mita");
        names.Add("Tina");
        names.Add("Rina");

        // to remove an element
        // names.Remove("Gita");

        // to clear HashSet

        Console.WriteLine("Before Clear:");
        Console.WriteLine("Elements in hashset:");
        foreach (var item in names)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("After Clear:");
        names.Clear();

        Console.WriteLine("Elements in hashset:");
        foreach (var item in names)
        {
            Console.WriteLine(item);
        }
    }
}
