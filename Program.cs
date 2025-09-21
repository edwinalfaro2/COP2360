using System;

public class Octopus
{
    // regular private field
    private readonly string _name;

    // public readonly fields (immutable after construction)
    public readonly int Legs;

    // static readonly constant shared by all instances
    public static readonly int TypicalLegCount = 8;

    // init-only property wrapper for name (exposes value without mutability)
    public string Name => _name;

    // optional computed field example
    public readonly bool IsTypical;

    public Octopus(string name, int legs = 8)
    {
        _name = name ?? throw new ArgumentNullException(nameof(name));
        if (legs <= 0) throw new ArgumentOutOfRangeException(nameof(legs), "legs must be positive");
        Legs = legs;
        IsTypical = (legs == TypicalLegCount);
    }
}

public static class Program
{
    public static void Main()
    {
        var o = new Octopus("Jack");
        Console.WriteLine($"{o.Name} has {o.Legs} legs. Typical? {o.IsTypical}");

        var baby = new Octopus("Smol", 7);
        Console.WriteLine($"{baby.Name} has {baby.Legs} legs. Typical? {baby.IsTypical}");

        // The following line would be a compile-time error:
        // baby.Legs = 9;  // CS0191: A readonly field cannot be assigned to...
    }
}