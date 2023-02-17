namespace dotnet_sample;

public class Animal
{
    public string Name { get; set; }
    public string Sound { get; set; }
    public string MakeSound()
    {
        return $"The {Name} says {Sound}";
    }
}
