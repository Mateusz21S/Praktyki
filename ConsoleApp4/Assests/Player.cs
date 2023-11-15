using ConsoleApp4.Obiekty.Weapons;

namespace ConsoleApp4.Obiekty;

public class Player{
    public Guid Id { get; } = Guid.NewGuid();
    public string Name { get; }

    public int Strength { get; } = 10;

    public int Health { get; private set; } = 100;

    public WeaponBase PlayerWeapon { get; private set; } = new FistWeapon();

    public Player(string name) {
        Name = name;
    }


    public bool IsAlive() {
        return Health > 0;
    }


    public void AddWeapon(WeaponBase weapon) {
        PlayerWeapon = weapon;
        Console.WriteLine($"Player {Name} gets {weapon.Name}");
    }

    public bool AddDamage(int damage) {
        if (damage < 0) return false;

        Health -= damage;

        PrintInfo();

        return true;
    }

    public int Attack() {
        var rnd = new Random().Next(0, 6);

        var dmg = PlayerWeapon.Hit(rnd);
        Console.WriteLine($"Player {Name} attacks with {dmg} damage");
        PlayerWeapon.PrintInfo();
        return dmg;
    }

    public void PrintInfo() {
        Console.WriteLine($"Player {Name} has {Health} health points");
        Console.WriteLine(IsAlive() ? "Player is alive" : "RIP");
        Console.WriteLine("Player has weapon: " + PlayerWeapon.Name);
    }
}