namespace ConsoleApp4.Obiekty.Weapons;

public class SwordWeapon : WeaponBase
{
    public int Damage { get; } = 10;

    public int Durability { get; private set; } = 100;

    public bool IsBroken()
    {
        return Durability <= 0;
    }
    public SwordWeapon()
    {
        Name = "Sword";
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Sword has {Durability} durability points");
        Console.WriteLine(IsBroken() ? "Sword is broken" : "Sword is not broken");
    }

    public override int Hit(int random)
    {
        if (IsBroken()) return 0;

        Durability -= 1;
        return Damage + random * 2;
    }
}