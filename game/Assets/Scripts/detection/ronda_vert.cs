using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ronda_vert : MonoBehaviour
{
    
    public Animator animator;
    private GameObject myobject;

    int speed = 3;
    float tempo = 0.0f, tempo2 = 0.0f;

    void Start(){

        animator = GetComponent<Animator>();

    }

    bool turn = false;

    void Update(){

        if(tempo <= 5.0f){

            animator.SetBool("isWalkingBack", false);
            animator.SetBool("isWalkingFront", true);

            if( turn ){

                turn = false;
                transform.localScale *= -1;
                gameObject.GetComponent<SpriteRenderer>().flipY = false;

            }
            
            tempo += Time.deltaTime;
            transform.Translate( 0, -(Time.deltaTime * speed), 0);
            tempo2 = 0.0f;
        }
        else if(tempo2 <= 5.0f){

            animator.SetBool("isWalkingFront", false);
            animator.SetBool("isWalkingBack", true);

            if( !turn ){

                turn = true;
                transform.localScale *= -1;
                gameObject.GetComponent<SpriteRenderer>().flipY = true;

            }

            tempo2 += Time.deltaTime;
            transform.Translate( 0, Time.deltaTime * speed, 0);
        }
        else{
            tempo = 0.0f;
        }
    }
}
