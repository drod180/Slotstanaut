using UnityEngine;
using System.Collections;

public class dr_StatisticSettings : MonoBehaviour {

	public dr_GameData gameData;
	public dr_selectObject statResetButton;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (statResetButton.objectSelected) {
			ResetStatistics();
			statResetButton.objectSelected = false;
		}
	}

	// Resets all statistics
	void ResetStatistics(){
		//Load all statistical values, set them to 0 and save

		gameData.Load ();
		Debug.Log ("highscore::::" + gameData.highScore);
		gameData.highScore = 0;
		//gameData.gamesPlayed = 0;
		Debug.Log ("Cleared highscore::::" + gameData.highScore);
		gameData.Save ();
	}
}
