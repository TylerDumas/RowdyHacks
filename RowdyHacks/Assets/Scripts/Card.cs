using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Cards")]
public class Card : ScriptableObject
{
    string name;    //Name
    string type;    //Knight, Ranger, etc
    string description;     //Description

}
