using UnityEngine;
using System.Collections;

public class PlatformSpawn : MonoBehaviour {
	public GameObject platform;
	public Transform platformSpawn;
	public float heightCap;
	// Use this for initialization
	void Start () {
		heightCap += platform.transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		if(platform.transform.position.y > heightCap) {
			platform.transform.position = platformSpawn.transform.position;
		}
	}
}
