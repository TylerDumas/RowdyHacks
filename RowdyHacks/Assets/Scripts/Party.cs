using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Party : MonoBehaviour
{
	private Queue<Character> characterList;
	private Character activeCharacter;
	private int block;

	public void Rotate(int amount=1) {
		for(; amount > 0; amount--){
			characterList.Enqueue(characterList.Dequeue());
		}
	}

	public void TakeDamage(DamageEvent damage){
		//unimplemented
	}
}
