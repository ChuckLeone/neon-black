using UnityEngine;
using System.Collections;
using VRStandardAssets.Utils;

//namespace VRStandardAssets.Examples {

	public class ballActions : MonoBehaviour {

		[SerializeField] public GameObject player;
		[SerializeField] public GameObject ballObject;
		[SerializeField] public GameObject shield;
		[SerializeField] public GameObject deActivate;
		[SerializeField] public AudioClip activateSound;
		[SerializeField] public GameObject activateWarp;
		[SerializeField] public AudioClip hitSound;
		[SerializeField] public AudioSource source;
		[SerializeField] public Camera m_camera;
		[SerializeField] private Material m_NormalMaterial;                
		[SerializeField] private Material m_OverMaterial;                  
		[SerializeField] private Material m_ClickedMaterial;               
		[SerializeField] private Material m_DoubleClickedMaterial;         
		[SerializeField] private VRInteractiveItem m_InteractiveItem;
		[SerializeField] private Renderer m_Renderer;
		[SerializeField] public GameObject warpField;

		public gameLoop reset;
		public warpPlane warpNow;
		public gameLoop updateScoreP;
		public gameLoop updateScoreCPU;
		public block activateBlock;


		void Start () {
			source = GetComponent<AudioSource>();
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
			//Invoke("forceBall", 0);
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
			//shield.SetActive (true);
			//Invoke("forceBall", 0);
		}

		// Handle the up event
		private void HandleUp () {
			//Invoke("grabBall", 0);
			//shield.SetActive (false);
		}

		//Handle the down event 
		private void HandleDown () {
			//Invoke("grabBall", 0);

		}

		//ball collision/scoring
		void OnTriggerEnter (Collider other)
	{    
//			if (other.tag == "Player")	
//			{
//				Invoke ("grabBall", 0);
//			}
			if (other.tag == "ScorePlayer")	
			{
				Invoke ("warpLaunch", 0);
				source.PlayOneShot(activateSound, 0.7f);
				updateScoreP.updatePlayerScore ();
				reset.resetBall();

			}
			if (other.tag == "ScoreCPU")	
			{
				
				source.PlayOneShot(activateSound, 0.7f);
				updateScoreCPU.updateCpuScore ();
				reset.resetBall(); 
			}
			if (other.tag == "Block")	
			{
				//change material color
				activateBlock.ActivateThis();

				//add multiplier/points
			}
			if (other.tag == "Bounds")	
			{
				//reset.resetBall();
				Destroy(gameObject);
			}
//			if (other.tag == "Plane")	
//			{
//				deActivate.SetActive (false);
//			}
		}

		// grab the ball
		void grabBall () {

			// establish the front position of the player
			//Vector3 distance = new Vector3(0, 2, 5);
			//var playerFront = player.transform.position + distance;
			Vector3 distance = new Vector3(0, 2, 5);


			// get the player's rotation
			float yRotation = 5.0F;
			yRotation += Input.GetAxis("Horizontal");
			transform.eulerAngles = new Vector3(10, yRotation, 0);

			var playerFront = player.transform.position + distance;

			// calc the angle to place the ball

			// make player the parent of the ball
			ballObject.transform.position = playerFront;

			ballObject.transform.parent = player.transform;

//			Debug.Log ("grabbing ball...");

		}
			

		// apply force to ball
		public void forceBall() {
			source.PlayOneShot(hitSound, 0.8f);
//			Debug.Log ("applying force to ball");
			Vector3 dir = new Vector3(0, 0, 10);
			dir.Normalize ();
			this.ballObject.GetComponent<Rigidbody>().AddForce (dir * 10000);
		}


		void warpLaunch() {	
			warpNow.Start ();
		}
			
//	}
}
	