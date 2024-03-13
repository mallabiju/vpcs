namespace d_interface_inherit_interface;


interface IOne
{
    public void methodOne();
}
interface ITwo
{
    public void methodTwo();
}
interface IThree : IOne, ITwo
{
    public void methodThree();
}
class Program : IThree
{
    void IOne.methodOne()
    {
        Console.WriteLine("I am the body of method from Interface One.");
    }
    void ITwo.methodTwo()
    {
        Console.WriteLine("I am the body of method from Interface Two.");
    }
    void IThree.methodThree()
    {
        Console.WriteLine("I am the body of method from Interface Three.");
    }
    static void Main(string[] args)
    {
        IThree it1 = new Program();
        it1.methodOne();
        it1.methodTwo();
        it1.methodThree();
    }
}
