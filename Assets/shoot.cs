using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {

	[SerializeField] private AudioClip shootSound;
	[SerializeField] public AudioSource source;
	[SerializeField] public GameObject lazerPulseLight;
	[SerializeField] public GameObject explosion;
	[SerializeField] public float speed;
	[SerializeField] public Camera camera;

	public Rigidbody pulse;
	public gameLoop score;

	RaycastHit hit;

	void Start () {
		source = GetComponent<AudioSource>();
		RaycastHit hit = new RaycastHit();
	}

	void firePulse() {


	}
	public void Update() {

		if (Input.GetButtonDown ("Fire1")) {
			lazerPulseLight.SetActive (true);

			if (shootSound != null) {
				GetComponent<AudioSource> ().PlayOneShot (shootSound);
			}

			if (Physics.Raycast (Camera.main.transform.position, Camera.main.transform.forward, out hit, 1000)) {

				Rigidbody newPulse = new Rigidbody ();

				newPulse = (Rigidbody)Instantiate (pulse, transform.position, transform.rotation);
				newPulse.GetComponent<Rigidbody> ().velocity = transform.TransformDirection (Vector3.forward * speed);

				//
				if(hit.collider != null){
					if(hit.collider.gameObject.tag == "Enemy"){
						GameObject explosionClone = new GameObject();
						explosionClone = (GameObject)Instantiate(explosion, hit.collider.gameObject.transform.position, Quaternion.identity);
						Destroy(hit.collider.gameObject);

						score.updatePlayerScore();
						//scoreUI.text = "Score: "+score;

					}
				}
				//
			}

		}

		if(Input.GetButtonUp ("Fire1")){
			lazerPulseLight.SetActive (false);
		}
	}
}