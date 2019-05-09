using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class halfpointTrigger : MonoBehaviour {
	public GameObject zeTrigger;
	public GameObject LapCompleteTrigger;

	void OnTriggerEnter(){
		LapCompleteTrigger.SetActive (true);
		zeTrigger.SetActive (false);
	}

}
