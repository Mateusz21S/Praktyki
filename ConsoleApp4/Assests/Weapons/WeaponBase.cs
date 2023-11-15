namespace ConsoleApp4.Obiekty.Weapons;

public abstract class WeaponBase
{
    public string Name { get; protected set; }
    public abstract int Hit(int random);

    public abstract void PrintInfo();
}