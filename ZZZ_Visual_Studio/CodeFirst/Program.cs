using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentContext context = new StudentContext();
            Student st = new Student()
            {
                Roll = 45,
                Name = "Ram",
                Address = "Bhaktapur"
            };
            context.Students.Add(st);
            context.SaveChanges();
            Console.WriteLine("Data inserted successfully.");
            Console.ReadLine();
        }
    }
}
