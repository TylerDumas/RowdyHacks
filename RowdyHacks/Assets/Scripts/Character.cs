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
   public int defence;
   public int magic;
   public string characterName;

   public abstract void CharacterAbility();
   public abstract void TakeDamage(int amount);
}