namespace c_abstract;

abstract class MyClass
{
    public abstract void calculate(double x);
}

class SubClassOne : MyClass
{
    public override void calculate(double x)
    {
        Console.WriteLine("Square root = " + Math.Sqrt(x));
    }
}
class SubClassTwo : MyClass
{
    public override void calculate(double x)
    {
        Console.WriteLine("Square = " + (x * x));
    }
}
class SubClassThree : MyClass
{
    public override void calculate(double x)
    {
        Console.WriteLine("Cube = " + (x * x * x));
    }
}
class Program
{
    static void Main(string[] args)
    {
        SubClassOne obj1 = new SubClassOne();
        SubClassTwo obj2 = new SubClassTwo();
        SubClassThree obj3 = new SubClassThree();
        obj1.calculate(9);
        obj2.calculate(9);
        obj3.calculate(9);
    }
}
