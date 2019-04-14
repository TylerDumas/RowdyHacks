using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ranger : Character
{
    public List<Action<Enemy>> possibleMoves = new List<Action<Enemy>>();

    public void Start()
    {
        health = 14;
        defense = 3;
        attack = 6;
        magic = 2;
        characterName = "Ranger";

        Action<Enemy> basicAttack = Attack;
        Action<Enemy> twinShot = TwinShot;
        Action<Enemy> reposition = Reposition;
        Action<Enemy> stepShot = StepShot;
        Action<Enemy> arrowRain = ArrowRain;
        Action<Enemy> fancyStrike = FancyStrike;
        Action<Enemy> planningAhead = PlanningAhead;
        Action<Enemy> exploitWeakness = ExploitWeakness;
        Action<Enemy> anchoredShot = AnchoredShot;

        possibleMoves.Add(basicAttack);
        possibleMoves.Add(twinShot);
        possibleMoves.Add(reposition);
        possibleMoves.Add(stepShot);
        possibleMoves.Add(arrowRain);
        possibleMoves.Add(fancyStrike);
        possibleMoves.Add(planningAhead);
        possibleMoves.Add(exploitWeakness);
        possibleMoves.Add(anchoredShot);
    }
    public override void CharacterSwap()
    {
        //TODO attack when swap to and from
    }
    public override void TakeDamage(int amount)
    {
        health -= 14;   //subtract damage
        //instantiate damage numbers
    }

    public void Attack(Enemy enemy)
    {
        enemy.health -= attack;
    }
    public void TwinShot(Enemy enemy)
    {
        enemy.health -= (attack * 2);
    }
    public void Reposition(Enemy enemy)
    {
        //TODO swap and draw a card
    }
    public void StepShot(Enemy enemy)
    {
        enemy.health -= attack;
        //TODO dodge 
        //TODO skip rotation
    }
    public void ArrowRain(Enemy enemy)
    {
        enemy.health -= attack * 3;
        //TODO skip rotation
    }
    public void FancyStrike(Enemy enemy)
    {
        enemy.health -= attack;
        //TODO swap
    }
    public void PlanningAhead(Enemy enemy)
    { 
        //TODO draw twice
    }
    public void Block(Enemy enemy)
    {
       //defense 
    }
    public void ExploitWeakness(Enemy enemy)
    {
        enemy.health -= attack;
        attack += 1;
    }
    public void AnchoredShot(Enemy enemy)
    {
        enemy.health -= attack;
        //TODO stop enemies from swapping
    }
}
