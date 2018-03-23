using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrigger : MonoBehaviour {

	public GameObject lapcomplete;
	public GameObject halfcomplete;

	void OnTriggerEnter(){
		lapcomplete.SetActive(true);
		halfcomplete.SetActive(false);
	}
}
