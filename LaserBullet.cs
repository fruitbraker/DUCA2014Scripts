using UnityEngine;
using System.Collections;

public class LaserBullet : MonoBehaviour {
	public float laserBulletSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.up * Time.deltaTime * laserBulletSpeed);

	}
}
