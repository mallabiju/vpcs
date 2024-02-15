namespace b_class_object_data_members;
#nullable disable

class Student
{
    int roll;
    string name;
    static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.roll = 67;
        s1.name = "Ram";
        Console.WriteLine("Roll = " + s1.roll);
        Console.WriteLine("Name = " + s1.name);
    }
}
