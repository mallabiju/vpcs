namespace b_array_string;

class Program
{
    static void Main(string[] args)
    {
        char[] myarray = { 'H', 'E', 'L', 'O' };
        foreach (var item in myarray)
        {
            // Console.Write(item);
            Console.Write("\t {0}", item);
        }
    }
}