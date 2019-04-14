using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Class that manages the party. Acts as a damage target for enemies
 * And divies up damage and such as needed.
 */
public class Party : MonoBehaviour
{
	private List<Character> characterList;
	private int block;
	public int energy;

	/*
	 * Rotates the party moving the foward most unit
	 * to the back.
	 *
	 * amount : int (default 1)
	 *    The amount of times to move the front most
	 *    unit to the back.
	 */
	public void Rotate(SwapDircetion dir) {
		Character c;
		int index;
		if(dir == SwapDircetion.Left){
			c = characterList[0];
			characterList.RemoveAt(0);
			characterList.Add(c);
		} else if(dir == SwapDircetion.Right){
			c = characterList[2];
			characterList.RemoveAt(2);
			characterList.Insert(0, c);
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
		Character activeCharacter = characterList[2];

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

public enum SwapDircetion {
	Right,
	Left
}