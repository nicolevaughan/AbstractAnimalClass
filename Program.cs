namespace AbstractAnimalClass
{
    abstract class Animal
    {
        // Property
        public abstract string Name { get; set; }
        // Methods
        public abstract string Describe();
        public string whatAmI()
        {
            return "I am an animal\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
        }
    }
    class Program
    {
        class Bird : Animal
        {
            //override the abstract property
            public override string Name { get; set; }
            public string Type { get; set; }
            public string Food { get; set; }
            public Bird()
            {
                Name = string.Empty;
                Type = string.Empty;
                Food = string.Empty;
            }

            public Bird(string name, string type, string food)
            {
                Name = name;
                Type = type;
                Food = food;
            }
            //override the abstract method
            public override string Describe() 
            {
                return "I am a " + Type + "\nMy name is " + Name + "\nI like to eat " + Food+ "\n";
            }

        }
        static void Main(string[] args)
        {
            //Create Bird Object
            Bird bird = new Bird();
            bird.Name = "Pablo";
            bird.Type = "Penguin";
            bird.Food = "Fish";
            Console.WriteLine(bird.whatAmI());
            Console.WriteLine(bird.Describe());

            //parameterized
            Bird birdy = new Bird("Petey","Parrot","Crackers");
            Console.WriteLine(birdy.whatAmI());
            Console.WriteLine(birdy.Describe());
        }
    }
}