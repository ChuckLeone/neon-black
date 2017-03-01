using UnityEngine;
using System.Collections;

public class KeyChecker : MonoBehaviour {

	public AudioClip pickupSound;
	AudioSource source;

	public GameObject hiddenDoor;
	public GameObject key;
	public GameObject levelExitMelody;
	

	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other)
	{    
		// if tag is key
		if (other.tag == "RedKey")	
		{
			hiddenDoor.SetActive (false);
			levelExitMelody.SetActive (true);
			key.SetActive (false);
			source.PlayOneShot(pickupSound, 0.7f);
		}
	}
}
