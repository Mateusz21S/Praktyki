namespace ConsoleApp4.Obiekty.Weapons;

public class FistWeapon : IWeapon{
    public int Damage { get; } = 1;
    public string Name { get; }
    public int Durability { get; } = 100;
    
    public FistWeapon()
    {
        Name = "Fist";
    }

    public bool IsBroken()
    {
        return Durability <= 0;
    }

    public  int Hit(int random)
    {
        return Damage + random;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Fist has {Durability} durability points");
    }
}