using ConsoleApp4.Obiekty.Spells;
using ConsoleApp4.Obiekty.Weapons;
using System.Runtime.CompilerServices;

namespace ConsoleApp4.Obiekty;

public class Player{
    public Guid Id { get; } = Guid.NewGuid();
    public string Name { get; }

    public int Strength { get; } = 10;

    public int Health { get; private set; } = 100;

    public IWeapon PlayerWeapon { get; private set; } = new WarHammerWeapon();

    public ISpellBook SpellBook { get; private set; }

    public Player(string name) {
        Name = name;
    }


    public bool IsAlive() {
        return Health > 0;
    }


    public void AddWeapon(IWeapon weapon) {
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

    public int MagicAttack() {
        //todo to też zaimplementuj podobnie jak broń
    }

    public void PrintInfo() {
        Console.WriteLine($"Player {Name} has {Health} health points");
        Console.WriteLine(IsAlive() ? "Player is alive" : "RIP");
        Console.WriteLine("Player has weapon: " + PlayerWeapon.Name);
    }


    public void AddSpellBook() {
        //todo zaimplementuj to
       
    }


    public void AddSpell(ISpell spell) {
        //todo zaimplementuj to
        //sprawdz czy gracz ma książkę zaklęć jak nie wydrukuj komunikat że nie ma
    }
}