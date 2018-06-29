using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCar : MonoBehaviour{
    public static int CarType;
    //public GameObject TrackWindow;
    public Slider speedDisplay;

    public GameObject[] ButtonList;

    void Start(){
        if (PlayerPrefs.GetInt("Car3") == 0){
			ButtonList[0].SetActive(false);
		}
		if (PlayerPrefs.GetInt("Car4") == 0){
			ButtonList[1].SetActive(false);
		}
		if (PlayerPrefs.GetInt("Car5") == 0){
			ButtonList[2].SetActive(false);
		}
		if (PlayerPrefs.GetInt("Car6") == 0){
			ButtonList[3].SetActive(false);
		}
		if (PlayerPrefs.GetInt("Car7") == 0){
			ButtonList[4].SetActive(false);
		}
		if (PlayerPrefs.GetInt("Car8") == 0){
			ButtonList[5].SetActive(false);
		}
		if (PlayerPrefs.GetInt("Car9") == 0){
			ButtonList[6].SetActive(false);
		}
		if (PlayerPrefs.GetInt("Car10") == 0){
			ButtonList[7].SetActive(false);
		}
		if (PlayerPrefs.GetInt("Car11") == 0){
			ButtonList[8].SetActive(false);
		}
		if (PlayerPrefs.GetInt("Car12") == 0){
			ButtonList[9].SetActive(false);
		}
		if (PlayerPrefs.GetInt("Car13") == 0){
			ButtonList[10].SetActive(false);
		}
    }
    
    public void RedCar(){
        CarType = 1;
        speedDisplay.value = 150;
    }

    public void BlueCar(){
        CarType = 2;
        speedDisplay.value = 150;
    }

    public void SmudgeCar(){if (PlayerPrefs.GetInt("Car3") == 1)CarType = 3;
    speedDisplay.value = 230;}
    public void GrafittiCar(){if (PlayerPrefs.GetInt("Car4") == 1)CarType = 4;
    speedDisplay.value = 300;}
    public void PainCar(){if (PlayerPrefs.GetInt("Car5") == 1)CarType = 5;
    speedDisplay.value = 345;}
    public void WorldwideCar(){if (PlayerPrefs.GetInt("Car6") == 1)CarType = 6;
    speedDisplay.value = 425;}
    public void PatrickCar(){if (PlayerPrefs.GetInt("Car7") == 1)CarType = 7;
    speedDisplay.value = 500;}
    public void RoseliaCar(){if (PlayerPrefs.GetInt("Car8") == 1)CarType = 8;
    speedDisplay.value = 575;}
    public void TembokCar(){if (PlayerPrefs.GetInt("Car9") == 1)CarType = 9;
    speedDisplay.value = 675;}
    public void SpeedwagonCar(){if (PlayerPrefs.GetInt("Car10") == 1)CarType = 10;
    speedDisplay.value = 775;}
    public void PaletteCar(){if (PlayerPrefs.GetInt("Car11") == 1)CarType = 11;
    speedDisplay.value = 850;}
    public void SakuraCar(){if (PlayerPrefs.GetInt("Car12") == 1)CarType = 12;
    speedDisplay.value = 925;}
    public void IgniteCar(){if (PlayerPrefs.GetInt("Car13") == 1)CarType = 13;
    speedDisplay.value = 1000;}

    public void DefaultCar(){
        CarType = 0;
        speedDisplay.value = 150;
    }


}