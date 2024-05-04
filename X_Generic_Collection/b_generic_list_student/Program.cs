namespace b_generic_list_student;

using System.Collections.Generic;
#nullable disable

public class Student
{
    public int Roll { get; set; }
    public string Name { get; set; }
}

public class Program
{
    static void Main(string[] args)
    {
        var students = new List<Student>()
        {
            new Student() { Roll = 23, Name = "Ram Thapa" },
            new Student() { Roll = 21, Name = "Sita Rai" },
            new Student() { Roll = 1, Name = "Hari Timilsina" },
            new Student() { Roll = 90, Name = "Rajesh Hamal" }
        };

        var studNames =
            from s in students
            // where s.Name == "Hari Timilsina"
            select s;
        foreach (var student in studNames)
        {
            Console.WriteLine(student.Roll + " " + student.Name);
        }
    }
}
