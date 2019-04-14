using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : Character
{
    public List<Action<Enemy>> possibleMoves = new List<Action<Enemy>>();    //list of possible moves
    public void Start()     //Calls before first frame
    { 
        health = 20;
        attack = 3;
        defense = 5;
        magic = 1;
        characterName = "Knight";

        /* Create all actions */
        Action<Enemy> basicAttack = Attack;
        Action<Enemy> guard = Guard;
        Action<Enemy> bash = Bash;
        Action<Enemy> swing = Swing;
        Action<Enemy> defensiveStance = DefensiveStance;
        Action<Enemy> fancyStrike = FancyStrike;
        Action<Enemy> brace = Brace;
        Action<Enemy> standGround = StandGround;
        Action<Enemy> shieldBash = ShieldBash;
        Action<Enemy> charge = Charge;
        Action<Enemy> hunkerDown = HunkerDown;

        possibleMoves.Add(guard);
        possibleMoves.Add(bash);
        possibleMoves.Add(swing);
        possibleMoves.Add(defensiveStance);
        possibleMoves.Add(fancyStrike);
        possibleMoves.Add(brace);
        possibleMoves.Add(standGround);
        possibleMoves.Add(shieldBash);
        possibleMoves.Add(charge);
        possibleMoves.Add(hunkerDown);

    }
    public override void CharacterSwap()
    {
        //block to defense when swapped to a from
    }
    public override void TakeDamage(int amount)
    {
        this.defense -= amount;
        //instantiate damage numbers
    }

    /*
     * All possible methods for the Knight Cards 
     */
    public void Attack(Enemy enemy)
    {

    }
    public void Guard(Enemy enemy)
    {

    }
    public void Bash(Enemy enemy)
    {

    }
    public void Swing(Enemy enemy)
    {

    }
    public void DefensiveStance(Enemy enemy)
    {

    }
    public void FancyStrike(Enemy enemy)
    {

    }
    public void Brace(Enemy enemy)
    {

    }
    public void StandGround(Enemy enemy)
    {

    }
    public void ShieldBash(Enemy enemy)
    {

    }
    public void Charge(Enemy enemy)
    {

    }
    public void HunkerDown(Enemy enemy)
    {

    }
}
