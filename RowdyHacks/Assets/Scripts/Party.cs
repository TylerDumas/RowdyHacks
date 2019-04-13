using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Party : MonoBehaviour
{
	private Queue<Character> characterList;
	private int block;

	public void Rotate(int amount=1) {
		for(; amount > 0; amount--){
			characterList.Enqueue(characterList.Dequeue());
		}
	}

	public void TakeDamage(DamageEvent damage){
		Character activeCharacter = characterList.Peek();

		switch(damage.distribution){
			case DistributionType.ActiveOnly:
				activeCharacter.TakeDamage(damage.amount);
			break;
		}
	}

	public void AccrueBlock(int amount){
		this.block += amount;
	}

	public void ResetBlock(){
		this.block = 0;
	}

}
