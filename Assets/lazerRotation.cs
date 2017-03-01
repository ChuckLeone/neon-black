using UnityEngine;
using System.Collections;

public class lazerRotation : MonoBehaviour {
	
	[SerializeField] public float speed;
	[SerializeField] public float speed2;

	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up * Time.deltaTime * (speed + speed2));
		//transform.Rotate (Vector3.down * Time.deltaTime * speed2);

	}
}
