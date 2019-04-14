using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : Character
{
    public List<Action> possibleMoves = new List<Action>();    //list of possible moves
    public string type = "Knight";  //Type of Card

    public void Start()     //Calls before first frame
    { 
        health = 20;
        attack = 3;
        defense = 5;
        magic = 1;
        characterName = "Knight";

        /* Create all actions */
        Action guard = Guard;
        Action bash = Bash;
        Action swing = Swing;
        Action defensiveStance = DefensiveStance;
        Action fancyStrike = FancyStrike;
        Action brace = Brace;
        Action standGround = StandGround;
        Action shieldBash = ShieldBash;
        Action charge = Charge;
        Action hunkerDown = HunkerDown;

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
    public void Guard()
    {

    }
    public void Bash()
    {

    }
    public void Swing()
    {

    }
    public void DefensiveStance()
    {

    }
    public void FancyStrike()
    {

    }
    public void Brace()
    {

    }
    public void StandGround()
    {

    }
    public void ShieldBash()
    {

    }
    public void Charge()
    {

    }
    public void HunkerDown()
    {

    }
}
