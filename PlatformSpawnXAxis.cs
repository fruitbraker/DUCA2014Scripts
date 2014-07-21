using UnityEngine;
using System.Collections;

public class PlatformSpawnXAxis : MonoBehaviour {
	public GameObject platform;
	public Transform platformSpawn;
	public float lengthCap;
	public bool isRight;
	// Use this for initialization
	void Start () {
		lengthCap += platform.transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		//This will affect the X axis
		if(platform.transform.position.x > lengthCap && isRight) {
			platform.transform.position = platformSpawn.transform.position;
		}
		if(platform.transform.position.x < lengthCap && !isRight) {
			platform.transform.position = platformSpawn.transform.position;
		}
	}
}
