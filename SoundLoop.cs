using UnityEngine;
using System.Collections;

public class SoundLoop : MonoBehaviour {
	public static bool isDead;
	private static SoundLoop instance = null;
	private int deaths;
	public static SoundLoop Instance {
		get {
			return instance;
		}
	}

	void Update() {
		isDead = PlayerController.isDead;
		if(isDead) {
			++deaths;
			isDead = false;
			PlayerController.isDead = false;
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
	void OnGUI() {
		//GUI.Label(new Rect (10, 10, 100, 20), "Deaths: " + deaths);
		string displayString = "Deaths: " + deaths;
		GUI.Box(new Rect(20,20,200,40), "<color=red><size=30>"+displayString+"</size></color>");
	}
 }
