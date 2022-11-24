using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Interaction_steal : MonoBehaviour, ICollectible
{
    public static event HandleCardCollected OnCardStolen;
    public delegate void HandleCardCollected(ItemData itemData);
    public ItemData cardData;
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
            OnCardStolen?.Invoke(cardData);
            GetComponent<CircleCollider2D>().enabled = false;
            dentro = false;
        }
    }

    public void Collect(){}
}
