using System;


namespace uppgift3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3.1
            try
            {
                //Person person1 = new Person(20, "Pelle", "Väldigtlångtefternamne", 205, 90);
                //Console.WriteLine(person1.ToString());
                //Person person2 = new Person(-1, "Pelle", "Pettersson", 130, 90);
                //Console.WriteLine(person2.ToString());
                Person person3 = new Person(20, "U", "Fritsson", 205, 90);
                Console.WriteLine(person3.ToString());
            }
            catch (ArgumentException ex) //Se till att hantera undantagen i Program-klassen med en try-catch block.
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}