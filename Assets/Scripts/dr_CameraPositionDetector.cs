/* This class is used to determine where something is positioned in relation to the camera
 * 
 * Mainly used for clicking specific spots on the screen
 * 
 * public detectPosition: Functoin which checks a particular vector2 input and translates it into a Vector2 camera position
 */


using UnityEngine;
using System.Collections;

public class dr_CameraPositionDetector : MonoBehaviour {
	

	public Vector2 detectPosition(Vector2 inputPosition){
		Vector2 outputPosition = GetComponent<Camera>().ScreenToWorldPoint (inputPosition);
		return outputPosition;
	}
}
