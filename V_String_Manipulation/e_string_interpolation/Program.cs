namespace e_string_interpolation;

class Program
{
    static void Main(string[] args)
    {
        // 1. use of $ symbol
        // var name = "Ram";
        // var gratitude = "Namaste";

        // string greetings = $"{gratitude} Sita ko Buda {name}";
        // Console.WriteLine(greetings);

        var a = 5;
        var result = $"The square of {a} = {a * a}";
        Console.WriteLine(result);

        // 2. use of string.Format()

        // var name = "Ram";

        // var greeting = string.Format("Hello {0}, {1} !", name, "Namaste");
        // Console.WriteLine(greeting);

        string name = "Ram";
        string msg = $"Hello {name}.";
        Console.WriteLine(msg);
    }
}
