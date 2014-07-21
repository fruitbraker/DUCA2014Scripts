using UnityEngine;
using System.Collections;

public class PlatformForwardBackDestroy : MonoBehaviour {
	public float platformSpeed;
	public bool isForward;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//This will affect the Z axis
		if(isForward)
			transform.Translate (Vector3.forward * Time.deltaTime * platformSpeed);
		if(!isForward)
			transform.Translate (Vector3.back * Time.deltaTime * platformSpeed);
	}
}
