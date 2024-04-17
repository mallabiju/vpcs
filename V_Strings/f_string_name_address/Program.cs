namespace f_string_name_address;

class Program
{
    static void Main(string[] args)
    {
        string f = "Ram";
        string l = "Thapa";
        string address = "Kathmandu";
        Console.WriteLine(f + " " + l + " lives in " + address);
        Console.WriteLine("{0} {1} lives in {2}", f, l, address);
    }
}
