/* Dictates where the Meteors will spawn as well as the rate
 * 
 * public spawnRateModifier: Spawn rate multipler
 * public spawnRateMultMax:  Randomized spawn Rate multiplier Max
 * public spawnRateMultMin:  Randomized spawn Rate multiplier Min
 * 
 */

using UnityEngine;
using System.Collections;

public class dr_MeteorSpawn : MonoBehaviour {

	public float spawnRateModifier;      //Spawn rate multipler
	public float spawnRateMultMax;       //Randomized spawn Rate multiplier Max
	public float spawnRateMultMin;       //Randomized spawn Rate multiplier Min
	public GameObject MeteorPrefab;		 //Meteor gameObject
	public float spawnRate;             //Spawn Rate

	private Transform myTransform;
	private float time;         	     //Game Timer
	private float spawnTimeDif;          //Time SINCE last spawn

	//To do: turn this into an array
	private float lastSpawnTimeSection1;   //Last Spawn time for section 1
	private float lastSpawnTimeSection2;   //Last Spawn time for section 2
	private float lastSpawnTimeSection3;   //Last Spawn time for section 3
	private float lastSpawnTimeSection4;   //Last Spawn time for section 4
	private float lastSpawnTimeSection5;   //Last Spawn time for section 1
	private float lastSpawnTimeSection6;   //Last Spawn time for section 2
	private float lastSpawnTimeSection7;   //Last Spawn time for section 3
	private float lastSpawnTimeSection8;   //Last Spawn time for section 4

	private float spawnRateSection1;             //Spawn Rate for section 1
	private float spawnRateSection2;             //Spawn Rate for section 2
	private float spawnRateSection3;             //Spawn Rate for section 3
	private float spawnRateSection4;             //Spawn Rate for section 4
	private float spawnRateSection5;             //Spawn Rate for section 1
	private float spawnRateSection6;             //Spawn Rate for section 2
	private float spawnRateSection7;             //Spawn Rate for section 3
	private float spawnRateSection8;             //Spawn Rate for section 4

	// Use this for initialization
	void Start () {
		//Find out which bound the script is running on
		time = 0.0f; 
		//Set first spawn time value
		lastSpawnTimeSection1 = 0;
		lastSpawnTimeSection2 = 0;
		lastSpawnTimeSection3 = 0;
		lastSpawnTimeSection4 = 0;
		lastSpawnTimeSection5 = 0;
		lastSpawnTimeSection6 = 0;
		lastSpawnTimeSection7 = 0;
		lastSpawnTimeSection8 = 0;

		//Set first spawn rate value
		spawnRateSection1 = spawnRateModifier * Random.Range(spawnRateMultMin,spawnRateMultMax);;
		spawnRateSection2 = spawnRateModifier * Random.Range(spawnRateMultMin,spawnRateMultMax);;
		spawnRateSection3 = spawnRateModifier * Random.Range(spawnRateMultMin,spawnRateMultMax);;
		spawnRateSection4 = spawnRateModifier * Random.Range(spawnRateMultMin,spawnRateMultMax);;
		spawnRateSection5 = spawnRateModifier * Random.Range(spawnRateMultMin,spawnRateMultMax);;
		spawnRateSection6 = spawnRateModifier * Random.Range(spawnRateMultMin,spawnRateMultMax);;
		spawnRateSection7 = spawnRateModifier * Random.Range(spawnRateMultMin,spawnRateMultMax);;
		spawnRateSection8 = spawnRateModifier * Random.Range(spawnRateMultMin,spawnRateMultMax);;
	}
	
	// Update is called once per frame
	void Update () {
		//Constant Timer
		time += Time.deltaTime;

		//Runs the spawning function to determine if and where the device will spawn
		spawn ();

	}


