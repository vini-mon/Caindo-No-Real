using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class VendingMachine : MonoBehaviour
{
    bool dentro = false;
    
    private void Awake(){
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(false);
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
            transform.GetChild(1).gameObject.SetActive(true);
            GetComponent<CircleCollider2D>().enabled = false;
            dentro = false;
        }
    }

}
