using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour {

	public static int min;
	public static int sec;
	public static float mili;
	public static string miliDisplay;

	public GameObject minute,second,millisec;

	void Update(){
		mili += Time.deltaTime * 10;
		miliDisplay = mili.ToString("F0");
		millisec.GetComponent<Text>().text = "" + miliDisplay;

		if (mili >= 10){
			mili = 0;
			sec += 1;
		}

		if (sec <= 9){
			second.GetComponent<Text>().text = "0" + sec + ".";
		}else {
			second.GetComponent<Text>().text = "" + sec + ".";
		}

		if (sec >= 60){
			sec = 0;
			min += 1;
		}

		if (min <= 9){
			minute.GetComponent<Text>().text = "0" + min + ":";
		}else {
			minute.GetComponent<Text>().text = "" + min + ":";
		}
	}
}
