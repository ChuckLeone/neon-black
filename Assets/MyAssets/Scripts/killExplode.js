#pragma strict

function Start () {
	killIt();
}

function killIt(){

	yield WaitForSeconds(3);
	Destroy(this.gameObject);

}