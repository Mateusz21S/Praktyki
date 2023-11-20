using ConsoleApp4.Obiekty.Spells;
using ConsoleApp4.Obiekty.Weapons;

namespace ConsoleApp4.Assests;

public class Player
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Name { get; }

    public int Strength { get; } = 10;

    public int Health { get; private set; } = 100;

    public IWeapon PlayerWeapon { get; private set; } = new WarHammerWeapon();

    public ISpellBook SpellBook { get; private set; }

    public int MaxMana { get; set; } = 100;  

    public int Mana { get; set; }

    public Player(string name)
    {
        Name = name;
    }


    public bool IsAlive()
    {
        return Health > 0;
    }


    public void AddWeapon(IWeapon weapon)
    {
        PlayerWeapon = weapon;
        Console.WriteLine($"Player {Name} gets {weapon.Name}");
    }

    public bool AddDamage(int damage)
    {
        if (damage < 0) return false;

        Health -= damage;

        PrintInfo();

        return true;
    }

    public int Attack()
    {
        var rnd = new Random().Next(0, 6);

        var dmg = PlayerWeapon.Hit(rnd);
        Console.WriteLine($"Player {Name} attacks with {dmg} damage");
        PlayerWeapon.PrintInfo();
        return dmg;
    }

    public int MagicAttack(ISpell spell)
    {
        if (SpellBook is null)
        {
            Console.WriteLine($"{Name} does not have a spell book to perform a magic attack.");
            return 0;
        }

        // sprawdzić mane czy ma wystarczająco jak nie to komunikat
        // sprawdzić czy dany czar jest na liście po nazwie

        var rnd = new Random().Next(0, 6);
        var magicDmg = SpellBook.CastSpell(spell.Name, rnd);

        Console.WriteLine($"Player {Name} performs a magic attack with {magicDmg} damage");
        SpellBook.PrintInfo();

        return magicDmg;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Player {Name} has {Health} health points");
        Console.WriteLine(IsAlive() ? "Player is alive" : "RIP");
        Console.WriteLine("Player has weapon: " + PlayerWeapon.Name);
    }


    public void AddSpellBook(ISpellBook spellBook)
    {
        if (spellBook != null)
        {
            SpellBook = spellBook;
            Console.WriteLine($"{Name} obtains a spell book: {spellBook.Name}");
        }
        else
        {
            SpellBook = new SimpleSpellBook(); 
            Console.WriteLine($"{Name} obtains a default spell book.");
        }
    }


    public void AddSpell(ISpell spell)
    {
        if (SpellBook == null)
        {
            Console.WriteLine($"{Name} does not have a spell book to add spells.");
            return;
        }

        SpellBook.AddSpell(spell);
        Console.WriteLine($"{spell.Name} added to {SpellBook.Name}");
    }


    public void Rest() {
        // odnawanie many 
        // i odnawanie małe zdrowia
    }
}