using System;
namespace excercises_classes

{
    public class Animal
    {
        public int age  {get; set;}

        public string name {get; set;}

        public string race {get; set;}
        
        
    public void Meow()
    {
        Console.WriteLine(name +" jamar!");
    }
        public void Bark()
        {
            Console.WriteLine(name +" skäller!");
            
        }
        public void Fetch()
        {
            Console.WriteLine(name +" säger Nej!!");
        }
    }
        public class Dog : Animal 
        {
            public override string ToString()
            {
                    return "Djuret är en Hund av rasen "+race+". Den är "+age+" år gammal och heter "+name+".";
            }
        
            public  Dog():base()
            {
                name = "Bosse";
                age = 3;
                race = "Dalmatiner";
                Console.Clear();
                Console.WriteLine("Min hund heter "+name+". Han är "+age+" år gammal och är av rasen "+race+".");

            }
        }
         public class Cat : Animal 
        {
            public override string ToString()
            {
                    return "Djuret är en katt av rasen "+race+". Den är "+age+" år gammal och heter "+name+".";
            }
            public Cat():base()
            {
                    name ="Sune";
                    age = 1;
                    race = "Bondkatt";
                    Console.Clear();
                    Console.WriteLine("Min katt heter "+name+". Han är "+age+" år gammal och är av rasen "+race+".");

            }
        }



    
}