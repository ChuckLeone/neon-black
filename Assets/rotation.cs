using UnityEngine;
using System.Collections;

public class rotation : MonoBehaviour {
	
	//[SerializeField] private transform speed;
 	// Use this for initialization
	private float speed = 3000.0f;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.left * Time.deltaTime * speed);
		transform.Rotate (Vector3.up * Time.deltaTime * speed);

	}
}
