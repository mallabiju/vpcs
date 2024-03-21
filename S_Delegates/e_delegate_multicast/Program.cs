namespace e_delegate_multicast;

public delegate void MyDel(int a, int b);
class Calc
{
    // public static void add(int a, int b)
    public void add(int a, int b)
    {
        Console.WriteLine("The sum = " + (a + b));
    }
    // public static void mul(int a, int b)
    public void mul(int a, int b)
    {
        Console.WriteLine("The product = " + (a * b));
    }
    static void Main(string[] args)
    {
        Calc c1 = new Calc();
        /* MyDel d1 = new MyDel(Calc.add);
        MyDel d2 = new MyDel(Calc.mul); */ // When static
        MyDel d1 = new MyDel(c1.add);
        MyDel d2 = new MyDel(c1.mul);
        d1 = d1 + d2;
        d1(10, 20);
    }
}
