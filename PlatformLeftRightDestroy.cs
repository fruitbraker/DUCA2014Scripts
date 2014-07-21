using UnityEngine;
using System.Collections;

public class PlatformLeftRightDestroy : MonoBehaviour {
	public float platformSpeed;
	public bool isRight;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//This will affect the X axis
		if(isRight)
			transform.Translate (Vector3.right * Time.deltaTime * platformSpeed);
		if(!isRight)
			transform.Translate (Vector3.left * Time.deltaTime * platformSpeed);
	}
}
