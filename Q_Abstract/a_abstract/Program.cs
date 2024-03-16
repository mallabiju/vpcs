namespace a_abstract;


public abstract class HelloNepal
{
    public abstract void hello();
}

class Kathmandu : HelloNepal
{
    public override void hello()
    {
        Console.WriteLine("Hello from Kathmandu");
    }
}
class Bhaktapur : HelloNepal
{
    public override void hello()
    {
        Console.WriteLine("Hello from Bhaktapur");
    }
}
class Program
{
    static void Main(string[] args)
    {
        HelloNepal h;
        h = new Kathmandu();
        h.hello();
        h = new Bhaktapur();
        h.hello();
    }
}
