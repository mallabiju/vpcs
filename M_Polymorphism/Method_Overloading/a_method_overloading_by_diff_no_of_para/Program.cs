namespace a_method_overloading_by_diff_no_of_para;

class myCalc
{
    public int add(int a, int b)
    {
        return (a + b);
    }
    public int add(int a, int b, int c)
    {
        return (a + b + c);
    }
}
class Program
{
    static void Main(string[] args)
    {
        myCalc obj = new myCalc();
        Console.WriteLine("The sum = " + obj.add(23, 45));
        Console.WriteLine("The sum = " + obj.add(23, 45, 67));
    }
}
