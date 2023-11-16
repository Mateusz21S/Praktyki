using ConsoleApp4.Obiekty.Spells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Assests.Spells;
public class ProfessionalSpellBook : ISpellBook
{
    public string Name { get; } = "Professional Spell Book";
    public int SpellCount { get; private set; } = 5;
    public List<ISpell> Spells { get; }

    public ProfessionalSpellBook()
    {
        Spells = new List<ISpell>();
    }


    public void AddSpell(ISpell spell)
    {
        if (Spells.Count >= SpellCount)
        {
            Console.WriteLine($"Cannot add more spells to {Name}. Maximum spell count ({SpellCount}) reached.");
            return;
        }

        Spells.Add(spell);
        Console.WriteLine($"{spell.Name} added to {Name} spell book.");
    }

    public void RemoveSpell(ISpell spell)
    {
        Spells.Remove(spell);
    }

    public int CastSpell(int rnd)
    {
        throw new NotImplementedException();
    }

    public void PrintInfo()
    {
        throw new NotImplementedException();
    }
}