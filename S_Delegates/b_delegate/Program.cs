﻿namespace b_delegate;

public delegate void MyDel(int num);

class MyNum
{
    public static void square(int num)
    {
        Console.WriteLine("The square = " + (num * num));
    }
    public static void cube(int num)
    {
        Console.WriteLine("The cube = " + (num * num * num));
    }
}
class Program : MyNum
{
    static void Main(string[] args)
    {
        MyDel md1 = square;
        md1.Invoke(5);
        MyDel md2 = cube;
        md2(3);
    }
}
