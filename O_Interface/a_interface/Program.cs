namespace a_interface;

interface INepal
{
    public void hi();
}

class Country : INepal
{
    public void hi()
    {
        Console.WriteLine("Hello Nepal");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Country c1 = new Country();
        c1.hi();
    }
}
