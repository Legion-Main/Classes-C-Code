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

cat1.Run();

class Cat
{
    public string Name = "";
    public string Breed = "";
    public string Color = "";
    public int Age;

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
    public void Run()
    {
        Console.WriteLine(Name + " runs off");
    }
}
class Dog
{
    public string Name = "";
    public string Breed = "";
    public string Color = "";
    public int Age;

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
}
