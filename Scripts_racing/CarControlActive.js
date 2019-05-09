var CarControl : GameObject;
var mrspeedy01 : GameObject;

function Start () {
	CarControl.GetComponent("CarController").enabled = true;
	mrspeedy01.GetComponent("CarAIControl").enabled = true;
}
