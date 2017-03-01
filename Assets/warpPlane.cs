using UnityEngine;
using System.Collections;

public class warpPlane : MonoBehaviour {
	
	[SerializeField]private GameObject warpField;
	public float countdown = 0.3f;

	// Use this for initialization
	public void Start () {
		Update ();
	}

	public void resetTimer () {
		countdown = 3.0f;
	}

	void Update() {
		
		countdown -= Time.deltaTime;
		Debug.Log (countdown);

		if (countdown > 0.0f) {
			warpField.SetActive (true);
		}
		if (countdown <= 0.0f) {
			warpField.SetActive (false);
			resetTimer ();
		}
	}
		
}
