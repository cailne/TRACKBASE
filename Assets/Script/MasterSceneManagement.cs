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

	public void GoToCarSelect(){
		SceneManager.LoadScene(2);
	}

	public void GoToShop(){
		SceneManager.LoadScene(3);
	}

	public void GoToTrack1(){
		SceneManager.LoadScene(4);
	}
}
