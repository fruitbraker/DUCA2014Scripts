using UnityEngine;
using System.Collections;

public class ForwardAndBackPlatform : MonoBehaviour {
	//This script will affect the Z axis
	public float forwardCap;
	public float backCap;
	public float platformSpeed;
	private bool shouldGoBack;
	// Use this for initialization
	void Start () {
		//forwardCap += transform.position.z;
		//backCap += transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.z > forwardCap)
			shouldGoBack = true;
		if(transform.position.z < backCap)
			shouldGoBack = false;
		if(!shouldGoBack)
			transform.Translate(Vector3.forward * platformSpeed * Time.deltaTime);
		if(shouldGoBack)
			transform.Translate(Vector3.back * platformSpeed * Time.deltaTime);
	}
}
