namespace a_method_overriding;

public class Dad
{
    public void hello()
    {
        Console.WriteLine("Hello from your dad");
    }
}
public class Child : Dad
{
    // public void hello()
    public new void hello()
    {
        Console.WriteLine("Hello from your child");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Child c1 = new Child();
        c1.hello();
    }
}
