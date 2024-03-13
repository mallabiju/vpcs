namespace c_interface_same_method;


interface IStudent
{
    public void exam();
}
interface ITeacher
{
    public void exam();
}

public class College : IStudent, ITeacher
{
    void IStudent.exam()
    {
        Console.WriteLine("I'm a student.");
    }
    void ITeacher.exam()
    {
        Console.WriteLine("I'm a teacher.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        IStudent is1 = new College();
        is1.exam();
        ITeacher it1 = new College();
        it1.exam();
    }
}
