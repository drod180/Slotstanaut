using UnityEngine;
using System.Collections;
//Example code on how to load a scene
public class dr_MenuControl : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown (KeyCode.UpArrow)){
			Application.LoadLevel("Space_Scene_1.0");
		}
		if(Input.GetKeyDown (KeyCode.DownArrow)){
			Application.LoadLevel("Main_Menu_Scene");
		}
		if(Input.GetKeyDown (KeyCode.RightArrow)){
			Application.LoadLevel("Settings_Menu_Scene");
		}
		if(Input.GetKeyDown (KeyCode.LeftArrow)){
			Application.LoadLevel("Stats_Menu_Scene");
		}
	}

}
