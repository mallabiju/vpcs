namespace b_structure;

struct Student
{
    public int roll;
    public string name;
    public int age;
    public string address;
    public string phone;
}
class Program
{
    static void Main(string[] args)
    {
        Student s1;
        Student s2;

        s1.roll = 101;
        s1.name = "Ram";
        s1.age = 20;
        s1.address = "Kathmandu";
        s1.phone = "9876543210";
        s2.roll = 103;
        s2.name = "Sangita";
        s2.age = 21;
        s2.address = "Dharan";
        s2.phone = "9087654345";


        Console.WriteLine("Roll: " + s1.roll);
        Console.WriteLine("Name: " + s1.name);
        Console.WriteLine("Age: " + s1.age);
        Console.WriteLine("Address: " + s1.address);
        Console.WriteLine("Phone: " + s1.phone);
        Console.WriteLine();
        Console.WriteLine("Roll: " + s2.roll);
        Console.WriteLine("Name: " + s2.name);
        Console.WriteLine("Age: " + s2.age);
        Console.WriteLine("Address: " + s2.address);
        Console.WriteLine("Phone: " + s2.phone);
    }
}

