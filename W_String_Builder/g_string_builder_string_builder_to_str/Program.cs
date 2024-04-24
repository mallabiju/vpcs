namespace g_string_builder_string_builder_to_str;

using System.Text;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder s = new StringBuilder("Hello, Sanothimi");
        string str = s.ToString();
        Console.WriteLine(str);
    }
}
