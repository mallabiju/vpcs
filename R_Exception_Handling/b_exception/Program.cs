namespace b_exception;

class Program
{
    static void Main(string[] args)
    {
        // int a = 10, b = 4, result = 0;
        int a = 10, b = 0, result = 0;
        try
        {
            result = a / b;
            Console.WriteLine("The result = " + result);
        }
        catch (Exception e)
        {
            Console.WriteLine(e + " divisor cannot be zero.");
        }

    }
}
