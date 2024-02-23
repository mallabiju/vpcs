namespace i_copy_constructor;

class Student
{
    string name;
    int age;
    public Student(string name, int age) //paramertrized constructor
    {
        this.name = name;
        this.age = age;
    }
    public Student(Student d) //copy constructor
    {
        this.name = d.name;
        this.age = d.age;
    }
    public void getData()
    {
        Console.WriteLine("Name is:{0}", name);
        Console.WriteLine("Age is:{0}", age);
    }
}
class Program
{
    //main method
    static void Main(string[] args)
    {
        Student obj = new Student("Ram Thapa", 20);
        obj.getData();
        Student obj1 = new Student(obj); //new object
        obj1.getData();
        Console.ReadLine();
    }
}