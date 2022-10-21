using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class porta : MonoBehaviour
{
    private GameObject myobject;
    bool dentro = false;
    bool fechada = true;
    
    private void Awake(){
        transform.GetChild(1).gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other){
        dentro = true;
    }

    private void OnTriggerExit2D(Collider2D other){
        dentro = false;
    }

    void Update(){
        // abrir porta
        if(Input.GetKeyDown(KeyCode.E) && (dentro == true) && (fechada == true)){
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(true);
            fechada = false;
        }
        // fechar porta
        else if(Input.GetKeyDown(KeyCode.E) && (dentro == true) && (fechada == false)){
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(false);
            fechada = true;
        }
    }
}
