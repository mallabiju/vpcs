namespace a_string_builder_append_format;

using System.Text;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder s = new StringBuilder("The cost of this mobile phone is = ");
        s.AppendFormat("{0:C}", 999.99);
        Console.WriteLine(s);
    }
}
