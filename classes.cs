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

/*Cat cat2 = new Cat();

cat2.Name = "Tiny";
cat2.Breed = "Domestic Shorthair";
cat2.Age = 3;

Cat cat2 = new Cat();

cat2.Name = "Tiny";
cat2.Breed = "Domestic Shorthair";
cat2.Age = 3;*/

Console.WriteLine(dog1.Name);
Console.WriteLine(dog2.Name);
Console.WriteLine(dog3.Name);
Console.WriteLine(cat1.Name);

dog1.DisplayInfo();
dog2.DisplayInfo();
dog3.DisplayInfo();
cat1.DisplayInfo();
cat2.DisplayInfo();

cat1.EnergyTest();
cat1.Sleep();
cat1.Eat();
cat1.Play();
cat1.EnergyTest();
cat1.Play();
cat1.Play();
cat1.Play();
cat1.Play();
cat1.Play();
cat1.EnergyTest();
cat1.Sleep();
cat1.Eat();
cat1.EnergyTest();

//bird1.DisplayInfo();
//bird2.DisplayInfo();

class Cat
{
    public string Name = "";
    public string Breed = "";
    public int Age;
    public int Energy = 10;
    
    public void Meow()
    {
        Console.WriteLine(Name + ": Meow!");
    }
    public void BreedCheck()
    {
        Console.WriteLine(Name + " is a " + Breed);
    }
    public void AgeCheck()
    {
        Console.WriteLine(Name + " is " + Age + " Years Old");
    }
    public void Play()
    {
        Console.WriteLine(Name + " plays with you (-1 Energy)");
        Energy = Energy-1;
    }
    public void Eat()
    {
        if (Energy < 10)
        {
            Console.WriteLine(Name + " Eats Food (+1 Energy)");
            Energy = Energy + 1;
        }
        else
        {
            Console.WriteLine(Name + " isn't hungry right now");
        }
    }
    //Changed to sleep from a run method. Will tie into energy. 
    public void Sleep()
    {
        if (Energy < 10)
        {
            Console.WriteLine(Name + " slumbers sleepily (+2 Energy)");
            Energy = Energy + 2;
        }
        else
        {
            Console.WriteLine(Name + " isn't tired right now");
        }
    }
    public void EnergyTest()
    {
        Console.WriteLine("------------------------");
        Console.WriteLine("Energy: " + Energy);
    }
    public void DisplayInfo()
    {
        //Putting the separators on top. Why? I don't know which would be better. Would it make that much of a difference? This is beyond the scope.
        Console.WriteLine("------------------------");
        Console.WriteLine("ANIMAL: CAT");
        Console.WriteLine("NAME: " + Name);
        Console.WriteLine("BREED: " + Breed);
        Console.WriteLine("AGE: " + Age);
    }
}
class Dog
{
    public string Name = "";
    public string Breed = "";
    public int Age;
    public int Energy = 10;

    public void Bark()
    {
        Console.WriteLine(Name + ": Bark!");
    }
    public void BreedCheck()
    {
        Console.WriteLine(Name + " is a " + Breed);
    }
    public void AgeCheck()
    {
        Console.WriteLine(Name + " is " + Age + " Years Old");
    }
    public void Run()
    {
        Console.WriteLine(Name + " runs off (-1 Energy)");
        Energy = Energy-1;
    }
    public void Eat()
    {
        Console.WriteLine(Name + " Eats Food");
        if (Energy < 10)
        {
                Energy = Energy + 1;
        }
    }
    public void EnergyTest()
    {
        Console.WriteLine("------------------------");
        Console.WriteLine("Energy: " + Energy);
    }
    public void DisplayInfo()
    {
        Console.WriteLine("------------------------");
        Console.WriteLine("ANIMAL: DOG");
        Console.WriteLine("NAME: " + Name);
        Console.WriteLine("BREED: " + Breed);
        Console.WriteLine("AGE: " + Age);
    }
}
/*class Bird
{
    //I am omitting Breed as a bird attribute. I don't know birds.
    public string Name = "";
    public int Age;
    public int Energy;

    public void Chirp()
    {
        Console.WriteLine(Name + ": Chirp! Chirp chirp!");
    }
    //Accidentally was throwing errors keeping breedcheck with no breed attribute
    public void AgeCheck()
    {
        Console.WriteLine(Name + " is " + Age + " YearsOld");
    }
    public void Fly()
    {
        Console.WriteLine(Name + " flies around");
    }
    public void DisplayInfo()
    {
        Console.WriteLine("------------------------");
        Console.WriteLine("ANIMAL: BIRD");
        Console.WriteLine("NAME: " + Name);
        Console.WriteLine("AGE: " + Age);
    }
}*/
