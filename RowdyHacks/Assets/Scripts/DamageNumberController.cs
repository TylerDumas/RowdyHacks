using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class DamageNumberController : MonoBehaviour
{
	public float volatility = 1f;
	public float duration = 3f;
	public float height = 2f;
	public AnimationCurve opacityCurve;
	private Vector3 start;
	private Vector3 end;
	private int damageValue;
	private TextMeshPro tmpro;

	void Start(){
		tmpro = GetComponent<TextMeshPro>();
		tmpro.SetText("{0}", damageValue);
	
		start = randVec3() * volatility + transform.position;
		end = start + Vector3.up * height + randVec3() * volatility;

		transform.position = start;
		StartCoroutine("Move");
	}

	IEnumerator Move() {
		float startTime = Time.time;
		Color faceColor = tmpro.fontMaterial.GetColor(ShaderUtilities.ID_FaceColor);
		Color underlayColor = tmpro.fontMaterial.GetColor(ShaderUtilities.ID_UnderlayColor);
		float cursor = 0;
		while(cursor <= 1) {
			cursor = Time.time - startTime;
			float opacity = Mathf.Clamp(opacityCurve.Evaluate(cursor), 0, 1);
			tmpro.fontMaterial.SetColor(ShaderUtilities.ID_FaceColor, 
				new Color(faceColor.r, faceColor.g, faceColor.b, opacity));
			tmpro.fontMaterial.SetColor(ShaderUtilities.ID_UnderlayColor, 
				new Color(underlayColor.r, underlayColor.g, underlayColor.b, opacity));
			transform.position = Vector3.Lerp(start, end, cursor / duration);
			yield return null;
		}
		DestroyObject(gameObject);
	}

	void OnDrawGizmos(){
		Gizmos.color = Color.red;
		Gizmos.DrawLine(start, end);
	}

	public void setDamageValue(int n){
		this.damageValue = n;
		if(tmpro != null){
			Debug.Log("Setting Text directrly");
			tmpro.SetText("{0}", this.damageValue);
		}
	}

	private Vector3 randVec3(){
		return new Vector3(UnityEngine.Random.Range(-1f,1f), UnityEngine.Random.Range(-1f,1f), UnityEngine.Random.Range(-1f,1f));
	}

}
