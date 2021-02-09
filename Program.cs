using System;
using System.Collections.Generic;

namespace AnimalEx3._2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Horse horse = new Horse("", 10, 500, "");
            //Dog dog = new Dog("", 10, 500, "");
            //HedgeHog hedgehog = new HedgeHog("Spiky", 12, 12, "");
            //Wolf wolf = new Wolf("", 10, 500, "");
            //Bird bird = new Bird("", 10, 500, "");
            //Worm worm = new Worm("", 10, 500, "");
            //Pelican pelican = new Pelican("", 10, 500, "", "");
            //Flamingo flamingo = new Flamingo("", 10, 500, "", "");
            //Swan swan = new Swan("", 10, 500, "", "");
            //Wolfman wolfman = new Wolfman("", 10, 500, "", "");


            //Console.WriteLine($"I am a {horse.Species} and I make: {horse.DoSound()} and {horse.Galoop()}");
            //Console.WriteLine($"I am a {dog.Species} and I make: {dog.DoSound()} and {dog.HumansFriend()}");
            //Console.WriteLine($"I am a {hedgehog.Species} and I make: {hedgehog.DoSound()} and {hedgehog.ISting()}");
            //Console.WriteLine($"I am a {wolf.Species} and I make: {wolf.DoSound()} and {wolf.Wolfy()} ");
            //Console.WriteLine($"I am a {bird.Species} and I make: {bird.DoSound()} and {bird.ISing()}");
            //Console.WriteLine($"I am a {worm.Species} and I make: {worm.DoSound()} and {worm.ICrawl()}");
            //Console.WriteLine($"I am a {pelican.Species} and I make: {pelican.DoSound()} and {pelican.ISing()} and my color is {pelican.MyColor()}");
            //Console.WriteLine($"I am a {flamingo.Species} and I make: {flamingo.DoSound()} and {flamingo.ISing()} and my color is {flamingo.MyColor()}");
            //Console.WriteLine($"I am a {swan.Species} and I make: {swan.DoSound()} and {swan.ISing()} and my color is {swan.MyColor()}");
            //Console.WriteLine($"I am a {wolfman.Species} and I make: {wolfman.DoSound()}  and {wolfman.Wolfy()} and {wolfman.Talk()} ");

            List<Animal> animals = new List<Animal>
            {
            new Horse("", 10, 500, ""),
            new Dog("", 10, 500, ""),
            new HedgeHog("Spiky", 12, 12, ""),
            new Wolf("", 10, 500, ""),
            new Bird("", 10, 500, ""),
            new Worm("", 10, 500, ""),
            new Pelican("", 10, 500, "", ""),
            new Flamingo("", 10, 500, "", ""),
            new Swan("", 10, 500, "", ""),
            new Wolfman("", 10, 500, "", ""),
            };

            foreach (var animal in animals)
            {
                Console.WriteLine($"I am a {animal.Species} and I make: {animal.DoSound()}");
               
                if (animal is Person)
                {
                    var person = (Person)animal;
                    Console.WriteLine(person.Talk());
                }

                if (animal is Horse)
                {
                    var horse = (Horse)animal;
                    Console.WriteLine($"Gallop: {horse.Galoop()}");
                }
            }

        }
        
        
        
    }
}
