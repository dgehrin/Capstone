using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour {

	public GameObject LapCompleteTrig;
	public GameObject HalfLapTrig;

	public GameObject MinuteDisplay;
	public GameObject SecondDisplay;
	public GameObject MilliDisplay;

	public GameObject LapTimeBox;

	public GameObject LapCounter;
	public int LapsComplete;

	public float RawTime;

	public GameObject RaceFinish;


	void Update (){
		if (LapsComplete == 2) {
			RaceFinish.SetActive (true);
		}
	}

	void OnTriggerEnter () {
		LapsComplete += 1;
		RawTime = PlayerPrefs.GetFloat ("RawTime");
		if (laptime.RawTime <= RawTime) {

			if (laptime.SecondCount <= 9) {
				SecondDisplay.GetComponent<Text> ().text = "0" + laptime.SecondCount + ".";
			} else {
				SecondDisplay.GetComponent<Text> ().text = "" + laptime.SecondCount + ".";
			}

			if (laptime.MinuteCount <= 9) {
				MinuteDisplay.GetComponent<Text> ().text = "0" + laptime.MinuteCount + ".";
			} else {
				MinuteDisplay.GetComponent<Text> ().text = "" + laptime.MinuteCount + ".";
			}

			MilliDisplay.GetComponent<Text> ().text = "" + laptime.MilliCount;
		}
		PlayerPrefs.SetInt("MinSave",laptime.MinuteCount);
		PlayerPrefs.SetInt("SecSave",laptime.SecondCount);
		PlayerPrefs.SetFloat("MilliSave",laptime.MilliCount);
		PlayerPrefs.SetFloat ("RawTime", laptime.RawTime);

		laptime.MinuteCount = 0;
		laptime.SecondCount = 0;
		laptime.MilliCount = 0;
		laptime.RawTime = 0;

		LapCounter.GetComponent<Text> ().text = "" + LapsComplete;
		HalfLapTrig.SetActive (true);
		LapCompleteTrig.SetActive (false);
	}
}
