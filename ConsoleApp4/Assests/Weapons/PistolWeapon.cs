namespace ConsoleApp4.Assests.Weapons;
public class PistolWeapon : IWeapon
{
    public int Damage { get; } = 25;
    public string Name { get; }
    public int Durability { get; } = 100;

    public PistolWeapon()
    {
        Name = "Pistol";
    }

    public bool IsBroken()
    {
        return Durability <= 0;
    }

    public int Hit(int random)
    {
        return Damage + random;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Pistol has {Durability} durability points");
    }
}