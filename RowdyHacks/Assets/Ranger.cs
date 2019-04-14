using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ranger : Character
{
    public void Start()
    {
        health = 14;
        defense = 3;
        attack = 6;
        magic = 2;
    }
    public override void CharacterSwap()
    {

    }
    public override void TakeDamage(int amount)
    {
        health -= 14;   //subtract damage
        //instantiate damage numbers
    }
}
