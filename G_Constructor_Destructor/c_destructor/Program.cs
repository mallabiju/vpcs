namespace c_destructor;

class Employee
{
    public Employee()
    {
        Console.WriteLine("Constructor called.");
    }
    ~Employee()
    {
        Console.WriteLine("Destructor called.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Employee e1 = new Employee();
    }
}
