using UnityEngine;
using System.Collections;

public class LaserBullet : MonoBehaviour {
	public float laserBulletSpeed;
	public bool isLeft;

	// Use this for initialization
	void Start () {
		if(isLeft)
			laserBulletSpeed *= -1;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.right * Time.deltaTime * laserBulletSpeed);
	}
}
