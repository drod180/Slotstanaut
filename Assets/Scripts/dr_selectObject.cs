/* This classs determines where something is clicked, and if it is on a particular object
 *
 * public: objectSelected: The object which is being checked for if it was clicked
 */

using UnityEngine;
using System.Collections;

public class dr_selectObject : MonoBehaviour {

	private Transform myTransform;
	public bool objectSelected;

	public dr_CameraPositionDetector usedCamera;
	// Use this for initialization
	void Start () {
		myTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {

		if (detectClickPosition ()) {
				objectSelected = true;
		}
	
	}

	private bool detectClickPosition(){

		Vector2 pos = myTransform.position;
		float posX = pos.x;
		float posY = pos.y;
		float sizeX = myTransform.localScale.x;
		float sizeY = myTransform.localScale.y;

		Vector2 mosPosTemp = Input.mousePosition;
		Vector2 mosPos = usedCamera.detectPosition (mosPosTemp);
		float mosPosX = mosPos.x;
		float mosPosY = mosPos.y;

		if (Input.GetMouseButtonDown (0)) {
			/*Debug.Log("PRINT OUT MOUSE COMPARISOINS");

			Debug.Log( mosPosX + "<" +(posX + sizeX/2));
			Debug.Log( mosPosX + ">" +(posX - sizeX/2));

			Debug.Log( mosPosY + "<" +(posY + sizeY/2));
			Debug.Log( mosPosY + ">" +(posY - sizeY/2));

			Debug.Log(mosPosX + "MOUSE POSISTION X");
			Debug.Log(mosPosY + "MOUSE POSISTION Y");
			Debug.Log(posX + "POSITION X");
			Debug.Log(posY + "PosITION Y");*/
			if( (mosPosX  < (posX + sizeX/2)) //Less than X bound
				&& (mosPosX > (posX - sizeX/2)) //Greater than -X bound
			    && (mosPosY < (posY + sizeY/2)) //Less than Y bound
			    && (mosPosY > (posY - sizeY/2)) ){ //Greater than -Y bound

					//Clicked in area
					return true;
			}

		// Touch detection
		} else if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) {
			if( (Input.GetTouch(0).position.x  < (posX + sizeX/2)) //Less than X bound
				&& (Input.GetTouch(0).position.x > (posX - sizeX/2)) //Greater than -X bound
			    && (Input.GetTouch(0).position.y < (posY + sizeY/2)) //Less than Y bound
			    && (Input.GetTouch(0).position.y > (posY - sizeY/2)) ) { //Greater than -Y bound

				//Clicked in area
				return true;
			}
		}
		
		//Didn't click in area
		return false;
	}
}
