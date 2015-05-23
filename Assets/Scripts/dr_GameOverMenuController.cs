/* Class to manage the game over menu/overlay
 * 
 * public startButton: Start button object
 * public munuButton: Menu Button object
 */


using UnityEngine;
using System.Collections;

public class dr_GameOverMenuController : MonoBehaviour {
	public dr_selectObject startButton;
	public dr_selectObject menuButton;
	public dr_characterCollision deadStatus;
	private dr_selectObject noButton;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(deadStatus.deadStatus == true){
			string selectedButton = determineObject ();
			switch (selectedButton) {
			case "startButton":
				startButton.objectSelected = false;
				Application.LoadLevel ("Space_Scene_1.0");				
				break;
			case "menuButton":
				menuButton.objectSelected = false;
				Application.LoadLevel ("Main_Menu_Scene");
				break;
			case "noButton":
				break;
			default:
				Debug.Log ("Error case should not have got here dr_MainMenuControl.cs");
				break;
			}	
		}
	}
	
	private string determineObject(){
		
		if (startButton.objectSelected) {
			return "startButton";
		} else if (menuButton.objectSelected) {
			return "menuButton";
		} else {
			return "noButton";
		}
	}
}
