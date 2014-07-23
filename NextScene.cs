using UnityEngine;
using System.Collections;

public class NextScene : MonoBehaviour {
	public string sceneName;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			Application.LoadLevel(sceneName);
		}
	}
}
