namespace ConsoleApp4.Obiekty.Weapons;

public class FistWeapon : WeaponBase
{
    public int Damage { get; } = 1;


    public int Durability { get; } = 100;



    public FistWeapon()
    {
        Name = "Fist";
    }

    public bool IsBroken()
    {
        return Durability <= 0;
    }

    public override int Hit(int random)
    {
        return Damage + random;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Fist has {Durability} durability points");
    }
}