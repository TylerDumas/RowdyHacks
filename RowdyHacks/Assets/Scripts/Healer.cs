using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healer : Character
{

    public List<Action<Enemy>> possibleMoves = new List<Action<Enemy>>();

    // Start is called before the first frame update
    void Start()
    {
        health = 16;
        defense = 4;
        attack = 3;
        magic = 3;
        characterName = "Healer";

    }

    public override void CharacterSwap()
    {
        //TODO heal when swap to and from
    }

    public override void TakeDamage(int amount)
    {
        this.health -= amount;
        //TODO instantiate damage effect
    }

}
