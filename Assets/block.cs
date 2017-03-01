using UnityEngine;
using System.Collections;

public class block : MonoBehaviour {

	[SerializeField] private Material m_NormalMaterial;
	[SerializeField] private Material m_ActiveMaterial;
	[SerializeField] private Renderer m_Renderer;

	private void Awake ()
	{
		m_Renderer.material = m_NormalMaterial;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Ball")	
		{
			//change material color
			Invoke("ActivateThis", 0);

			//add multiplier/points
		}
	}

	public void ActivateThis () {
		m_Renderer.material = m_ActiveMaterial;
	}
}
