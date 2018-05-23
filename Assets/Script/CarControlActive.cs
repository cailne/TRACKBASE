using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarControlActive : MonoBehaviour {

	public GameObject CarControl;
	public GameObject AICarControl;

	void Start(){
		CarControl.GetComponent<CarUserControl>().enabled = true;
		AICarControl.GetComponent<CarAIControl>().enabled = true;
	}
}
