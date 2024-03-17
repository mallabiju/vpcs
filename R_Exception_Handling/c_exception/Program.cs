namespace c_exception;

class MyClass
{
    public int divide(int a, int b)
    {
        int result = a / b;
        return result;
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass obj = new MyClass();
        Console.WriteLine("Enter dividend:");
        int dividend = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter divisor:");
        int divisor = Convert.ToInt32(Console.ReadLine());
        try
        {
            Console.WriteLine("The result = " + obj.divide(dividend, divisor));
        }
        catch (Exception)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
    }
}
