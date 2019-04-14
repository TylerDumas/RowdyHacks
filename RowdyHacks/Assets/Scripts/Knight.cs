using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : Character
{
    public void Start()
    {
        classCards = new List<Card>();
        health = 20;
        attack = 3;
        defense = 5;
        magic = 1;
        characterName = "Knight";
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
}
