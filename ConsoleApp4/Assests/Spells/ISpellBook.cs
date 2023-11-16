namespace ConsoleApp4.Obiekty.Spells;

public interface ISpellBook{
    string Name { get; }
    int SpellCount { get; }

    List<ISpell> Spells { get; }

    void AddSpell(ISpell spell);
    int CastSpell(int rnd);
    void PrintInfo();
    void RemoveSpell(ISpell spell);
}