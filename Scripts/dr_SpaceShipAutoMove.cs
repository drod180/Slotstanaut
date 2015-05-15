/* Determines the movement physics of the character
 * 
 * Public planet: Planet that the ship revolves around
 * public character: Ship
 * public gameStartObject: Object that is always part of the game and also determined when the game instance starts
 */

using UnityEngine;
using System.Collections;

public class dr_SpaceShipAutoMove : MonoBehaviour {
	
	public dr_RevolvedPlanet planet;
	public dr_characterCollision character;
	public dr_GameStart gameStartObject;

	public float circleSpeed = 1;
	public float circleSize = 1;
	public float circleShrinkSpeed = 0.1f;
	
	private Transform myTransform;

	// Use this for initialization
	void Start () {
		myTransform = transform;
		//Set starting position
		circleSize = .95f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//Keeps the player facing the correct direction
		planet.Orient (myTransform);
		Orbit(myTransform);
	}

	// Function to travel around the planet in a circle
	private void Orbit (Transform orbiter)
	{
	
		float timeValue = calculateLastReset();

		//Move in a circle faster closer to the planet
		Vector2 tempPos;
		float xPos = Mathf.Sin (timeValue * circleSpeed) * circleSize;
		float yPos = Mathf.Cos (timeValue * circleSpeed) * circleSize;
	//	circleSize -= (circleShrinkSpeed * Time.deltaTime);
		
		//Debug.Log("CircleSize: " + circleSize);
		tempPos.x = xPos;
		tempPos.y = yPos;

		//Only change position if you are alive
		if(character.deadStatus == false){
			orbiter.position = tempPos;
		}
	}

	float calculateLastReset(){

		float lastReset;
		if(character.crashTime > gameStartObject.startTime){
			
			lastReset = character.crashTime;
			
		}
		else{
			lastReset = gameStartObject.startTime;
		}
		return (Time.time - lastReset);
	}
	
}
