using UnityEngine;
using System.Collections;

public class LaserShooter : MonoBehaviour {
	public GameObject laserBullet;
	public Transform laserBulletSpawn;
	public float bulletDistance;
	public bool isRight;
	public float lengthCap;

	// Use this for initialization
	void Start () {
		lengthCap += laserBullet.transform.position.x;
	}

	// Update is called once per frame
	void Update () {
		if(laserBullet.transform.position.x > lengthCap && isRight) {
			laserBullet.transform.position = laserBullet.transform.position;
		}
		if(laserBullet.transform.position.x < lengthCap && !isRight) {
			laserBullet.transform.position = laserBullet.transform.position;
		}
	}
}
	