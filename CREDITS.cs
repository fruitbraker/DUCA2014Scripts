using UnityEngine;
using System.Collections;

public class CREDITS : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("GOBACK", 16);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void GOBACK() {
		Application.LoadLevel("OpeningScene");
	}
}
