using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour{
    public GameObject[] CarBody;
    public int CarImport;
    
    void Start(){
        CarImport = GlobalCar.CarType;
        switch (CarImport){
            case 0:
                CarBody[0].SetActive(true);
                break;
            case 1:
                CarBody[1].SetActive(true);
                break;
            case 2:
                CarBody[2].SetActive(true);
                break;
            case 3:
                CarBody[3].SetActive(true);
                break;
            case 4:
                CarBody[4].SetActive(true);
                break;
            case 5:
                CarBody[5].SetActive(true);
                break;
            case 6:
                CarBody[6].SetActive(true);
                break;
            case 7:
                CarBody[7].SetActive(true);
                break;
            case 8:
                CarBody[8].SetActive(true);
                break;
            case 9:
                CarBody[9].SetActive(true);
                break;
            case 10:
                CarBody[10].SetActive(true);
                break;
            case 11:
                CarBody[11].SetActive(true);
                break;
            case 12:
                CarBody[12].SetActive(true);
                break;
            case 13:
                CarBody[13].SetActive(true);
                break;
        }
    }
}