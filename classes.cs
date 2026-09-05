using System;

Dog dog1 = new Dog();

dog1.Name = "Tabor";
dog1.Breed = "Mutt";
dog1.Age = 9;

Dog dog2 = new Dog();

dog2.Name = "Fiona";
dog2.Breed = "Chocolate Lab";
dog2.Age = 7;

Dog dog3 = new Dog();

dog3.Name = "Rimey";
dog3.Breed = "Catahoula";
dog3.Age = 6;

Cat cat1 = new Cat();

cat1.Name = "Fyodor";
cat1.Breed = "Domestic Longhair";
cat1.Age = 6;

Cat cat2 = new Cat();

cat2.Name = "Tiny";
cat2.Breed = "Domestic Shorthair";
cat2.Age = 3;

Bird bird1 = new Bird();

bird1.Name = "Borscht";
bird1.Species = "Ostrich";
bird1.Age = 5;

Bird bird2 = new Bird();

bird2.Name = "Falco";
bird2.Species = "Starfighter";
bird2.Age = 7;

Shelter shelter1 = new Shelter();

shelter1.Name = "THE GOOD PLACEHOLDER ANIMAL SHELTER";

shelter1.DisplayName();

dog1.DisplayInfo();
dog2.DisplayInfo();
dog3.DisplayInfo();
cat1.DisplayInfo();
cat2.DisplayInfo();
bird1.DisplayInfo();
bird2.DisplayInfo();

//I recognize that this is not doing what I want it to do. I don't have the knowledge to make it do what I want it to do. Ideally the shelter would know the amount of animals and also I would have input in this program for well user input
shelter1.FeedAnimals();
//Let's just say that this is putting food in their bowls its up to them to eat it
dog1.Sleep();
dog2.Bark();
dog3.Eat();
cat1.Eat();
cat2.Run();
bird1.Eat();
bird2.Chirp();
dog1.Play();
dog2.Eat();
dog3.Run();
cat1.Sleep();
cat2.Meow();
bird1.Sleep();
bird2.Fly();

dog1.DisplayInfo();
dog2.DisplayInfo();
dog3.DisplayInfo();
cat1.DisplayInfo();
cat2.DisplayInfo();
bird1.DisplayInfo();
bird2.DisplayInfo();

//CAT CLASS---------------------------------------------------------------
class Cat
{
    public string Name = "";
    public string Breed = "";
    public int Age;
    public int Energy = 5;
    
    public void Meow()
    {
        Console.WriteLine($"{Name}: Meow!");
    }
    public void BreedCheck()
    {
        Console.WriteLine($"{Name} is a {Breed}");
    }
    public void AgeCheck()
    {
        Console.WriteLine($"{Name} is {Age} Years Old");
    }
    //I established a ceiling, so I may as well establish a floor
    public void Play()
    {
        if (Energy > 0)
        {
            Console.WriteLine($">{Name} plays with you (-1 Energy)");
            Energy = Energy-1;
        }
        else
        {
            Console.WriteLine($">{Name} is too tired to play (No Energy)");
        }
    }
    //Adding run because I want tiny to run. its what she does. she runs off
        public void Run()
    {
        if (Energy > 0)
        {
            Console.WriteLine($">{Name} runs off (-1 Energy)");
            Energy = Energy-1;
        }
        else
        {
            Console.WriteLine($">{Name} is too tired to run (No Energy)");
        }
    }
    public void Eat()
    {
        if (Energy < 10)
        {
            Console.WriteLine($">{Name} Eats Food (+2 Energy)");
            Energy = Energy + 2;
        }
        else
        {
            Console.WriteLine($">{Name} isn't hungry right now (Max Energy)");
        }
    }
    //Changed to sleep from a run method. Will tie into energy. 
    public void Sleep()
    {
        if (Energy < 10)
        {
            Console.WriteLine($">{Name} slumbers sleepily (+1 Energy)");
            Energy = Energy + 1;
        }
        else
        {
            Console.WriteLine($">{Name} isn't tired right now (Max Energy)");
        }
    }
    public void EnergyTest()
    {
        Console.WriteLine("------------------------");
        Console.WriteLine($"Energy: {Energy}");
    }
    public void DisplayInfo()
    {
        //Putting the separators on top. Why? I don't know which would be better. Would it make that much of a difference? This is beyond the scope.
        Console.WriteLine("------------------------");
        Console.WriteLine("ANIMAL: CAT");
        Console.WriteLine($"NAME: {Name}");
        Console.WriteLine($"BREED: {Breed}");
        Console.WriteLine($"AGE: {Age}");
        Console.WriteLine($"ENERGY: {Energy}");
    }
}
//DOG CLASS----------------------------------------------------------
class Dog
{
    public string Name = "";
    public string Breed = "";
    public int Age;
    public int Energy = 5;

