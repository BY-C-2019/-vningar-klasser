using System;

namespace excercises_classes
{
    class Dog
    {
        private string name;
        private int age;
        private string race;

       
        public string Name
        {
            get{
                return name;
            } set{
                name=value;
            }
        }
        public int Age
        {
            get{
                return age;
            } set{
                age=value;
            }
        }
        public string Race
        {
            get{
                return race;
            } set{
                race=value;
            }
        }

        public void Info()
        {
            Console.WriteLine("Din hund heter "+name+". "+name+" är "+age+" gammal och är en "+race);
        }
        public void Bark()
        {
            Console.WriteLine(name+" skäller! voff voff");
        }

    }

}