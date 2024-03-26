namespace d_lambda;

delegate int MyDel(int a, int b);

class Program
{
    static void Main(string[] args)
    {
        MyDel d = (a, b) => a > b ? a : b;
        int result = d(10, 20);
        Console.WriteLine("The larger value = " + result);
    }
}
