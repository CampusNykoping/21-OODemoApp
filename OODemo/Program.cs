
var dog = new Dog(5, "Collie");
dog.Sleep();
dog.WagTail();

//Console.WriteLine("Press any key");
//Console.ReadKey();

public class Mammal
{
    public int Age { get; set; }

    public Mammal(int age)
    {
        this.Age = age;
    }

    public void Sleep()
    {
        Console.WriteLine("Shhh! I'm sleeping!");
    }
}

public class Dog : Mammal
{
    public string Breed { get; set; }

    public Dog(int age, string breed)
      : base(age)
    {
        this.Breed = breed;
    }

    public void WagTail()
    {
        Console.WriteLine("Tail wagging...");
    }
}
