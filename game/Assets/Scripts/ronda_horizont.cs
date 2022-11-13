using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ronda_horizont : MonoBehaviour
{
    int speed = 3;
    float tempo = 0.0f, tempo2 = 0.0f;

    void Update(){
        if(tempo <= 5.0f){
            tempo += Time.deltaTime;
            transform.Translate( -(Time.deltaTime * speed), 0, 0);
            tempo2 = 0.0f;
        }
        else if(tempo2 <= 5.0f){
            tempo2 += Time.deltaTime;
            transform.Translate( Time.deltaTime * speed, 0, 0);
        }
        else
            tempo = 0.0f;   
    }
}