using ConsoleApp4.Obiekty.Spells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Assests.Spells;
public class ExpertSpellBook : ISpellBook
{
    public string Name { get; } = "Expert Spell Book";
    public int SpellCount { get; private set; } = 8;
    public List<ISpell> Spells { get; }

    public ExpertSpellBook()
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

    public bool HasSpell(string name) {
        throw new NotImplementedException();
    }

    public int CastSpell(string name, int rnd) {
        throw new NotImplementedException();
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

    public int CastSpell(string name, object rnd)
    {
        throw new NotImplementedException();
    }
}