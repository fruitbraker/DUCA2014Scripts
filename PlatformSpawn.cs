using UnityEngine;
using System.Collections;

public class PlatformSpawn : MonoBehaviour {
	public GameObject platform;
	public Transform platformSpawn;
	public float lengthCap;
	public bool isUp;
	// Use this for initialization
	void Start () {
		lengthCap += platform.transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		//This will affect the Y axis
		if(platform.transform.position.y > lengthCap && isUp) {
			platform.transform.position = platformSpawn.transform.position;
		}
		if(platform.transform.position.y < lengthCap && !isUp) {
			platform.transform.position = platformSpawn.transform.position;
		}
	}
}
