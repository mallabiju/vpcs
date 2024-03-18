namespace e_exception;

class Program
{
    static void Main(string[] args)
    {
        string[] names = { "Ram", "Sita", "Laxman" };

        try
        {
            // Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);
        }
        catch (System.Exception e)
        {
            Console.WriteLine("Exception found " + e);
        }
    }
}
