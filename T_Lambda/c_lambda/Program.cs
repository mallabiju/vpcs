// lambda type : statement lambda
namespace c_lambda;

delegate void MyDel(int a, int b);

class Program
{
    static void Main(string[] args)
    {
        MyDel d = (a, b) =>
        {
            Console.WriteLine("The result = " + (a * b));
            Console.WriteLine("End of this program.");
        };
        d(10, 20);
    }
}
