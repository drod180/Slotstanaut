/* This class loads all necessary game data at the start of the game
 * 
 * public gamedata: 
 * public startTime:
 */ 

using UnityEngine;
using System.Collections;

public class dr_GameStart : MonoBehaviour {
	public dr_GameData gameData;
	public float startTime;
	public dr_characterCollision character;
	public GameObject gameScore;
	public GameObject gameOverScore;
	public GameObject highScoreText;
	public GameObject gameOverImage;
	// Use this for initialization
	void Start () {
		gameData.Load ();

		startTime = Time.time;

		gameData.gamesPlayed += 1;
		Debug.Log("Total games played : " + gameData.gamesPlayed);
		gameData.Save ();

		character.deadStatus = false;
		BoxCollider2D trigger = character.GetComponent<BoxCollider2D> ();
		trigger.enabled = true;

		//Initialize some game objects to either display or not
		gameOverImage.SetActive (false);
		gameOverScore.SetActive (false);
		highScoreText.SetActive (false);
		gameScore.SetActive (true);

		Time.timeScale = 0;
	}


}