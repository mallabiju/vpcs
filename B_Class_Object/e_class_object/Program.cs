namespace e_class_object;
#nullable disable

public class Student
{
    public int roll;
    public string name;

    public void input(int r, string n)
    {
        roll = r;
        name = n;
    }
    public void output()
    {
        Console.WriteLine("Roll = " + roll);
        Console.WriteLine("Name = " + name);
    }
}
class StudentDemo
{
    static void Main(string[] args)
    {
        Student st1 = new Student();
        Student st2 = new Student();
        st1.input(23, "Ram Thapa");
        st2.input(22, "Sita Rai");
        st1.output();
        st2.output();
    }
}

