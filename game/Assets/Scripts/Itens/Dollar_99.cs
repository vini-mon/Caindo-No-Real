using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Dollar_99 : MonoBehaviour, ICollectible
{
    public static event Action OnMoneyCollected;
    public AudioSource audioCoin;
    float timeToDestroy = 1.0f;
    bool destroy = false;
    
    public void Collect(){
        
        audioCoin.Play();
        OnMoneyCollected?.Invoke();
        GetComponent<BoxCollider2D>().enabled = false;
        gameObject.GetComponent<Renderer>().enabled = false;

        destroy = true;

    }

    void Update(){

        if(destroy){

            if( timeToDestroy >= 0.0f ){

                timeToDestroy -= Time.deltaTime;

            }else{

                Destroy(gameObject);

            }

        }

    }


}
