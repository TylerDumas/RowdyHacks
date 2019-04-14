using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Animator anim;
    private List<Character> characterList;
    private List<Enemy> enemyList;



    void Start(){
<<<<<<< HEAD
    	anim = GetComponent<anim>();
=======
    	amin = GetComponent<anim>();
>>>>>>> 3e5c41b36f6025dac63883d909048be48e92648e
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
    	} else if(CurrentState.IsName("ReturnCardsToDeckPhase")){
    		ReturnCardsToDeckPhase();
    	} else if(CurrentState.IsName("PlayerSwapPhase")) {
    		PlayerSwapPhase();
    	} else if(CurrentState.IsName("Victory")) {
    		Victory();
    	} else if(CurrentState.IsName("Failure")){
    		Failure();
    	} else if(CurrentState.IsName("Cleanup")){
    		Cleanup();
    	}
    }

    private void BattleSetup(){
    	;
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
