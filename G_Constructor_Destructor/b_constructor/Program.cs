﻿namespace b_constructor;

class Teacher
{
    public Teacher()
    {
        Console.WriteLine("Hello Teacher");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Teacher t1 = new Teacher();
    }
}
