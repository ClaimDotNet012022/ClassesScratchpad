

using System;
using System.Collections.Generic;

namespace ClassesScratchpad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate a Dog (create an instance of Dog):
            Dog dog = new Dog("Dog", 30);
            Dog rover = new Dog("Rover", 25);
            Dog rex = new Dog("Rex", 27);
                        

            Dog dog2 = rex;
            dog2.Name = "Not Rex";
            Console.WriteLine(rex.Name);

            Console.WriteLine(dog2.Name);


            rover.HeightInches = 25;
            rover.Color = "Red";
            rover.HairType = "short";
            rover.Name = "Rover";
            rover.Bark();
            rex.Run();

            rex.CelebrateBirthday();
            int rexAge = rex.Age;
            rex.CelebrateBirthday();

            //rex.RunAsAPack();
            Dog.RunAsAPack();

            Cat heathcliff = new Cat();
            //Cat.Name = "Cat";
            heathcliff.Name = "Heathcliff";
            Cat garfield = new Cat();
            garfield.Name = "Garfield";
            garfield.HairType = "long";
            string hair = garfield.HairType;

            heathcliff.PrintName();
            garfield.PrintName();


            //Program program = new Program();
            //int nine = Program.MultiplyByThree(3);


            Antelope ant1 = new Antelope(9, "South Africa");
            Antelope ant2 = new Antelope(14, "St. Louis Zoo");
            Antelope ant3 = new Antelope(6, "South Africa");

            Console.WriteLine(Antelope.HerdSize);
            Antelope.Stampede();

            ant1.Habitat = "Savannah";
            ant1.Speak();
            //ant1.SpeakAsAGenericAnimal();

            //StaticClassExample example = new StaticClassExample();
            StaticClassExample.DoSomething();



            Lizard lizard = new Lizard();
            lizard.Habitat = "Desert";
            lizard.Speak();


            //Animal animal = new Animal("Something");

            int i = (int)3.7;


            Dog myDog = new Dog("I'm a dog!", 27);
            Animal myAnimal = new Cat();
            //Cat myCat = new Dog("I'm not a cat", 29);
            //Dog myAnimal2 = new Animal("Someplace");

            if (myAnimal is Dog)
            {
                Dog animalAsDog = (Dog)myAnimal;
            }

            Object lizardAsObject = new Lizard();

            Lizard lizzy = (Lizard)lizardAsObject;

            Cat cat = new Cat();
            //Dog catAsDog = (Dog)cat;

            FeedAnimal(rex);
            FeedAnimal(heathcliff);
            FeedAnimal(ant1);
            FeedAnimal(lizzy);


            List<Animal> animals = new List<Animal>();
            animals.Add(rex);
            animals.Add(rover);
            animals.Add(garfield);
            animals.Add(heathcliff);
            animals.Add(ant1);
            animals.Add(lizzy);

            foreach(Animal animal in animals)
            {
                Console.WriteLine(animal.Habitat);
                animal.Speak();
            }


            garfield.Speak();
            ((Animal)garfield).Speak();



            IZooMember zooMember = new Antelope(12, "St. Louis Zoo");

            
        }


        public static void FeedAnimal(Animal animal)
        {
            animal.Eat("food");
        }

        public static int MultiplyByThree(int n)
        {
            return n * 3;
        }

    }





    // Value types:
    // Numeric built-in types (int, long, System.Int32, double, decimal, etc.)
    // struct

    // Reference types:
    // string
    // array
    // class
}
