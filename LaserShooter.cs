using UnityEngine;
using System.Collections;

public class LaserShooter : MonoBehaviour {
	public GameObject laserBullet;
	public Transform laserBulletSpawn;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Invoke ("Shoot", 2);
	}

	void Shoot() {
		Instantiate (laserBullet, laserBulletSpawn.transform.position, laserBulletSpawn.transform.rotation);
	}

}
