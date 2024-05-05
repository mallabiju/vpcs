namespace j_dictionary;

class Program
{
    static void Main(string[] args)
    {
        // creating a dictionary using collection-initializer syntax
        var subjects = new Dictionary<string, string>()
        {
            { "Education", "Nepali, English, Maths" },
            { "Science", "Physics, Chemistry, Biology, Medical" },
            { "Management", "Business, Finance, Account" }
        };

        /* Console.WriteLine(subjects["Education"]); // prints value of Education key
        Console.WriteLine(subjects["Humanities"]); // The given key 'Humanities' was not present in the dictionary.
        */

        /* //use ContainsKey() to check for an unknown key
        if (subjects.ContainsKey("Humanities"))
        {
            Console.WriteLine(subjects["Humanities"]);
        } */


        /* //use TryGetValue() to get a value of unknown key
        string? result;

        if (subjects.TryGetValue("Education", out result))
        {
            Console.WriteLine(result);
        } */

        //use ElementAt() to retrieve key-value pair using index
        for (int i = 0; i < subjects.Count; i++)
        {
            Console.WriteLine(
                "Key: {0}, Value: {1}",
                subjects.ElementAt(i).Key,
                subjects.ElementAt(i).Value
            );
        }

        // foreach (var kvp in subjects)
        //     Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
    }
}
