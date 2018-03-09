using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StableCam : MonoBehaviour {

    public GameObject Car1;
    public float carX, carY, carZ;

    void Update(){
        carX = Car1.transform.eulerAngles.x;
        carY = Car1.transform.eulerAngles.y;
        carZ = Car1.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3 (carX-carX, carY, carZ-carZ);
    }
}