namespace b_string_builder_append;

using System.Text;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder s = new StringBuilder("Hello", 20);
        s.Append("Hi");
        s.AppendLine("Sanothimi");
        s.Append("Kathmandu");
        Console.WriteLine(s);
    }
}
