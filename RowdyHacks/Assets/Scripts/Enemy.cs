using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public int attack;
    public int defense;
    public int magic;

    public Character[] targets;

    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}
