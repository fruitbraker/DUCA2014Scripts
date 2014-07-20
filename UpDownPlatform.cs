using UnityEngine;
using System.Collections;

public class UpDownPlatform : MonoBehaviour {
	//This script will affect the Y axis
	public float heightCap;
	public float bottomCap;
	public float platformSpeed;
	private bool shouldGoDown;
	// Use this for initialization
	void Start () {
		heightCap += transform.position.y;
		bottomCap += transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y > heightCap)
			shouldGoDown = true;
		if(transform.position.y < bottomCap)
			shouldGoDown = false;
		if(!shouldGoDown)
			transform.Translate(Vector3.up * platformSpeed * Time.deltaTime);
		if(shouldGoDown)
			transform.Translate(Vector3.down * platformSpeed * Time.deltaTime);
	}
}
