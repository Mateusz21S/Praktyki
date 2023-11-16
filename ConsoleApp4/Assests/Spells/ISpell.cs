using System.Globalization;

namespace ConsoleApp4.Obiekty.Spells;

public interface ISpell{
    string Name { get; }
    int Power { get; }
    int ManaCost { get; }
    int Hit(int random);
}