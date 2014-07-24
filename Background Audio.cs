using UnityEngine;
using System.Collections;

public class BackgroundAudio : MonoBehaviour {
	public GameObject audio;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Awake() {
		Object.DontDestroyOnLoad (audio);	
	}

}
