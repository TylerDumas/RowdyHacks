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
   
   public List<Card> classCards; 
   public abstract void CharacterSwap();
   public abstract void TakeDamage(int amount);
}
