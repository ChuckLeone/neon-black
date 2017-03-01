using UnityEngine;
using System.Collections;
using VRStandardAssets.Utils;

public class targetActions : MonoBehaviour {

//	[SerializeField] public GameObject player;
//	[SerializeField] public AudioClip activateSound;
//	[SerializeField] public GameObject activateWarp;
//	[SerializeField] public AudioClip hitSound;
//	[SerializeField] public AudioSource source;
	[SerializeField] public Camera m_camera;
	[SerializeField] private Material m_NormalMaterial;                
	[SerializeField] private Material m_OverMaterial;                  
	[SerializeField] private Material m_ClickedMaterial;               
	[SerializeField] private Material m_DoubleClickedMaterial;         
	[SerializeField] private VRInteractiveItem m_InteractiveItem;
	[SerializeField] private Renderer m_Renderer;
//	[SerializeField] public GameObject warpField;

	void Start () {
		//source = GetComponent<AudioSource>();
	}

	private void Awake ()
	{
		m_Renderer.material = m_NormalMaterial;
	}

	private void OnEnable()
	{
		m_InteractiveItem.OnOver += HandleOver;
		m_InteractiveItem.OnOut += HandleOut;
		m_InteractiveItem.OnClick += HandleClick;
		m_InteractiveItem.OnDoubleClick += HandleDoubleClick;
		m_InteractiveItem.OnDown += HandleDown;
		m_InteractiveItem.OnUp += HandleUp;
	}

	private void OnDisable()
	{
		m_InteractiveItem.OnOver -= HandleOver;
		m_InteractiveItem.OnOut -= HandleOut;
		m_InteractiveItem.OnClick -= HandleClick;
		m_InteractiveItem.OnDoubleClick -= HandleDoubleClick;
	}

	//Handle the Over event
	private void HandleOver()
	{
		m_Renderer.material = m_OverMaterial;
	}


	//Handle the Out event
	private void HandleOut()
	{

		m_Renderer.material = m_NormalMaterial;
	}

	//Handle the Click event
	private void HandleClick()
	{
		m_Renderer.material = m_ClickedMaterial;

	}

	//Handle the DoubleClick event
	private void HandleDoubleClick()
	{
		m_Renderer.material = m_DoubleClickedMaterial;
	}

	// Handle the up event
	private void HandleUp () {

	}

	//Handle the down event 
	private void HandleDown () {}


}
