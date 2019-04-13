using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI cardName;   //Text element for name
    [SerializeField]
    private TextMeshProUGUI cardDescription;    //Text element for description
    [SerializeField]
    private Image cardArtwork;     //image element for artwork
    [SerializeField]
    private Image cardTypeIndicator;        //image element for type indicator (knight icon, etc)
        
    public Card card;

    // Start is called before the first frame update
    void Start(){
        /* Set each text element */
        cardName.SetText(card.cardName);
        cardDescription.SetText(card.description);
        cardArtwork.sprite = card.artwork;
    }
}
