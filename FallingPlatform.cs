using UnityEngine;
using System.Collections;

public class FallingPlatform : MonoBehaviour {
	private bool shouldFall;
	public GameObject platform;
	public float fallSpeed;
	public float yPos;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(shouldFall)
			transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);
		if(transform.position.y < yPos)
			Destroy(platform);

	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Player")
			shouldFall = true;
	}
}
