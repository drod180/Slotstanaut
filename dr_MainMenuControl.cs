/* Menu control for the main menu
 * 
 * public startButton: Start button object
 * public optoinButton: option button object
 * public statsButton: statistics button object
 * public exitButton: exit button object
 */

using UnityEngine;
using System.Collections;

public class dr_MainMenuControl : MonoBehaviour {
	public dr_selectObject startButton;
	public dr_selectObject optionsButton;
	public dr_selectObject statsButton;
	public dr_selectObject exitButton;
	private dr_selectObject noButton;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		string selectedButton = determineObject ();
			switch (selectedButton) {
			case "startButton":
					startButton.objectSelected = false;
					Application.LoadLevel ("Space_Scene_1.0");				
					break;
			case "optionsButton":
					optionsButton.objectSelected = false;
					Application.LoadLevel ("Settings_Menu_Scene");
					
					break;
			case "statsButton":
					statsButton.objectSelected = false;
					Application.LoadLevel ("Stats_Menu_Scene");
					
					break;
			case "exitButton":
					exitButton.objectSelected = false;
					Debug.Log ("quit game~!");

					break;
			case "noButton":
					break;
			default:
					Debug.Log ("Error case should not have got here dr_MainMenuControl.cs");
					break;
	
			}
	}

	private string determineObject(){

		if (startButton.objectSelected) {
			return "startButton";
		} else if (optionsButton.objectSelected) {
			return "optionsButton";
		} else if (statsButton.objectSelected) {
			return "statsButton";
		} else if (exitButton.objectSelected) {
			return "exitButton";
		} else {
			return "noButton";
		}
	}
}

