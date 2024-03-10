namespace b_method_overloading_by_diff_data_types;

class MyNum
{
    public int add(int a, int b)
    {
        return (a + b);
    }
    public double add(double a, double b)
    {
        return (a + b);
    }
    public string add(string a, string b)
    {
        return (a + b);
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyNum obj = new MyNum();
        Console.WriteLine("The sum of integers = " + obj.add(12, 34));
        Console.WriteLine("The sum of doubles = " + obj.add(12.34, 34.55));
        Console.WriteLine("The concatenation of strings = " + obj.add("Ram ", "Sita"));
    }
}
