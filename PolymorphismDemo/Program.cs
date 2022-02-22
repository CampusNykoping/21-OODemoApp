
class Animal  // Base class (parent) 
{
    public  void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Pig : Animal  // Derived class (child) 
{
    public  void animalSound()
    {
        Console.WriteLine("The pig says: wee wee");
    }
}

class Dog : Animal  // Derived class (child) 
{
    public  void animalSound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var myAnimal = new Animal();  // Create a Animal object
        var myPig = new Pig();  // Create a Pig object
        Animal myDog = new Dog();  // Create a Dog object
        Dog myOtherDog = new Dog(); 

        myAnimal.animalSound();
        myPig.animalSound();
        myDog.animalSound();
        myOtherDog.animalSound();
    }
}