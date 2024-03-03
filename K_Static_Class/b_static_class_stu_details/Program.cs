namespace b_static_class_stu_details;

static class Student
{
    public static string firstName = "Ram";
    public static string lastName = "Thapa";
    public static int marks = 78;

    public static void displayDetails()
    {
        Console.WriteLine("The details of the students :");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student.displayDetails();
        Console.WriteLine("First name = " + Student.firstName);
        Console.WriteLine("Last name = " + Student.lastName);
        Console.WriteLine("Obtained marks = " + Student.marks);
    }
}
