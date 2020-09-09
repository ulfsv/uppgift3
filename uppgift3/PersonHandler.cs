using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace uppgift3
{
    //3.1.2 Klass för att inkapsla Person-objekten ytterligare 
    public class PersonHandler
    {
        internal void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        //3.1.3 I PersonHandler skriv en metod som skapar en Person
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            return new Person(age, fname, lname, height, weight);
        }

        //3.1.4 Fortsätt skapa metoder föratt hantera samtliga  operationer som man kan vilja göra med en Person e.g GetAge(Person pers):
    }
}
