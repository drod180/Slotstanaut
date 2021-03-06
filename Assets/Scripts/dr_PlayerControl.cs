﻿/*
 * Player control over ship
 *
 * public: playerShip: Game object the player controls
 * public thrusterPower: How fast the initial burst of the jump is
 * public thrustTime: How long the burst lasts
 *
*/
using UnityEngine;
using System.Collections;

public class dr_PlayerControl : MonoBehaviour {

	public dr_SpaceShipAutoMove playerShip;
	public dr_bottomHudControl buttonHud;

	public float thrusterPower = 2.0f;
	public float thrustTime = 1.0f;

	private float time;
	private float inputTime;
	private float inputTimeDif;
	private Animator shipAnimator;

	void Awake(){
		shipAnimator = GetComponent<Animator> ();
	}
	// Use this for initialization
	void Start () {
		time = 0.0f;
		inputTime = 0.0f;
	}

	// Update is called once per frame
	void Update () {
		//Constant Timer
		time += Time.deltaTime;

		//Set button press time
		if (Input.GetKeyDown (KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)) {
			buttonHud.pressButton();
			shipAnimator.SetTrigger("NoFlame");
			inputTime = time;
			//Starts game from pause
			if(Time.timeScale == 0){
				Time.timeScale = 1;
			}
			//Set animation to have flame
			shipAnimator.SetTrigger("Launched");
		}
		launch ();
	}

	void launch(){
		inputTimeDif = time - inputTime;

		//If recent enough since button press increase distance from planet
		if (thrustTime > inputTimeDif){
			playerShip.circleSize += thrusterPower * Time.deltaTime *(thrustTime - inputTimeDif);
		}
		//If long enough time since button press decrease distance at a faster rate
		else {
			playerShip.circleSize -= playerShip.circleShrinkSpeed * Time.deltaTime * (inputTimeDif * inputTimeDif);
		}
	}
}
