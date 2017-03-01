using UnityEngine;
using System.Collections;

public class levelLoader1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter (Collider other)
	{    
		// if tag is start
		if (other.tag == "act1")	
		{
			Application.LoadLevel ("act1"); 
		}
		if (other.tag == "act2")	
		{
			Application.LoadLevel ("act2"); 
		}
		if (other.tag == "act3")	
		{
			Application.LoadLevel ("act2");
		}
		if (other.tag == "Main")	
		{
			Application.LoadLevel ("main"); 
		}
	}
}