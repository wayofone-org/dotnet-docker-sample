using dotnet_sample;

namespace thingy;

public class Program
{
    public static void Main(string[] args)
    {
        var dog = new Animal();
        dog.Name = "Dog";
        dog.Sound = "Woof";
        Console.WriteLine(dog.MakeSound());
    }
}