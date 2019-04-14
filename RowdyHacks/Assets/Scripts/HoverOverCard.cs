using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverOverCard : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    [SerializeField]
    private Animator animator;

    public GameManager gm;

    public CardDisplay cardDisplay;
    //[SerializeField]
    //private Animator animatorWindow;

    public void OnPointerEnter(PointerEventData eventData)
    { 
        animator.SetBool("isHovering", true);
        //animatorWindow.SetBool("isHovering", true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        animator.SetBool("isHovering", false);
        //animatorWindow.SetBool("isHovering", false);
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        gm.PrepareCard(cardDisplay.GetCard());
    }
}
