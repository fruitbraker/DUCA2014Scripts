using UnityEngine;
using System.Collections;

public class MasterResetter : MonoBehaviour {
	public Transform[] gameObjects;
	private Vector3[] positions;
	public static bool shouldReset;
	// Use this for initialization
	void Start () {
		shouldReset = false;
		positions = new Vector3[gameObjects.Length];
		for(int i=0; i<gameObjects.Length; i++) {
			positions[i] = gameObjects[i].position;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(shouldReset) {
			for(int i=0; i<gameObjects.Length; i++) {
				gameObjects[i].position = positions[i];
			}
			shouldReset = false;
		}
	}
}
