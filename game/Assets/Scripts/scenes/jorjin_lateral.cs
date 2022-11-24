using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jorjin_lateral : MonoBehaviour
{

    int speed = 3;
    float tempo = 0.0f, tempo2 = 0.0f;
    float mytime = 10.0f;

    bool turn = true;

    void Update(){

        if(tempo2 <= mytime){

            if( turn ){

                if( transform.localScale.x < 0 ){

                    transform.localScale = new Vector3( transform.localScale.x * (-1), transform.localScale.y, transform.localScale.z );

                }

                turn = false;
                transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, 1f);

            }

            tempo2 += Time.deltaTime;
            transform.Translate( Time.deltaTime * speed, 0, 0);
            tempo = 0.0f;
        }
        else if(tempo <= mytime){

            if( !turn ){

                turn = true;
                
                if( transform.localScale.x > 0 ){

                    transform.localScale = new Vector3( transform.localScale.x * (-1), transform.localScale.y, transform.localScale.z );

                }

            }

            tempo += Time.deltaTime;
            transform.Translate( -(Time.deltaTime * speed), 0, 0);
        }
        else
            tempo2 = 0.0f;   
    }
}