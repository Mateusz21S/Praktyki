namespace ConsoleApp4.Obiekty.Spells;

public class FireBallSpell : ISpell{
    public string Name { get; }
    public int Power { get; }
    public int ManaCost { get; }

    public FireBallSpell() {
        Name = "Fireball base";
        Power = 10;
        ManaCost = 10;
    }

    public int Hit(int random) {
        return Power + random * 2;
    }
}