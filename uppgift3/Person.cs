using System;


namespace uppgift3
{
    internal class Person
    {


        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;



        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Ålder kan inte vara negativt.");
                }
                age = value;
            }
        }

        //FName är obligatorisk och får inte vara mindre än 
        //2 tecken eller längre än 10 tecken
        public string FName
        {
            get
            {
                return fName;
            }
            set
            {
                if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException($"Förnamnet ska vara minst två tecken. Men ej längre än 10 tecken.");
                }
                fName = value;
            }

        }
        //LName är obligatorisk och får inte vara mindre än 3 tecken eller större än 15
        //tecken.

        public string LName
        {
            get
            { return lName; }
            set
            {
                if (value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException($"Efternamnet ska vara 3 till 15 tecken.");
                }
                lName = value;
            }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public Person(int age, string fName, string lName, double height, double weight)
        {
            Age = age;
            FName = fName;
            LName = lName;
            Height = height;
            Weight = weight;
        }
        public override string ToString()
        {
            return $"Name: {FName} {LName} Age: {Age} Height: {height} Weight: {weight}";
        }
    }
}