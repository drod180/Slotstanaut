using UnityEngine;
using System.Collections;

public class dr_RevolvedPlanet : MonoBehaviour {

	public float meteorsCrashed;
	public dr_characterCollision deadStatus;
	//Face body according to planet
	public void Orient(Transform body){
		Vector2 gravityUp = (body.position - transform.position).normalized;
		Vector2 bodySideways = body.right;
		
		Quaternion targetRotation = Quaternion.FromToRotation (bodySideways, gravityUp) * body.rotation;
		body.rotation = Quaternion.Lerp (body.rotation, targetRotation, 25 * Time.deltaTime);
	}

	void Start(){
		meteorsCrashed = 0;
	}

	void OnTriggerEnter2D(Collider2D other){
		//If player is still alive
		if(!deadStatus.deadStatus){
			//If meteor hits planet
			if (other.gameObject.tag == "Meteor") {
				meteorsCrashed++;
			}
		}
	}

}
 