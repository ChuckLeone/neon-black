using UnityEngine;
using System.Collections;

public class explosion : MonoBehaviour {

	[SerializeField] private AudioClip explodeSound;
	[SerializeField] public AudioSource source;
	// Use this for initialization
	void Start () {
		GetComponent<AudioSource>().PlayOneShot(explodeSound);
		Debug.Log("destroy explosion object");
		Destroy(gameObject, 1.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
