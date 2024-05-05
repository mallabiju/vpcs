namespace l_sortedlist;
#nullable disable

class Program
{
    static void Main(string[] args)
    {
        SortedList<int, string> rollNames = new SortedList<int, string>();
        rollNames.Add(1, "Ram");
        rollNames.Add(3, "Laxman");
        rollNames.Add(12, "Sita");
        rollNames.Add(7, "Tina");
        rollNames.Add(10, null);
        rollNames.Add(4, "Hina");
        rollNames.Add(6, "Rita");
        rollNames.Add(9, "Sumnima");
        rollNames.Add(8, "Hari");

        rollNames[10] = "Sangita"; // assign with a value if there is not
        rollNames[8] = "Rajesh"; // Update a value


        Console.WriteLine(rollNames[3]); // Laxman

        foreach (var item in rollNames)
        {
            Console.WriteLine("Key : {0} and value : {1} ", item.Key, item.Value);
        }


        //The following will throw exceptions
        //rollNames.Add("Jack", 2); //Compile-time error: key must be int type
        //rollNames.Add(1, "Ravan"); //Run-time exception: duplicate key
        //rollNames.Add(null, "Anne");//Run-time exception: key cannot be null
    }
}
