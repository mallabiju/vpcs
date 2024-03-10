namespace c_method_overloading_by_diff_sequence;


class MyClass
{
    public void displayDetails(int roll, string name)
    {
        Console.WriteLine(roll + " " + name);
    }
    public void displayDetails(string name, int roll)
    {
        Console.WriteLine(roll + " " + name);
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass obj = new MyClass();
        obj.displayDetails(23, "Ram");
        obj.displayDetails("Sita ", 22);
    }
}
