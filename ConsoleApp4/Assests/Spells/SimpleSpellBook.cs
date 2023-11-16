namespace ConsoleApp4.Obiekty.Spells;

public class SimpleSpellBook : ISpellBook{
    public string Name { get; } = "Simple Spell Book";
    public int SpellCount { get; private set; } = 2;
    public List<ISpell> Spells { get; }

    public SimpleSpellBook()
    {
        Spells = new List<ISpell>();
    }


    public void AddSpell(ISpell spell) {
        //to do wydrukuj ze nie mozesz dodac wiecej czarow
        if (Spells.Count >= SpellCount) return;

        Spells.Add(spell);
    }

    public void RemoveSpell(ISpell spell) {
        Spells.Remove(spell);
    }
}