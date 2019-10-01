using System;

namespace excercises_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog= new Dog();

            Console.Write("Name:");
            string name=Console.ReadLine();
            myDog.Name=name;

            Console.Write("Age:");
            int age=Convert.ToInt32(Console.ReadLine());
            myDog.Age=age;

            Console.Write("Race:");
            string race=Console.ReadLine();
            myDog.Race=race;

            myDog.Info();
            Console.WriteLine("----------------------------");
            myDog.Bark();
        }
    }
}
