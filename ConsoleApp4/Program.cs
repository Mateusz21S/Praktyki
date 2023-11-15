using System;
using ConsoleApp4.Obiekty;
using ConsoleApp4.Obiekty.Weapons;

class Program

{
    static void Main()
    {


        var player = new Player("Janusza");



        for (int i = 0; i < 5; i++)
        {
            player.Attack();
        }

        var sword = new SwordWeapon();

        player.AddWeapon(sword);


    }


}