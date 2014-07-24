using UnityEngine;
using System.Collections;

public class SoundLoop : MonoBehaviour {
	private static SoundLoop instance = null;
	public static SoundLoop Instance {
		get {
			return instance;
		}
	}
	void Awake() {
		if(instance != null && instance != this) {
			Destroy(this.gameObject);
			return;
		} else {
			instance = this;
		}
		DontDestroyOnLoad (this.gameObject);
	}
 }
