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

	public Color baseColor = Color.white;

	public Color highDamageColor = Color.red;
	public int highDamageThreshold = 25;

	public Color blockColor = Color.blue;
	public Color healColor = Color.green;

	public AnimationCurve opacityCurve;
	private Vector3 start;
	private Vector3 end;
	private int damageValue;
	private TextMeshPro tmpro;
	private NumberIndicatorType type = NumberIndicatorType.Damage;

	void Start(){
		tmpro = GetComponent<TextMeshPro>();
		tmpro.SetText("{0}", damageValue);
	
		start = randVec3()	 * volatility + transform.position;
		end = start + Vector3.up * height + randVec3() * volatility;

		transform.position = start;
		StartCoroutine("Move");
	}

	IEnumerator Move() {
		float startTime = Time.time;
		Color faceColor = baseColor;
		if(type == NumberIndicatorType.Damage){
			faceColor = Color.Lerp(tmpro.fontMaterial.GetColor(ShaderUtilities.ID_FaceColor), highDamageColor, (float) damageValue / highDamageThreshold);
		} else if(type == NumberIndicatorType.Block){
			faceColor = blockColor;
		} else if(type == NumberIndicatorType.Heal) {
			faceColor = healColor;
		}
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

	public void setIndicatorType(NumberIndicatorType type){
		this.type = type;
	}

	private Vector3 randVec3(){
		return new Vector3(UnityEngine.Random.Range(-1f,1f), UnityEngine.Random.Range(-1f,1f), UnityEngine.Random.Range(-1f,1f));
	}

}

public enum NumberIndicatorType {
	Damage,
	Block,
	Heal
}