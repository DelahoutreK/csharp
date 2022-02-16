using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            
            string name = "Kenan";
            Console.WriteLine(name);

            const int number = 15, number2 = 10;
            Console.WriteLine(number);
            Console.WriteLine(number+number2);

            string hello = "Hello ";
            Console.WriteLine(hello+name);


            // split, USER INPUT PART
            Console.WriteLine("enter username");
            string username = Console.ReadLine();
            Console.WriteLine("Welcome "+username);
            Console.WriteLine("enter age");
            int age= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("you are " + age);
        }
    }
}
