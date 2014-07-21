using UnityEngine;
using System.Collections;

public class PlatformSpawnZAxis : MonoBehaviour {
	public GameObject platform;
	public Transform platformSpawn;
	public float lengthCap;
	public bool isForward;
	// Use this for initialization
	void Start () {
		lengthCap += platform.transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		//This will affect the Z axis
		if(platform.transform.position.z > lengthCap && isForward) {
			platform.transform.position = platformSpawn.transform.position;
		}
		if(platform.transform.position.z < lengthCap && !isForward) {
			platform.transform.position = platformSpawn.transform.position;
		}
	}
}
