using ConsoleApp4.Obiekty.Spells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Assests.Spells;
public class LightningSpell : ISpell
{
    public string Name { get; }
    public int Power { get; }
    public int ManaCost { get; }

    public LightningSpell()
    {
        Name = "Lightning";
        Power = 35;
        ManaCost = 30;
    }

    public int Hit(int random)
    {
        return Power + random * 2;
    }
}