	//Determines in which quadrant of the circle the device should spawn a meteor
	//Each quadrant has its own spawn rate which changes after each spawn
	private void spawn(){

		float spawnTimeDifSection1;
		float spawnTimeDifSection2;
		float spawnTimeDifSection3;
		float spawnTimeDifSection4;
		float spawnTimeDifSection5;
		float spawnTimeDifSection6;
		float spawnTimeDifSection7;
		float spawnTimeDifSection8;

		//Determine time since last spawn for each section
		spawnTimeDifSection1 = time - lastSpawnTimeSection1;
		spawnTimeDifSection2 = time - lastSpawnTimeSection2;
		spawnTimeDifSection3 = time - lastSpawnTimeSection3;
		spawnTimeDifSection4 = time - lastSpawnTimeSection4;
		spawnTimeDifSection5 = time - lastSpawnTimeSection5;
		spawnTimeDifSection6 = time - lastSpawnTimeSection6;
		spawnTimeDifSection7 = time - lastSpawnTimeSection7;
		spawnTimeDifSection8 = time - lastSpawnTimeSection8;

	    //Spawn Meteor Section 1
		if (spawnTimeDifSection1 > spawnRateSection1) {

			float theta = Random.Range(0, 0.785f);
			float xPos = Mathf.Sin (theta) * 5;
			float yPos = Mathf.Cos (theta) * 5;

			//Create meteor
			Instantiate(MeteorPrefab, new Vector3(xPos, yPos, 0),Quaternion.identity);

			//Create next meteors spawn rate
			spawnRateSection1 = spawnRateModifier * Random.Range(spawnRateMultMin,spawnRateMultMax);

			//Mark time for spawn
			lastSpawnTimeSection1 = time;
		}

		//Spawn Meteor Section 2
		if (spawnTimeDifSection2 > spawnRateSection2) {


			float theta = Random.Range(0.7851f, 1.57f);
			float xPos = Mathf.Sin (theta) * 5;
			float yPos = Mathf.Cos (theta) * 5;

			//Create meteor
			Instantiate(MeteorPrefab, new Vector3(xPos, yPos, 0),Quaternion.identity);

			//Create next meteors spawn rate
			spawnRateSection2 = spawnRateModifier * Random.Range(spawnRateMultMin,spawnRateMultMax);

			//Mark time for spawn
			lastSpawnTimeSection2 = time;
		}

		//Spawn Meteor Section 3
		if (spawnTimeDifSection3 > spawnRateSection3) {

			float theta = Random.Range(1.571f, 2.356f);
			float xPos = Mathf.Sin (theta) * 5;
			float yPos = Mathf.Cos (theta) * 5;

			//Create meteor
			Instantiate(MeteorPrefab, new Vector3(xPos, yPos, 0),Quaternion.identity);

			//Create next meteors spawn rate
			spawnRateSection3 = spawnRateModifier * Random.Range(spawnRateMultMin,spawnRateMultMax);

			//Mark time for spawn
			lastSpawnTimeSection3 = time;
		}

		//Spawn Meteor Section 4
		if (spawnTimeDifSection4 > spawnRateSection4) {

			float theta = Random.Range(2.3561f, 3.141f);
			float xPos = Mathf.Sin (theta) * 5;
			float yPos = Mathf.Cos (theta) * 5;

			//Create meteor
			Instantiate(MeteorPrefab, new Vector3(xPos, yPos, 0),Quaternion.identity);

			//Create next meteors spawn rate
			spawnRateSection4 = spawnRateModifier * Random.Range(spawnRateMultMin,spawnRateMultMax);

			//Mark time for spawn
			lastSpawnTimeSection4 = time;
		}

		//Spawn Meteor Section 5
		if (spawnTimeDifSection5 > spawnRateSection5) {

			float theta = Random.Range(3.1411f, 3.927f);
			float xPos = Mathf.Sin (theta) * 5;
			float yPos = Mathf.Cos (theta) * 5;

			//Create meteor
			Instantiate(MeteorPrefab, new Vector3(xPos, yPos, 0),Quaternion.identity);

			//Create next meteors spawn rate
			spawnRateSection5 = spawnRateModifier * Random.Range(spawnRateMultMin,spawnRateMultMax);

			//Mark time for spawn
			lastSpawnTimeSection5 = time;
		}

		//Spawn Meteor Section 6
		if (spawnTimeDifSection6 > spawnRateSection6) {


			float theta = Random.Range(3.9271f, 4.712f);
			float xPos = Mathf.Sin (theta) * 5;
			float yPos = Mathf.Cos (theta) * 5;

			//Create meteor
			Instantiate(MeteorPrefab, new Vector3(xPos, yPos, 0),Quaternion.identity);

			//Create next meteors spawn rate
			spawnRateSection6 = spawnRateModifier * Random.Range(spawnRateMultMin,spawnRateMultMax);

			//Mark time for spawn
			lastSpawnTimeSection6 = time;
		}

		//Spawn Meteor Section 7
		if (spawnTimeDifSection7 > spawnRateSection7) {
	
			float theta = Random.Range(4.7121f, 5.497f);
			float xPos = Mathf.Sin (theta) * 5;
			float yPos = Mathf.Cos (theta) * 5;

			//Create meteor
			Instantiate(MeteorPrefab, new Vector3(xPos, yPos, 0),Quaternion.identity);

			//Create next meteors spawn rate
			spawnRateSection7 = spawnRateModifier * Random.Range(spawnRateMultMin,spawnRateMultMax);

			//Mark time for spawn
			lastSpawnTimeSection7 = time;
		}

		//Spawn Meteor Section 8
		if (spawnTimeDifSection8 > spawnRateSection8) {
	
			float theta = Random.Range(5.4971f, 6.283f);
			float xPos = Mathf.Sin (theta) * 5;
			float yPos = Mathf.Cos (theta) * 5;

			//Create meteor
			Instantiate(MeteorPrefab, new Vector3(xPos, yPos, 0),Quaternion.identity);

			//Create next meteors spawn rate
			spawnRateSection8 = spawnRateModifier * Random.Range(spawnRateMultMin,spawnRateMultMax);

			//Mark time for spawn
			lastSpawnTimeSection8 = time;
		}
	}
}

