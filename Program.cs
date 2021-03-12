using System;


//Methods | C# | Tutorial 12

namespace CSharpExercises_12
{

    class Program
    {
        static void Main(string[] args)
        {
            // This calls the method below
            //SayHi();
            // This calls the method below and we pass arguments to the method
            SayHi("Mike", 33);
            SayHi("John", 56);
            SayHi("Tom", 12);

            Console.ReadLine();
        }

        // creating a method here
        // return type > void will not return anything

        // static void SayHi()
        //{
        //    Console.WriteLine("Hello User");


        //}

        //here we pass arguments to the method
        static void SayHi(string name, int age)
        {
            //Console.WriteLine("Hello User");
            Console.WriteLine("Hello " + name + " you are " + age);

        }
    }
}
