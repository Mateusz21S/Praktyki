namespace ConsoleApp4.Obiekty.Spells;

public class SimpleSpellBook : ISpellBook
{
    public string Name { get; } = "Simple Spell Book";
    public int SpellCount { get; private set; } = 2;
    public List<ISpell> Spells { get; }

    public SimpleSpellBook()
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

    public void RemoveSpell(ISpell spell) {
        Spells.Remove(spell);
    }


    public int CastSpell(string name, int rnd)
    {
       
    {
        throw new NotImplementedException();
    }

     
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