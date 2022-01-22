using System;

namespace ClassesScratchpad
{
    public class Dog : Animal
    {
        public string Name { get; set; }
        //public string HairType { get; set; }
        //public int HeightInches { get; set; }

        //public string Color { get; set; }

        //public int Age { get; private set; }

        public Dog(string name, int height) : base("Domestic")
        {
            Name = name;
            HeightInches = height;
        }

        public Dog() : base("Domestic")
        {
            Age = 0;
        }

        private string ComputeBirthdayMessage()
        {
            if (Age == 1)
            {
                return $"{Name} is now {Age} year old!";
            }
            else
            {
                return $"{Name} is now {Age} years old!";
            }
        }

        public void Bark()
        {
            Console.WriteLine("Ruff!");
        }

        public override void Speak()
        {
            Bark();
        }

        public void Run()
        {
            // Do something here
        }

        public void CelebrateBirthday()
        {
            //Age++;
            string message = ComputeBirthdayMessage();
            Console.WriteLine(message);
        }


        public static void RunAsAPack()
        {
            Console.WriteLine("All the dogs run in a pack together!");
        }
    }
}
