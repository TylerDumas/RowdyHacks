using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Card : ScriptableObject
{
    public string nameOfCard;    //Name of the card
    public string description;     //Description of the card

    public Sprite artwork;  //Character drawing

}
[CreateAssetMenu(fileName = "New Card", menuName = "Cards/Generic Card")]
public class GenericCard: Card{
    public string type = "Generic";

}
[CreateAssetMenu(fileName = "New Card", menuName = "Cards/Knight Card")]
public class KnightCard : Card
{     //Card for Knight
    public string type = "Knight";
}
[CreateAssetMenu(fileName = "New Card", menuName = "Cards/Ranger Card")]
public class RangerCard : Card {    //Card for Ranger
    public string type = "Ranger";
}
[CreateAssetMenu(fileName = "New Card", menuName = "Cards/Healer Card")]
public class HealerCard : Card {    //Card for Healer
    public string type = "Healer";
}