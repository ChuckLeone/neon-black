using UnityEngine;
using System.Collections;

public class ballInteractions : MonoBehaviour {

	[SerializeField] public GameObject objToGrab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		objToGrab.transform.parent = transform;
	}
}
