using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlocker : MonoBehaviour {

	//public static bool[] CarUnlocker = {false, false, false, false, false, false, false, false, false, false, false};
	public GameObject[] ListButton;
	public Text Indicator;
	private int checking, myMoney, moneyReq;

	void Start(){
		if (PlayerPrefs.GetInt("Car3") == 1){
			ListButton[0].SetActive(false);
		}
		if (PlayerPrefs.GetInt("Car4") == 1){
			ListButton[1].SetActive(false);
		}
		if (PlayerPrefs.GetInt("Car5") == 1){
			ListButton[2].SetActive(false);
		}
		if (PlayerPrefs.GetInt("Car6") == 1){
			ListButton[3].SetActive(false);
		}
		if (PlayerPrefs.GetInt("Car7") == 1){
			ListButton[4].SetActive(false);
		}
		if (PlayerPrefs.GetInt("Car8") == 1){
			ListButton[5].SetActive(false);
		}
		if (PlayerPrefs.GetInt("Car9") == 1){
			ListButton[6].SetActive(false);
		}
		if (PlayerPrefs.GetInt("Car10") == 1){
			ListButton[7].SetActive(false);
		}
		if (PlayerPrefs.GetInt("Car11") == 1){
			ListButton[8].SetActive(false);
		}
		if (PlayerPrefs.GetInt("Car12") == 1){
			ListButton[9].SetActive(false);
		}
		if (PlayerPrefs.GetInt("Car13") == 1){
			ListButton[10].SetActive(false);
		}
	}

	public void Car3(){checking = 1;moneyReq = 200;Indicator.text = "Smudge Car";}
	public void Car4(){checking = 2;moneyReq = 500;Indicator.text = "Grafitti Car";}
	public void Car5(){checking = 3;moneyReq = 1000;Indicator.text = "Pain";}
	public void Car6(){checking = 4;moneyReq = 2000;Indicator.text = "Worldwide";}
	public void Car7(){checking = 5;moneyReq = 3500;Indicator.text = "Patrick";}
	public void Car8(){checking = 6;moneyReq = 5000;Indicator.text = "Roselia";}
	public void Car9(){checking = 7;moneyReq = 7000;Indicator.text = "Wall";}
	public void Car10(){checking = 8;moneyReq = 9500;Indicator.text = "Speedwagon";}
	public void Car11(){checking = 9;moneyReq = 12000;Indicator.text = "Palette Car";}
	public void Car12(){checking = 10;moneyReq = 16000;Indicator.text = "Astro";}
	public void Car13(){checking = 11;moneyReq = 25000;Indicator.text = "Ignite";}

	public void acceptBuyCar(){
		myMoney = GlobalCash.TotalCash;
		if (myMoney >= moneyReq){
			switch(checking){
				case 1: 
					PlayerPrefs.SetInt("Car3", 1);
					ListButton[0].SetActive(false);
					Indicator.text = "Unlocked!";
					myMoney -= moneyReq;
					GlobalCash.TotalCash = myMoney;
					break;
				case 2: 
					PlayerPrefs.SetInt("Car4", 1);
					ListButton[1].SetActive(false);
					Indicator.text = "Unlocked!";
					myMoney -= moneyReq;
					GlobalCash.TotalCash = myMoney;
					break;
				case 3:
					PlayerPrefs.SetInt("Car5", 1);
					ListButton[2].SetActive(false);
					Indicator.text = "Unlocked!";
					myMoney -= moneyReq;
					GlobalCash.TotalCash = myMoney;
					break;
				case 4:
					PlayerPrefs.SetInt("Car6", 1);
					ListButton[3].SetActive(false);
					Indicator.text = "Unlocked!";
					myMoney -= moneyReq;
					GlobalCash.TotalCash = myMoney;
					break;
				case 5:
					PlayerPrefs.SetInt("Car7", 1);
					ListButton[4].SetActive(false);
					Indicator.text = "Unlocked!";
					myMoney -= moneyReq;
					GlobalCash.TotalCash = myMoney;
					break;
				case 6:
					PlayerPrefs.SetInt("Car8", 1);
					ListButton[5].SetActive(false);
					Indicator.text = "Unlocked!";
					myMoney -= moneyReq;
					GlobalCash.TotalCash = myMoney;
					break;
				case 7:
					PlayerPrefs.SetInt("Car9", 1);
					ListButton[6].SetActive(false);
					Indicator.text = "Unlocked!";
					myMoney -= moneyReq;
					GlobalCash.TotalCash = myMoney;
					break;
				case 8:
					PlayerPrefs.SetInt("Car10", 1);
					ListButton[7].SetActive(false);
					Indicator.text = "Unlocked!";
					myMoney -= moneyReq;
					GlobalCash.TotalCash = myMoney;
					break;
				case 9:
					PlayerPrefs.SetInt("Car11", 1);
					ListButton[8].SetActive(false);
					Indicator.text = "Unlocked!";
					myMoney -= moneyReq;
					GlobalCash.TotalCash = myMoney;
					break;
				case 10:
					PlayerPrefs.SetInt("Car12", 1);
					ListButton[9].SetActive(false);
					Indicator.text = "Unlocked!";
					myMoney -= moneyReq;
					GlobalCash.TotalCash = myMoney;
					break;
				case 11:
					PlayerPrefs.SetInt("Car13", 1);
					ListButton[10].SetActive(false);
					Indicator.text = "Unlocked!";
					myMoney -= moneyReq;
					GlobalCash.TotalCash = myMoney;
					break;
			}
			
		}else {
			Indicator.text = "Not enough money";
		}
	}
}
