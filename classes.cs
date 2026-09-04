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

Console.WriteLine(dog1.Name);
Console.WriteLine(dog2.Name);
Console.WriteLine(dog3.Name);
Console.WriteLine(cat1.Name);

dog1.BreedCheck();
dog2.BreedCheck();
dog3.BreedCheck();

dog1.AgeCheck();
dog2.AgeCheck();
dog3.AgeCheck();

cat1.BreedCheck();
cat1.AgeCheck();

cat1.Meow();

dog1.Bark();
dog2.Bark();
dog3.Bark();

cat1.Sleep();
cat1.DisplayInfo();

class Cat
{
    public string Name = "";
    public string Breed = "";
    public int Age;
    public int Energy;
    
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
    //Changed to sleep from a run method. Will tie into energy. Once I teach myself this aspect of the language.
    public void Sleep()
    {
        Console.WriteLine(Name + " slumbers sleepily.");
    }
    public void DisplayInfo()
    {
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
    public int Energy;

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
        Console.WriteLine(Name + " runs off");
    }
    public void DisplayInfo()
    {
        Console.WriteLine("ANIMAL: DOG");
        Console.WriteLine("NAME: " + Name);
        Console.WriteLine("BREED: " + Breed);
        Console.WriteLine("AGE: " + Age);
    }
}
class Bird
{
    //I am omitting Breed as a bird attribute. I don't know birds.
    public string Name = "";
    public int Age;
    public int Energy;

    public void Chirp()
    {
        Console.WriteLine(Name + ": Chirp! Chirp chirp!");
    }
    public void BreedCheck()
    {
        Console.WriteLine(Name + " is a " + Breed);
    }
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
        Console.WriteLine("ANIMAL: BIRD");
        Console.WriteLine("NAME: " + Name);
        Console.WriteLine("BREED: " + Breed);
        Console.WriteLine("AGE: " + Age);
    }
}