using System;
using ConsoleApp4.Assests.Spells;
using ConsoleApp4.Obiekty;
using ConsoleApp4.Obiekty.Spells;
using ConsoleApp4.Obiekty.Weapons;

class Program
{
    static void Main()
    {
        Player player = new Player("Janusz");

        IWeapon sword = new SwordWeapon();

        player.AddWeapon(sword);

        ISpellBook spellBook = new ProfessionalSpellBook();

        player.AddSpellBook(spellBook);

        ISpell fireBallSpell = new FireBallSpell();

        player.AddSpell(fireBallSpell);

        player.PrintInfo();

        player.Attack();

        player.MagicAttack();

        player.AddDamage(50);

        player.PrintInfo();

        ISpell lightningSpell = new LightningSpell();

        player.AddSpell(lightningSpell);

        player.AddDamage(60);

        player.PrintInfo();


    }
}