    public void Bark()
    {
        Console.WriteLine($"{Name}: Bark!");
    }
    public void BreedCheck()
    {
        Console.WriteLine($"{Name} is a {Breed}");
    }
    public void AgeCheck()
    {
        Console.WriteLine($"{Name} is {Age} Years Old");
    }
    public void Run()
    {
        if (Energy > 0)
        {
            Console.WriteLine($">{Name} runs around (-1 Energy)");
            Energy = Energy-1;
        }
        else
        {
            Console.WriteLine($">{Name} is too tired to run around (No Energy)");
        }
    }
    public void Play()
    {
        if (Energy > 0)
        {
            Console.WriteLine($">{Name} plays with you (-1 Energy)");
            Energy = Energy-1;
        }
        else
        {
            Console.WriteLine($">{Name} is too tired to play (No Energy)");
        }
    }
    public void Eat()
    {
        if (Energy < 10)
        {
            Console.WriteLine($">{Name} Eats Food (+2 Energy)");
            Energy = Energy + 2;
        }
        else
        {
            Console.WriteLine($">{Name} isn't hungry right now (Max Energy)");
        }
    }
    //Changed to sleep from a run method. Will tie into energy. 
    /// Decided to utilize both methods for dogs
    public void Sleep()
    {
        if (Energy < 10)
        {
            Console.WriteLine($">{Name} slumbers sleepily (+1 Energy)");
            Energy = Energy + 1;
        }
        else
        {
            Console.WriteLine($">{Name} isn't tired right now (Max Energy)");
        }
    }
    public void EnergyTest()
    {
        Console.WriteLine("------------------------");
        Console.WriteLine($"Energy: {Energy}");
    }
    public void DisplayInfo()
    {
        Console.WriteLine("------------------------");
        Console.WriteLine($"ANIMAL: DOG");
        Console.WriteLine($"NAME: {Name}");
        Console.WriteLine($"BREED: {Breed}");
        Console.WriteLine($"AGE: {Age}");
        Console.WriteLine($"ENERGY: {Energy}");
    }
}
//BIRD CLASS-------------------------------------------------------
class Bird
{
    //I am omitting Breed as a bird attribute. I don't know birds.
    //Goddamnit species is required. Okay.
    public string Name = "";
    public string Species = "";
    public int Age;
    public int Energy = 5;

    public void Chirp()
    {
        Console.WriteLine($"{Name}: Chirp! Chirp chirp!");
    }
    public void SpeciesCheck()
    {
        Console.WriteLine($"{Name} is a {Species}");
    }
    public void AgeCheck()
    {
        Console.WriteLine($">{Name} is {Age} Years Old");
    }
    public void Fly()
    {
        if (Energy > 0)
        {
            Console.WriteLine($">{Name} flies around (-1 Energy)");
            Energy = Energy-1;
        }
        else
        {
            Console.WriteLine($">{Name} is too tired to fly (No Energy)");
        }
    }
        public void Eat()
    {
        if (Energy < 10)
        {
            Console.WriteLine($">{Name} Eats Food (+2 Energy)");
            Energy = Energy + 2;
        }
        else
        {
            Console.WriteLine($">{Name} isn't hungry right now (Max Energy)");
        }
    }
        public void Sleep()
    {
        if (Energy < 10)
        {
            Console.WriteLine($">{Name} slumbers sleepily (+1 Energy)");
            Energy = Energy + 1;
        }
        else
        {
            Console.WriteLine($">{Name} isn't tired right now (Max Energy)");
        }
    }
    public void DisplayInfo()
    {
        Console.WriteLine("------------------------");
        Console.WriteLine("ANIMAL: BIRD");
        Console.WriteLine($"NAME: {Name}");
        Console.WriteLine($"SPECIES: {Species}");
        Console.WriteLine($"AGE: {Age}");
        Console.WriteLine($"ENERGY: {Energy}");
    }
}
//SHELTER CLASS--------------------------------------------
class Shelter
{
    public string Name = "";
    public int FoodSupply = 100;

    public void DisplayName()
    {
        Console.WriteLine($"----------{Name}----------");
    }

    public void UseFood(int amount)
    {
        if (amount > FoodSupply)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("[There is not enough food for that!]");
            Console.WriteLine("------------------------");
        }
        else if (amount < 7)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("[That's not enough food for everyone]");
            Console.WriteLine("------------------------");
        }
        else
        {
            FoodSupply -= amount;
            Console.WriteLine("------------------------");
            Console.WriteLine("[The animals have been fed]");
            Console.WriteLine("------------------------");
        }
    }
    public void FeedAnimals()
    {
        UseFood(7);
    }
}
