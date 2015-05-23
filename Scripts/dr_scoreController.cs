using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class dr_scoreController : MonoBehaviour {
	public dr_characterCollision scoreHolder;
	public dr_GameData gameData;
	public dr_RevolvedPlanet meteorNumber;

	private Text scoreText;
	private string textName;
	private float highScore;
	// Use this for initialization
	void Start () {
		scoreText = GetComponent<Text> ();
		textName = name;
		gameData.Load ();
		highScore = gameData.highScore; 
	}
	
	// Update is called once per frame
	void Update () {
		if(textName == "Game Score" || textName == "Game Over Score"){

		//	if (scoreHolder.lapNumber < 0) {
		//		scoreText.text = "0";
		//	} 
		//	else {
				//scoreText.text = "" + scoreHolder.lapNumber;
				scoreText.text = "" + meteorNumber.meteorsCrashed;
		//	}
		}
		else if(textName == "High Score Text"){

			scoreText.text = "" + highScore;
			//Debug.Log("High Score: " + highScore);
		}

	}
}
