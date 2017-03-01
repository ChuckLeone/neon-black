using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	public GameObject MenuScreen;
	public GameObject RigidBodyFPSController;


	// Use this for initialization
	void Start () {
		//RigidBodyFPSController.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void NewGame () {
		Application.LoadLevel("vr-canyan");

	}

	public void Quit () {
		Application.Quit ();
	}
}
