namespace a_static_class;

static class Shape
{
    public static int length = 89;
    public static int square()
    {
        return (length * length);
    }
    public static int cube(int a)
    {
        return (a * a * a);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("The length = " + Shape.length);
        Console.WriteLine("The square value = " + Shape.square());
        Console.WriteLine("The cube value = " + Shape.cube(5));
    }
}
