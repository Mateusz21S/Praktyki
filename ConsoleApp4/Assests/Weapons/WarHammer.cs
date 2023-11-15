namespace ConsoleApp4.Obiekty.Weapons;

public class WarHammerWeapon : WeaponBase
{
    public int Damage { get; } = 20;

    public int Durability { get; private set; } = 100;

    public bool IsBroken()
    {
        return Durability <= 0;
    }

    public WarHammer()
    {
        Name = "War Hammer";
    }
    public override int Hit(int random)
    {
        if (IsBroken()) return 0;

        Durability -= 1;
        return Damage + random * 3;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"War Hammer has {Durability} durability points");
        Console.WriteLine(IsBroken() ? "War Hammer is broken" : "War Hammer is not broken");
    }
}