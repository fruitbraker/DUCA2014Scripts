using UnityEngine;
using System.Collections;

public class SideWaysRollWheel : MonoBehaviour {
	public float rotationSpeed;
	public bool isZ, isY, isX;
	public bool isReverse;
	private float rotateCap;
	// Use this for initialization
	void Start () {
		if(isReverse)
			rotationSpeed *= -1;
	}
	
	// Update is called once per frame
	void Update () {
		if(isX)
			transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
		else if(isY)
			transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
		else if(isZ)
			transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
	}
}
