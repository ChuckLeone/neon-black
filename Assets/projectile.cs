using UnityEngine;
using System.Collections;

public class projectile : MonoBehaviour {

	public GameObject explosion;

	//public ballActions hitBall;
	//RaycastHit hit;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, 1.5f);
		Debug.Log("destroy bullet object");
	}
//


	// Update is called once per frame
	void Update () {
//
//		if(GetComponent<Collider>().gameObject.tag == "Ball"){
//			//hitBall.forceBall ();
//			Instantiate(explosion, GetComponent<Collider>().gameObject.transform.position, Quaternion.identity);
//			Destroy (gameObject, 0);
//		}


//		if(GetComponent<Collider>().gameObject.tag == "Enemy"){
//			Instantiate(explosion, GetComponent<Collider>().gameObject.transform.position, Quaternion.identity);
//			Destroy (gameObject, 0);
//		}
//
//
//		if(GetComponent<Collider>().gameObject.tag == "Bounds"){
//			Instantiate(explosion, GetComponent<Collider>().gameObject.transform.position, Quaternion.identity);
//			Destroy (gameObject, 0);
//		}
	}



}
