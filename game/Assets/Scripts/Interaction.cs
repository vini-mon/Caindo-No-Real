using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    bool dentro = false;
    
    private void Awake(){
        transform.GetChild(0).gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other){
        transform.GetChild(0).gameObject.SetActive(true);
        dentro = true;
    }

    private void OnTriggerExit2D(Collider2D other){
        transform.GetChild(0).gameObject.SetActive(false);
        dentro = false;
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.E) && (dentro == true)){
            gameObject.SetActive(false);
        }
    }

}