using UnityEngine;
using System.Collections;

public class LeftAndRightPlatform : MonoBehaviour {
	//This script will affect the X axis
	public float rightCap;
	public float leftCap;
	public float platformSpeed;
	private bool shouldGoLeft;
	// Use this for initialization
	void Start () {
		//rightCap += transform.position.x;
		//leftCap += transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x > rightCap)
			shouldGoLeft = true;
		if(transform.position.x < leftCap)
			shouldGoLeft = false;
		if(!shouldGoLeft)
			transform.Translate(Vector3.right * platformSpeed * Time.deltaTime);
		if(shouldGoLeft)
			transform.Translate(Vector3.left * platformSpeed * Time.deltaTime);
	}
}
