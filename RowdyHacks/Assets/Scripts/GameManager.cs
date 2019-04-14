using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Animator anim;
    private Queue<Character> characterList;
    private List<Enemy> enemyList;



    void Start(){
    	anim = GetComponent<Animator>();
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

}
