/* This class loads all necessary game data at the start of the game
 * 
 * public gamedata: 
 * public startTime:
 */ 

using UnityEngine;
using System.Collections;

public class dr_GameStart : MonoBehaviour {
	public dr_GameData gameData;
	public dr_characterCollision character;

	public GameObject playButton;
	public GameObject menuButton;
	public GameObject gameScore;
	public GameObject highScoreText;
	public GameObject gameOverImage;

	public float startTime;
	// Use this for initialization
	void Start () {
		gameData.Load ();

		startTime = Time.time;

		gameData.gamesPlayed += 1;
		Debug.Log("Total games played : " + gameData.gamesPlayed);

		Debug.Log ("High Score?:" + gameData.highScore);
		gameData.Save ();

		character.deadStatus = false;
		BoxCollider2D trigger = character.GetComponent<BoxCollider2D> ();
		trigger.enabled = true;

		//Initialize some game objects to either display or not

		playButton.SetActive (false);
		menuButton.SetActive (false);
		gameOverImage.SetActive (false);
		highScoreText.SetActive (true);
		gameScore.SetActive (true);


		Time.timeScale = 0;

	}


}