namespace ConsoleApp4.Obiekty.Weapons;



public interface IWeapon{
    string Name { get; }
    int Durability { get; }
    bool IsBroken();
    int Hit(int random);
    void PrintInfo();
}