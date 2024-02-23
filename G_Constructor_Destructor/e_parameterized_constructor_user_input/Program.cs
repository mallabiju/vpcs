namespace e_parameterized_constructor_user_input;
#nullable disable

class Student
{
    public int roll;
    public string name;
    public string address;
    public Student(int r, string n, string a)
    {
        roll = r;
        name = n;
        address = a;
    }
    public void displayInfo()
    {
        Console.WriteLine(name + " lives in " + address + " whose roll number is " + roll + ".");
    }
}
class Program
{
    static void Main(string[] args)
    {
        int sr;
        string sn, sa;
        Console.WriteLine("Enter roll number:");
        sr = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Name:");
        sn = Console.ReadLine();
        Console.WriteLine("Enter Address:");
        sa = Console.ReadLine();
        Student s1 = new Student(sr, sn, sa);
        s1.displayInfo();
    }
}

