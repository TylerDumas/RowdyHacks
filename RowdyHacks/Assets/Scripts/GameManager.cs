using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Character[] characters;
    private Animator anim;

    public Enemy enemy;

    private Party party;
    private Queue<Card> cardQueue;
    public List<Card> hand;

    public Card[] listOFAllCards;

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
        party = new Party(0, 3);        //Create Party
        foreach(Character character in characters)  //Create Characters
        {
            party.characterList.Add(character);
        }
        anim.SetTrigger("setupComplete");
    }

    private void PlayerDrawPhase(){
        //Draw 5 Cards
        for(int i = 0; i < 5; i++)
        {
            if(hand.Count <= 5)
            {
                hand.Add(listOFAllCards[Random.Range(0, listOFAllCards.Length - 3)]);
                Debug.Log("AAAA");
            }

        }
        anim.SetTrigger("playerHasDrawn");
    }

    private void PlayerActionPhase(){
        Card c;
        if (cardQueue.Count <= 0)
        {
            return;
        }
        else
        {
            c = cardQueue.Dequeue();
            if (c == null)
                return;
        }

        RunCard(c);
        party.energy--;
        anim.SetInteger("playerEnergy",  party.energy);
    }

    private void EnemyActionPhase(){
        int rNum = Random.Range(0, 2);
        enemy.targets[rNum].health -= enemy.attack;
        MakeNumber(NumberIndicatorType.Damage, 10, enemy.targets[rNum].transform.position);
        anim.SetTrigger("enemyIsDone");
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
                     c = hit.transform.gameObject.GetComponent<CardDisplay>().GetCard();
                    Debug.Log(c.actions);
                 }
             }
        }

        return c;
    }

    private void CardAttack(){
        int damage = party.GetFowardCharacter().attack;
        enemy.TakeDamage(damage);
        MakeNumber(NumberIndicatorType.Damage, damage, enemy.transform.position);
    }

    private void CardBlock(){

    }

    private void CardSwap(){

    }

    private void CardStun(){

    }

    public void RunCard(Card c){
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
                    enemy.targets[Random.Range(0, 2)].health += 5;
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
