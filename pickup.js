#pragma strict

function Start () {

}

function Update () {

}

function OnTriggerEnter (col : Collider):void{
	
	if (col.gameObject.tag == "Player"){
		Destroy(this.gameObject);
	}


}