#pragma strict

var objTrigger: GameObject; 
var objToActivate: GameObject;

function OnTriggerEnter(collisionInfo : Collider){

	  if(collisionInfo.gameObject == objTrigger){

			//destroy 3D trigger, we don't need it anymore
			Destroy(collisionInfo.gameObject);
			
			//activate GUI object
			objToActivate.SetActive(true);
	}
}