using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * An abstract class representing a player character.
 */
public abstract class Character : MonoBehaviour
{
   public int health;
   public int attack;
   public int defense;
   public int magic;
   public string characterName;

   public abstract void CharacterSwap();
   public abstract void TakeDamage(int amount);
}

public class Knight : Character
{
    public void Start()
    {
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
    }
}