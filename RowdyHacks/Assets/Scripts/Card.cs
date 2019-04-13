using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Card : ScriptableObject
{
    public string cardName;    //Name of the card
    public string type;    //Knight, Ranger, etc
    public string description;     //Description of the card

    public Sprite artwork;  //Character drawing

}
[CreateAssetMenu(fileName = "New Card", menuName = "Cards/Generic Card")]
public class GenericCard: Card{

}
[CreateAssetMenu(fileName = "New Card", menuName = "Cards/Knight Card")]
public class KnightCard : Card{     //Card for Knight
    private int attack;
}
[CreateAssetMenu(fileName = "New Card", menuName = "Cards/Ranger Card")]
public class RangerCard : Card {    //Card for Ranger

}
[CreateAssetMenu(fileName = "New Card", menuName = "Cards/Healer Card")]
public class HealerCard : Card {    //Card for Healer

}