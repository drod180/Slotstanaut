using UnityEngine;
using System.Collections;

public class dr_difficultyScaling : MonoBehaviour {
	public dr_MeteorSpawn spawnRate;
	public dr_GameStart gameTime;

	private float timePassed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timePassed = Time.time - gameTime.startTime;
		scaleDifficulty (timePassed);
	}

	//Scales difficulty through the game
	void scaleDifficulty(float time){
		if(time < 10){
			spawnRate.spawnRateMultMin = .5f;
			spawnRate.spawnRateMultMax =  3f;
			spawnRate.spawnRateModifier = 4f;
		}
		else if(time < 25){
			spawnRate.spawnRateMultMin = .5f;
			spawnRate.spawnRateMultMax = 2.5f;
			spawnRate.spawnRateModifier = 3.75f;
		}
		else if (time < 40){
			spawnRate.spawnRateMultMin = .35f;
			spawnRate.spawnRateMultMax = 2.5f;
			spawnRate.spawnRateModifier = 3.5f;
		}
		else if (time < 60){
			spawnRate.spawnRateMultMin = .25f;
			spawnRate.spawnRateMultMax =  2.25f;
			spawnRate.spawnRateModifier = 3.25f;
		}
		else {
			spawnRate.spawnRateMultMin = .25f;
			spawnRate.spawnRateMultMax =  2.25f;
			spawnRate.spawnRateModifier = 3;
		}
	}
}
