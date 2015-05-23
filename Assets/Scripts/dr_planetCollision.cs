using UnityEngine;
using System.Collections;

public class dr_planetCollision : MonoBehaviour {

	public AudioClip planetMeteorExplosion;
	
	private AudioSource meteorExplosionSource;
	
	void Awake(){
		meteorExplosionSource = GetComponent<AudioSource> ();
	}
	
	
	//Collision Detection
	void OnTriggerEnter2D(Collider2D other){
		//Collides with planet
		if (other.gameObject.tag == "Meteor") {
	//		Debug.Log("Meteor collides with planet");
			meteorExplosionSource.PlayOneShot (planetMeteorExplosion, 1);

		} 
	}

}
