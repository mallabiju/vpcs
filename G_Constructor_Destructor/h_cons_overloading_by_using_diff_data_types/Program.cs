namespace h_cons_overloading_by_using_diff_data_types;

#nullable disable

public class Add
{
    int a, b;
    double d;
    string s;
    // constructor one
    public Add(int x, double y)
    {
        a = x;
        d = y;
    }
    // constructor two
    public Add(int x, string y)
    {
        a = x;
        s = y;
    }
    public void displayOne()
    {
        Console.WriteLine("The result (int + double) = " + (a + d));
    }
    public void displayTwo()
    {
        Console.WriteLine("The result (string + int) = " + (s + a));
    }
}
class Program
{
    static void Main(string[] args)
    {
        Add a1 = new Add(10, 20.5);
        a1.displayOne();
        Add a2 = new Add(23, "Roll number is ");
        a2.displayTwo();
    }
}

