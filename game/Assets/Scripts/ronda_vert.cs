using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ronda_vert : MonoBehaviour
{
    int speed = 3;
    float tempo = 0.0f, tempo2 = 0.0f;

    void Update(){
        if(tempo <= 3.0f){
            tempo += Time.deltaTime;
            transform.Translate( 0, -(Time.deltaTime * speed), 0);
            tempo2 = 0.0f;
        }
        else if(tempo2 <= 3.0f){
            tempo2 += Time.deltaTime;
            transform.Translate( 0, Time.deltaTime * speed, 0);
        }
        else
            tempo = 0.0f;   
    }
}
