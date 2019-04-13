using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Class that manages the party. Acts as a damage target for enemies
 * And divies up damage and such as needed.
 */
public class Party : MonoBehaviour
{
	private Queue<Character> characterList;
	private int block;

	/*
	 * Rotates the party moving the foward most unit
	 * to the back.
	 *
	 * amount : int (default 1)
	 *    The amount of times to move the front most
	 *    unit to the back.
	 */
	public void Rotate(int amount=1) {
		for(; amount > 0; amount--){
			characterList.Enqueue(characterList.Dequeue());
		}
	}

	/*
	 * Applies damage from a DamageEvent to the party
	 *
	 * damage : DamageEvent
	 *    Represents the amount of damage and distribution
	 *    stratagy for the incoming attack.
	 */
	public void TakeDamage(DamageEvent damage){
		Character activeCharacter = characterList.Peek();

		switch(damage.distribution){
			case DistributionType.ActiveOnly:
				activeCharacter.TakeDamage(damage.amount);
			break;
		}
	}

	/*
	 * Increases the amount of block the party has for the front most
	 * unit.
	 *
	 * amount : int
	 *    the amount of block to accrue.
	 */
	public void AccrueBlock(int amount){
		this.block += amount;
	}

	/*
	 * Sets the parties block back to zero.
	 */
	public void ResetBlock(){
		this.block = 0;
	}
}
