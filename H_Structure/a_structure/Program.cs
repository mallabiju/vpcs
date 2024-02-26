namespace a_structure;

struct Student
{
    public int age;

    public void getAge(int age)
    {
        Console.WriteLine("The age =" + age);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s1;
        s1.age = 23;
        s1.getAge(s1.age);
    }
}
