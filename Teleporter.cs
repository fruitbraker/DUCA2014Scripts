using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class Teleporter : MonoBehaviour {
	public GameObject target;
	private Collider other;
	private bool isTeleporting = false;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider other) {
		this.other = other;
		isTeleporting = true;
		Invoke("teleport", 3);
	}

	void OnTriggerExit(Collider other) {
		if(other.gameObject.tag == "Player")
			isTeleporting = false;
	}
	
	void teleport() {
		if(isTeleporting) {
			if (other.gameObject.tag == "Player") {
				other.gameObject.GetComponent<PlayerController>().PlaySound(0);
				Vector3 targetPosition = (target.transform.position);
				print (target.transform.position.y);

				other.gameObject.transform.position = targetPosition;
			}
		}
	}
}
