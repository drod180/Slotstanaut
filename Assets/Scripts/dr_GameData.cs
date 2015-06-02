/* This class is responsible for the loading and saving of all game data
 * 
 * public: highScore: high score data
 * public gamesPlayed: games played data
 */

using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class dr_GameData : MonoBehaviour {
	public static dr_GameData gameData;

	public float highScore;
	public float gamesPlayed;
	// Use this for initialization
	void Awake () {

		// Forces a different code path in the BinaryFormatter that doesn't rely on run-time code generation (which would break on iOS).
		// http://answers.unity3d.com/questions/30930/why-did-my-binaryserialzer-stop-working.html
		Environment.SetEnvironmentVariable("MONO_REFLECTION_SERIALIZER","yes");

		if (gameData == null) {
			DontDestroyOnLoad(gameObject);
			gameData = this;
		}
		else if(gameData != this){
//			Destroy (gameObject); //Read article to figure out 
		}
	}

	//When Object is created
	void OnEnable(){
		Load ();
	}

	//When Object is destroyed
	void OnDisable(){
		Save ();
	}

	public void Save(){

		//Create or open file
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Open (Application.persistentDataPath + "/GameInfo.dat", FileMode.OpenOrCreate);

		//Create Container for data
		GameData data = new GameData ();
		data.gamesPlayed = gamesPlayed;
		data.highScore = highScore;
		//Save and close
		bf.Serialize (file, data);
		file.Close();
		/*
		Debug.Log("Data Saved~~~~~~~~~~~~~~~~~");
		Debug.Log("Total Games Played: " + data.gamesPlayed);
		Debug.Log("High Score: " + data.highScore);
		Debug.Log("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
		*/
	}

	public void Load(){
		//Check to make sure file exists
		if (File.Exists (Application.persistentDataPath + "/GameInfo.dat")) {
			//Open File
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/GameInfo.dat",FileMode.Open);

			//Create container and get data
			GameData data = (GameData)bf.Deserialize(file);

			//close file
			file.Close ();

			highScore = data.highScore;
			gamesPlayed = data.gamesPlayed;
			/*
			Debug.Log("Data Loaded###################");
			Debug.Log("Total Games Played: " + data.gamesPlayed);
			Debug.Log("High Score: " + data.highScore);
			Debug.Log("##############################");
			*/
		}
	}

	[Serializable]
	class GameData{
		public float highScore;
		public float gamesPlayed;
	}
}
