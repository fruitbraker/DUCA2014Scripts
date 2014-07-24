using UnityEngine;
using System.Collections;

public class NextScene : MonoBehaviour {
	public string sceneName;
	public bool isTrophy;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			if(isTrophy)
				other.gameObject.GetComponent<PlayerController>().PlaySound(1);
			Application.LoadLevel(sceneName);
		}
	}
}
