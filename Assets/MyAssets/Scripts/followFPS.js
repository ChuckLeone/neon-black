//attach this script to the object that will follow FPC
//this script working conjunction with SmoothLookAt script that you should also apply to the object
//and Constant Force component that should be applied to the object
//The object needs a sphere collider and it has to be a rigidbody with Freeze Rotation turned on

//object to be followed
var targetObject: Transform;
//var targetObject;
//distance that will trigger following action
var distanceTrigger: float;


function Update () {
	//targetObject = new Rigidbody();
	//targetObject = gameObject.tag == "Enemy";
	if (targetObject) {
		var dist = Vector3.Distance(targetObject.position, transform.position);
		
		//if distance is less than what is specified then do something
		if(dist<distanceTrigger){
			//print("attack");
			//GetComponent("LookatTarget").enabled = true;
			//GetComponent(ConstantForce).enabled = true;
			
		}else{
			//print("stop attack");
			//GetComponent("LookatTarget").enabled = false;
			//GetComponent(ConstantForce).enabled = false;
		}

	}

}