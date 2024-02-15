namespace a_class_object_method;

class Student
{
    public void hello()
    {
        Console.WriteLine("Hello Students!");
    }
    static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.hello();
    }
}
