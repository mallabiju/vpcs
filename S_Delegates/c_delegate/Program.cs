namespace c_delegate;

delegate int NumberCalc(int num);

class Program
{
    static int num = 10;
    public static int AddNum(int a){
        num+=a;
        return num;
    }
    public static int MulNum(int b){
        num*=b;
        return num;
    }
    public static int GetNum(){
        return num;
    }
    static void Main(string[] args)
    {
        NumberCalc nc1 = new NumberCalc(AddNum);
        NumberCalc nc2 = new NumberCalc(MulNum);
        nc1(20);
        Console.WriteLine("The new value = {0}", GetNum());
        nc2(10);
        Console.WriteLine("The new value = {0}", GetNum());
    }
}
