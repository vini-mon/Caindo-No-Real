using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class porta_password : MonoBehaviour
{
    private GameObject myobject;
    bool dentro = false;
    bool fechada = true;
    public bool contemID = false;

    private void OnEnable(){
        Password.OnPasswordCollected += liberar;
    }

    private void OnDisable(){
        Password.OnPasswordCollected -= liberar;
    }

    private void Awake(){
        transform.GetChild(1).gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other){
        dentro = true;
    }

    private void OnTriggerExit2D(Collider2D other){
        dentro = false;
    }

    private void liberar(ItemData itemData){
        if (itemData.ID == 4) contemID = true;
    }

    void Update(){
        // abrir porta
        if(Input.GetKeyDown(KeyCode.E) && (dentro == true) && (fechada == true)){
            if (contemID == true){
                transform.GetChild(0).gameObject.SetActive(false);
                transform.GetChild(1).gameObject.SetActive(true);
                fechada = false;
            }
        }
        // fechar porta
        else if(Input.GetKeyDown(KeyCode.E) && (dentro == true) && (fechada == false)){
            if (contemID == true){
                transform.GetChild(0).gameObject.SetActive(true);
                transform.GetChild(1).gameObject.SetActive(false);
                fechada = true;
            }
        }
    }
}
