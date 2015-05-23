using UnityEngine;
using System.Collections;

public class dr_spawnCharacter : MonoBehaviour {
	public dr_SpaceShipAutoMove characterValues;
	public float respawnHeight;

	//Respawn the character 
	public void respawn (){
		// Set height to respawnHeight
		characterValues.circleSize = respawnHeight;
	}
}
