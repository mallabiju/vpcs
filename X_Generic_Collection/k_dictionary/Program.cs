namespace k_dictionary;

class Program
{
    static void Main(string[] args)
    {
        bool found = false;
        List<Tuple<string, string>> credentials = new List<Tuple<string, string>>
        {
            new Tuple<string, string>("ram", "ram123"),
            new Tuple<string, string>("krishna", "k123"),
            new Tuple<string, string>("hari", "h123")
        };

        //Dictionary<string, string> credentials = new Dictionary<string, string>
        //{
        //    { "ram", "ram123"},
        //    { "krishna", "k123"},
        //    { "hari", "h123"},
        //};
        Console.WriteLine("Enter username");
        string u = Console.ReadLine();
        Console.WriteLine("Enter password");
        string p = Console.ReadLine();

        foreach (Tuple<string, string> c in credentials)
        {
            if (c.Item1 == u && c.Item2 == p)
            {
                found = true;
                break;
            }
        }
        //if(credentials.ContainsKey(u))
        //{
        //    if(credentials[u] == p)
        //    {
        //        found = true;
        //    }
        //}

        if (found)
        {
            Console.WriteLine("Welcome {0}", u);
        }
        else
        {
            Console.WriteLine("Invalid username/password");
        }
    }
}
