using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Animator anim;
    private List<Enemy> enemyList;
    private Party party;
    private Queue<Card> cardQueue;

    private Object number;


    void Start(){
        cardQueue = new Queue<Card>();
    	anim = GetComponent<Animator>();
        number = Resources.Load("Number");
    }

    void Update(){
    	AnimatorStateInfo currentState = anim.GetCurrentAnimatorStateInfo(0);
    	if(currentState.IsName("BattleSetup")){
    		BattleSetup();
    	} else if(currentState.IsName("PlayerDrawPhase")){
    		PlayerDrawPhase();
    	} else if(currentState.IsName("PlayerActionPhase")){
    		PlayerActionPhase();
    	} else if(currentState.IsName("EnemyActionPhase")){
    		EnemyActionPhase();
    	} else if(currentState.IsName("ReturnCardsToDeckPhase")){
    		ReturnCardsToDeckPhase();
    	} else if(currentState.IsName("PlayerSwapPhase")) {
    		PlayerSwapPhase();
    	} else if(currentState.IsName("Victory")) {
    		Victory();
    	} else if(currentState.IsName("Failure")){
    		Failure();
    	} else if(currentState.IsName("Cleanup")){
    		Cleanup();
    	}
    }

    private void BattleSetup(){
    	//TODO set up character positions
        //TODO set up character health
        //TODO set up set up player decks and hands
        //TODO set up 
    }

    private void PlayerDrawPhase(){

    }

    private void PlayerActionPhase(){
        Card c = getClickedCard();
        if(c == null)
            return;
        RunCard(c);
        party.energy--;
        anim.SetInteger("playerEnergy",  party.energy);
    }

    private void EnemyActionPhase(){

    }

    private void ReturnCardsToDeckPhase(){

    }

    private void PlayerSwapPhase(){

    }

    private void Victory() {

    }

    private void Failure() {

    }

    private void Cleanup() {

    }

    private Card getClickedCard() {
        Card c = null;
        if(Input.GetMouseButtonDown(0)){
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit)){
                 if (hit.transform != null) {
                    Debug.Log("HIT A CARD.");
                     c = hit.transform.gameObject.GetComponent<CardDisplay>().getCard();
                    Debug.Log(c.actions);
                 }
             }
        }

        return c;
    }


    private void CardAttack(){
        int damage = party.GetFowardCharacter().attack;
        enemyList[2].TakeDamage(damage);
        MakeNumber(NumberIndicatorType.Damage, damage, enemyList[2].transform.position);
    }

    private void CardBlock(){

    }

    private void CardSwap(){

    }

    private void CardStun(){

    }

    private void RunCard(Card c){
        foreach(char ch in c.actions){
            switch(ch){
                case 'A':
                    CardAttack();
                    break;
                case 'B':
                    CardBlock();
                    break;
                case 'D':
                    //Draw
                    break;
                case 'E': //Energy
                    //Add energy
                case 'H':
                    //Heal
                    break;
                case 'K': //Kill
                    //Attack Up
                    break;
                case 'M':
                    //Magic Up
                    break;
                case 'P': //Push
                    //Force enemy Swap;
                    break;
                case 'T': //Tank
                    //+1 Character Defence
                    break;
                case 'R': //(Don't) Rotate
                    break; //Skip Swap
                case '+': //Party Heal
                    break;
                case 'S':
                    CardSwap();
                    break;
                case 'Z':
                    CardStun();
                    break;
            }
        }
    }

    private void MakeNumber(NumberIndicatorType type, int amount, Vector3 position){
        GameObject myNumber = Instantiate(number) as GameObject;
        DamageNumberController dnc = myNumber.GetComponent<DamageNumberController>();
        dnc.setDamageValue(amount);
        dnc.setIndicatorType(type);
        myNumber.transform.position = position;
    }

    public void PrepareCard(Card c){
        if(cardQueue.Count != 0) return;
        cardQueue.Enqueue(c);
        Debug.Log("Card Prepared");
    }

}
