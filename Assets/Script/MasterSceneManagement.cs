using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MasterSceneManagement : MonoBehaviour {

	public void GoToMainMenu(){
		SceneManager.LoadScene (0);
	}

	public void GoToTrackSelect(){
		SceneManager.LoadScene(1);
	}

	public void GoToTrack1(){
		SceneManager.LoadScene(2);
	}
}
