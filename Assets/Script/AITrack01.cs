using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AITrack01 : MonoBehaviour {
    public GameObject TheMarker, Mark01, Mark02, Mark03, Mark04, Mark05, Mark06;
    public int MarkTracker;

    void Update(){
        if (MarkTracker == 0){
            TheMarker.transform.position = Mark01.transform.position;
        }
        if (MarkTracker == 1){
            TheMarker.transform.position = Mark02.transform.position;
        }
        if (MarkTracker == 2){
            TheMarker.transform.position = Mark03.transform.position;
        }
        if (MarkTracker == 3){
            TheMarker.transform.position = Mark04.transform.position;
        }
        if (MarkTracker == 4){
            TheMarker.transform.position = Mark05.transform.position;
        }
        if (MarkTracker == 5){
            TheMarker.transform.position = Mark06.transform.position;
        }
    }

    IEnumerator OnTriggerEnter (Collider collision){
        if (collision.gameObject.tag == "AI01"){
            this.GetComponent<BoxCollider>().enabled = false;
            MarkTracker += 1;
            if (MarkTracker == 6)MarkTracker = 0;
            yield return new WaitForSeconds (1);
            this.GetComponent<BoxCollider>().enabled.true;
        }
    }

}