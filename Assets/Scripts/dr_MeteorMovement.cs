using UnityEngine;
using System.Collections;

public class dr_MeteorMovement : MonoBehaviour {

	public GameObject planet;
	public float MeteorSpeed;
	private Vector2 target;

	private Transform myTransform;

	// Use this for initialization
	void Start () {
		myTransform = transform;
		planet = GameObject.Find ("Planet");
	}
	
	// Update is called once per frame
	void Update () {
		target.x = planet.transform.position.x;
		target.y = planet.transform.position.y;

		transform.position = Vector2.MoveTowards (new Vector2(myTransform.position.x, myTransform.position.y), target, MeteorSpeed * Time.deltaTime);
	}
}
