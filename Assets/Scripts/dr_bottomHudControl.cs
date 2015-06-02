using UnityEngine;
using System.Collections;

public class dr_bottomHudControl : MonoBehaviour {
	
	private Animator buttonAnimator;

	void Awake(){
		buttonAnimator = GetComponent<Animator> ();
	}

	public void pressButton(){
		Debug.Log ("Button presser");
		buttonAnimator.SetTrigger ("buttonIdled");
		buttonAnimator.SetTrigger("buttonPresser");

	}

}
