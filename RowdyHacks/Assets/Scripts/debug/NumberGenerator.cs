using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGenerator : MonoBehaviour
{
    
	private UnityEngine.Object numberPrefab;

	void Start(){
		numberPrefab = Resources.Load("Number");
	}

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
        	int damage = (int) Mathf.Round(UnityEngine.Random.Range(1, 25));
        	Debug.Log(String.Format("New Damage: {0}", damage));
        	GameObject number = Instantiate(numberPrefab) as GameObject;
        	number.GetComponent<DamageNumberController>().setDamageValue(damage);
        }
    }
}
