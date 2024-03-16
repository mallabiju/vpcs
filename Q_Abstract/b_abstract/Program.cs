namespace b_abstract;

abstract class MyClass
{
    public int calc(int a, int b)
    {
        return (a + b);
    }
}

class YourClass : MyClass
{
    public int mul(int a, int b)
    // public int calc(int a, int b)
    {
        return (a * b);
    }
}
class Program
{
    static void Main(string[] args)
    {
        YourClass obj = new YourClass();
        int result = obj.calc(12, 3);
        Console.WriteLine("The result = {0}", result);
    }
}
