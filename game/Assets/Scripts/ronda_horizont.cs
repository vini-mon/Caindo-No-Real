using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ronda_horizont : MonoBehaviour
{

    public Animator animator;

    int speed = 3;
    float tempo = 0.0f, tempo2 = 0.0f;

    void Start(){

        animator = GetComponent<Animator>();
        animator.SetBool("isWalkingLateral", true);
        gameObject.GetComponent<SpriteRenderer>().flipX = true;

    }

    bool turn = true;

    void Update(){

        if(tempo <= 5.0f){

            if( turn ){

                turn = false;
                transform.localScale = new Vector3(0.002f, 0.002f, 1f);

            }

            tempo += Time.deltaTime;
            transform.Translate( -(Time.deltaTime * speed), 0, 0);
            tempo2 = 0.0f;
        }
        else if(tempo2 <= 5.0f){

            if( !turn ){

                turn = true;
                transform.localScale = new Vector3(-0.002f, 0.002f, 1f);

            }

            tempo2 += Time.deltaTime;
            transform.Translate( Time.deltaTime * speed, 0, 0);
        }
        else
            tempo = 0.0f;   
    }
}