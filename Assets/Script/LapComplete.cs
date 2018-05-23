using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour {

	public GameObject lap,half;
	public GameObject minD,secD,milliD;
	public GameObject lapBox;

	public GameObject LapCounter;
	public int LapsDone;

	public float RawTime;

	void OnTriggerEnter(){
		LapsDone += 1;

		RawTime = PlayerPrefs.GetFloat("RawTime");
		if (TimeManager.RawTime <= RawTime){
			if (TimeManager.sec <= 9){
				secD.GetComponent<Text>().text = "0" + TimeManager.sec + ".";
			}else {
				secD.GetComponent<Text>().text = "" + TimeManager.sec + ".";
			}

			if (TimeManager.min <= 9){
				minD.GetComponent<Text>().text = "0" + TimeManager.min + ":";
			}else {
				minD.GetComponent<Text>().text = "" + TimeManager.min + ":";
			}

			milliD.GetComponent<Text>().text = "" + TimeManager.mili;
		}

		

		PlayerPrefs.SetInt("MinSave", TimeManager.min);
		PlayerPrefs.SetInt("SecSave", TimeManager.sec);
		PlayerPrefs.SetFloat("MilliSave", TimeManager.mili);
		PlayerPrefs.SetFloat("RawTime" , TimeManager.RawTime);

		TimeManager.min = 0;
		TimeManager.sec = 0;
		TimeManager.mili = 0;
		TimeManager.RawTime = 0;
		LapCounter.GetComponent<Text>().text = "" + LapsDone;


		half.SetActive(true);
		lap.SetActive(false);
	}
}
