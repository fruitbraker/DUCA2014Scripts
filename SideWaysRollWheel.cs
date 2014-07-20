using UnityEngine;
using System.Collections;

public class SideWaysRollWheel : MonoBehaviour {
	public float rotationSpeed;
	private float rotateCap;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
	}
}
