using UnityEngine;
using System.Collections;

public class dr_MeteorCollision : MonoBehaviour {
	

	private Animator meteorAnimator;
	private float meteorCollisionTime;

	void Awake(){
		meteorAnimator = GetComponent<Animator> ();
		meteorCollisionTime = Time.time + 100;

	}

	void Update(){
		meteorDestory(this.gameObject);
	}
	//Collision Detection
	void OnTriggerEnter2D(Collider2D other){
		//Collides with planet
		if (other.gameObject.name == "Planet") {
			meteorAnimator.SetTrigger("Crashed");
			//Debug.Log("Collide with planet");
			meteorCollisionTime = Time.time;
			//Destroy(this.gameObject);
		} 
		//Collides with Player
		else if (other.gameObject.name == "Character") {
			Destroy(this.gameObject);
			//Debug.Log("Collide with ship");

		} 

		//Collides with another Meteor
		else if (other.gameObject.tag == "Meteor") {
			//Debug.Log("Collide with another meteor");
		}
	}

	//Create a delay so that the animation can play before removing the game object
	void meteorDestory(GameObject meteor){
		if (Time.time > meteorCollisionTime + 0.36f) {
			Destroy (meteor);
		}
	}
}
