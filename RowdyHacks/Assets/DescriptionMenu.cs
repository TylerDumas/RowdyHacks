using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DescriptionMenu : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI cardName;   //Text element for name
    [SerializeField]
    private TextMeshProUGUI cardDescription;    //Text element for description

    public Card card;

    // Start is called before the first frame update
    void Start()
    {
        /* Set each text element */
        cardName.SetText(card.nameOfCard);  //set name text 
        cardDescription.SetText(card.description);  //set description text

    }
}