//LEGACY CODE BELOW

/*Determine if a particular quardrant should spawn
	private void calculateSpawn(){
		
		spawnTimeDif = time - lastSpawnTime;
		
		//Create Spawn Rate
		if(!spawnRateFlag){
			
			spawnRate = spawnRateModifier * Random.Range(spawnRateMultMin,spawnRateMultMax);
			spawnRateFlag = true;
		}
	}*/

/*
	//Spawns Meteors
	//Boolean side : Side border == TRUE, Top/bottom border == FALSE
	//Float xPos: x coord
	//Float yPos: y coord
	private void spawn(bool side, float xPos, float yPos){


		calculateSpawn ();

		//Debug.Log ("is" + spawnTimeDif + ">" + spawnRate + "?");
		//Right/Left
		if(side){
			//Spawn Meteor
			if (spawnTimeDif > spawnRate) {
				float randomValueY = Random.Range(-yPos, yPos);
				Instantiate(MeteorPrefab, new Vector3(xPos, randomValueY, 0),Quaternion.identity);
				lastSpawnTime = time;
			}
			//Reset Flag to ensure it will rechoose a spawn rate
			spawnRateFlag = false;

		}
		//Top/Bottom
		else{
			//Spawn Meter
			if (spawnTimeDif > spawnRate) {

				float randomValueX = Random.Range(-xPos, xPos);			
				Instantiate(MeteorPrefab, new Vector3(randomValueX, yPos, 0),Quaternion.identity);
				lastSpawnTime = time;
			}
			//Reset Flag to ensure it will rechoose a spawn rate
			spawnRateFlag = false;
		}

	}
	*/



/*switch(spawnStart)
		{
		case "TopBound":

			spawn(false, spawnScale_x/2, spawnPosition_y);

			break;

		case "BottomBound":

			spawn(false, spawnScale_x/2, spawnPosition_y);

			break;

		case "RightBound":

			spawn(true, spawnPosition_x, spawnScale_y/2);
			
			break;

		case "LeftBound":

			spawn(true, spawnPosition_x, spawnScale_y/2);

			break;

		default:
			Debug.Log ("Not a proper bound");
			break;
		}
		*/


/*
	//Calculates Spawn time
	private void calculateSpawn(){

		spawnTimeDif = time - lastSpawnTime;
		
		//Create Spawn Rate
		if(!spawnRateFlag){
			
			spawnRate = spawnRateModifier * Random.Range(spawnRateMultMin,spawnRateMultMax);
			spawnRateFlag = true;
		}
	}
	*/