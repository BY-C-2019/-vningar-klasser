using System;
using System.Collections.Generic;

namespace excercises_classes
{
    class Program

    {



        static void Main(string[] args)
        {   List <Animal> lista = new List<Animal>();
             bool avsluta= true;
             string name="";
             int age=0;
             string race="";

            while(avsluta)
            {
                Console.WriteLine("Välkommen till funktionen lägg till djur!\n"+
                "[1] Lägg till Hund.\n"+
                "[2] Lägg till Katt.\n"+
                "[3] Lista alla djur\n"+
                "[4] Avsluta");
                Int32.TryParse(Console.ReadLine(),out int val);

                switch(val)
                {
                    case 1:
                    
                    
                    Dog dog = new Dog();
                    
                    Console.WriteLine("Vad heter din hund?");
                    name = Console.ReadLine();
                    dog.name=name;
                    Console.WriteLine("Hur gammal är den?");
                    Int32.TryParse(Console.ReadLine(),out age);
                    dog.age = age;
                    Console.WriteLine("Vad är din hund för ras?");
           
                    race= Console.ReadLine();
                    dog.race=race;
                    lista.Add(dog);
                    dog.Bark();
                    dog.Fetch();
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                        break;

                    case 2:
                    
                    
                    Cat cat  = new Cat();

                   
                    Console.WriteLine("Vad heter din Katt?");
                    name = Console.ReadLine();
                    cat.name=name;
                    Console.WriteLine("Hur gammal är den?");
                    Int32.TryParse(Console.ReadLine(),out age);
                    cat.age = age;
                    Console.WriteLine("Vad är din katt för ras?");
           
                    race= Console.ReadLine();
                    cat.race=race;
                    lista.Add(cat);
                    cat.Meow();
                    cat.Fetch();
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                        break;

                    case 3:
                    foreach (var item in lista)
                    {
                        Console.WriteLine(item);
                    }
                      Console.ReadLine();
                      Console.Clear();
                    
                        break;
                    case 4:
                    avsluta = false;
                        break;
                }
            }

        }


        
        
    }
}
