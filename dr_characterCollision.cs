/* This class is used to decide what to do when the character collides with other game objects
 * 
 * public gameData: gameData object for saving and loading data
 * 
 */

using UnityEngine;
using System.Collections;

public class dr_characterCollision : MonoBehaviour {
	public float crashTime;
	public dr_GameData gameData;
	public AudioClip shipMeteorExplosion;
	public AudioClip shipPlanetExplosion;
	public GameObject gameOverImage;
	public GameObject gameOverImageHigh;
	public GameObject gameOverImageStandard;
	public GameObject gameScore;
	public GameObject gameOverScore;
	public GameObject highScoreText;
	public bool deadStatus;
	public dr_RevolvedPlanet meteorScore; //Meteor's crashed
	public float lapNumber = -1; //laps completed


	private AudioSource meteorExplosionSource;
	private AudioSource planetExplosionSource;
	private Animator shipAnimator;

	void Awake(){
		meteorExplosionSource = GetComponent<AudioSource> ();
		planetExplosionSource = GetComponent<AudioSource> ();
		shipAnimator = GetComponent<Animator> ();

	}
	
	//Collision Detection
	private void OnTriggerEnter2D(Collider2D other){
		//Collides with planet
		if (other.gameObject.name == "Planet") {
			planetExplosionSource.PlayOneShot (shipPlanetExplosion, 1);
			Debug.Log("Crashed into planet");
			gameOver();
		} 
		//Collides with a Meteor
		else if (other.gameObject.tag == "Meteor") {
			meteorExplosionSource.PlayOneShot (shipMeteorExplosion, 1);
			Debug.Log("Crashed into meteor");
			gameOver();
		}
		else if (other.gameObject.tag == "Bound"){
			meteorExplosionSource.PlayOneShot (shipMeteorExplosion, 1);
			Debug.Log("Crashed into wall");
			gameOver();
		}
		else if (other.gameObject.tag == "Lap"){
			completedLap();
		}
	}

	private void gameOver(){
		deadStatus = true;
		BoxCollider2D trigger = gameObject.GetComponent<BoxCollider2D> ();
		trigger.enabled = false;
		//shipAnimator.SetTrigger("dead1");
		//shipAnimator.SetTrigger("dead2");
		//shipAnimator.SetTrigger("dead3");
		shipAnimator.SetTrigger("dead4");
		gameData.Load ();
		if (gameData.highScore < meteorScore.meteorsCrashed) {

			Debug.Log ("New High Score : " + meteorScore.meteorsCrashed);
			gameData.highScore = meteorScore.meteorsCrashed;
			gameData.Save ();

			//Set the proper death screen views active
			gameOverImage.GetComponent<SpriteRenderer>().sprite = gameOverImageHigh.GetComponent<SpriteRenderer>().sprite;
			gameOverScore.SetActive (true);
			gameScore.SetActive (false);
		}
		else{
			//Set the proper death screen views active
			gameOverImage.GetComponent<SpriteRenderer>().sprite = gameOverImageStandard.GetComponent<SpriteRenderer>().sprite;
			gameOverScore.SetActive (true);
			highScoreText.SetActive (true);
			gameScore.SetActive (false);
		}
		gameOverImage.SetActive (true);
	}

	private void completedLap(){
		lapNumber++;
		Debug.Log ("Lap Number: " + lapNumber);
	}
}
