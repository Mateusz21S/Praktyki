using ConsoleApp4.Obiekty.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Assests.Weapons;
public class KnifeWeapon : IWeapon
{
    public int Damage { get; } = 1;
    public string Name { get; }
    public int Durability { get; } = 120;

    public KnifeWeapon()
    {
        Name = "Knife";
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
        Console.WriteLine($"Knife has {Durability} durability points");
    }
}