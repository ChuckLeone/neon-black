#pragma strict


var shootSound: AudioClip;
var explosion: GameObject;
var scoreUI: UI.Text;

private var score: int = 0;

function Update(){
	var hit: RaycastHit;
	if (Input.GetButtonUp("Fire1")){
		//print("Firing");
			if(shootSound!=null){
				GetComponent.<AudioSource>().PlayOneShot(shootSound);
			}
			
			
		
			if(Physics.Raycast (Camera.main.transform.position, Camera.main.transform.forward, hit, 1000)){
				//print(hit.collider.gameObject.name);
				if(hit!=null){
					if(hit.collider.gameObject.tag == "enemy"){
						Instantiate(explosion, hit.collider.gameObject.transform.position, Quaternion.identity);
						Destroy(hit.collider.gameObject);
						score += 10;
						scoreUI.text = "Score: "+score;
					
					}
				}
			}
	}
}
