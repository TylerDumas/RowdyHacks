using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Card : ScriptableObject
{
    public string nameOfCard;    //Name of the card
    public string description;     //Description of the card
    public string actions; //String representing the methods

    public Sprite artwork;  //Character drawing

}
