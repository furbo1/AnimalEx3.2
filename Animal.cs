using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalEx3._2
{

    interface Person
    {

        public string Talk();
    }
    abstract class Animal : Person
    {
        public string Name;
        public int Age;
        public double Weigth;
        
        public string Species;

        public Animal(string name, int age, double weigth, string animal)
        {
            Name = name;
            Age = age;
            Weigth = weigth;
           
            Species = animal;
         
            
        }

        public Animal()
        {

        }

        public string Talk()
        {
            return "I can talk like a human";
        }

        public virtual string DoSound( string animal)
        {
            
            animal = this.Species;
            var sound = "";

            if (animal == "Horse")
            {
                sound = "Hiiiiii";
                return sound;
            }
            else if (animal == "Dog")
            {
                sound = "Woff!!Woff!";
                return sound ;
            }
            else if (animal == "Wolf")
            {
                sound = "Auuuuuuuuu!";
                return sound ;
            }
            else if (animal == "Bird")
            {
                sound = "Cipcirip!Cipcirip!";
                return sound ;
            }
            else
            {
                return "no sound";
            }
        }

    }

    class Horse: Animal
    {
        public string Prop;
        public Horse(string name, int age, double weigth, string animal, string prop = "I run fast!") :base(name, age, weigth, animal)
        {
            Species = "Horse";
            Prop = prop;
            this.Galoop();
            this.DoSound("Horse");

        }

        public string Galoop()
        {
            return this.Prop;
        }

       
        
    }

    class Dog : Animal
    {
        public string Prop;
        public Dog(string name, int age, double weigth, string animal, string prop = "I am human's best friend!") : base(name, age, weigth, animal)
        {
            Species = "Dog";
            Prop = prop;
            this.HumansFriend();
            this.DoSound($"{this.Species}");

        }

        public string HumansFriend()
        {
            return this.Prop ;
        }

      
    }

    class HedgeHog : Animal
    {
        public string Sting;
        public HedgeHog(string name, int age, double weigth, string animal, string sting = "I sting all the foxes!") : base(name, age, weigth, animal)
        {
            Species = "Hedgehog";
            Sting = sting;
            this.ISting();
            this.DoSound($"{this.Species}");

        }

        public string ISting()
        {
            return this.Sting;
        }
    }
    class Wolf : Animal
    {
        public string Prop;
        public Wolf(string name, int age, double weigth, string animal, string prop = "I like full moons!") : base(name, age, weigth, animal)
        {
            Species = "Wolf";
            Prop = prop;
            this.Wolfy();
            this.DoSound($"{this.Species}");

        }

        public string Wolfy()
        {
            return this.Prop;
        }

    }
    class Bird : Animal
    {
        public string Sing;
        public Bird(string name, int age, double weigth, string animal, string sing = "I sing all day long in the forrest!") : base(name, age, weigth, animal)
        {
            Species = "Bird";
            Sing = sing;
            this.ISing();
            this.DoSound($"{this.Species}");

        }

        public virtual string ISing()
        {
            return this.Sing;
        }




    }
    class Worm : Animal
    {
        public string Crawl;
        public Worm(string name, int age, double weigth, string animal, string crawl = "I crawl slowly!") : base(name, age, weigth, animal)
        {
            Species = "Worm";
            Crawl = crawl;
            this.ICrawl();
            this.DoSound($"{this.Species}");

        }

        public string ICrawl()
        {
            return this.Crawl;
        }

    }

    class Pelican : Bird
    {
        public string Color = "White";
        public Pelican(string name, int age, double weigth, string animal, string sing ) : base(name, age, weigth, animal, sing)
        {
            Sing = "I don't like to sing";
            
           
            this.MyColor();

            Species = "Pelican";

        }
        public override string ISing()
        {
            return this.Sing;
        }

       

        public string MyColor()
        {
            return this.Color;
        }
    }

    class Flamingo : Bird
    {
        public string Color = "Pink";
        public Flamingo(string name, int age, double weigth, string animal, string sing = "I sing all day long in the forrest!") : base(name, age, weigth, animal, sing)
        {

            Species = "Flamingo";
            Sing = "I don't like to sing";
            this.MyColor();

        }

        public string MyColor()
        {
            return this.Color;
        }
    }

    class Swan : Bird
    {
        public string Color = "White";

        public Swan(string name, int age, double weigth, string animal, string sing = "I sing all day long in the forrest!") : base(name, age, weigth, animal, sing)
        {

            Species = "Swan";
            Sing = "I don't like to sing";

        }
        public string MyColor()
        {
            return this.Color;
        }
    }

    

    class Wolfman : Wolf, Person
    {
        
        public Wolfman(string name, int age, double weigth, string animal, string prop = "I like full moons!") : base(name, age, weigth, animal) 
        {
            Species = "Hybrid";
            this.Talk();
        }

      


    }


}
