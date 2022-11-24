using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ronda_horizont : MonoBehaviour
{

    public Animator animator;

    int speed = 5;
    float tempo = 0.0f, tempo2 = 0.0f;

    void Start(){

        animator = GetComponent<Animator>();
        animator.SetBool("isWalkingLateral", true);
        gameObject.GetComponent<SpriteRenderer>().flipX = true;

    }

    bool turn = true;

    // get value of transform.localScale.x

    // scale_x = transform.localScale.x;
    // scale_m_x = transform.localScale.x * (-1);

    void Update(){

        if(tempo <= 10.0f){

            if( turn ){

                if( transform.localScale.x < 0 ){

                    transform.localScale = new Vector3( transform.localScale.x * (-1), transform.localScale.y, transform.localScale.z );

                }

                turn = false;
                transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, 1f);
                // transform.localScale.x *= -1;

            }

            tempo += Time.deltaTime;
            transform.Translate( -(Time.deltaTime * speed), 0, 0);
            tempo2 = 0.0f;
        }
        else if(tempo2 <= 10.0f){

            if( !turn ){

                turn = true;
                
                if( transform.localScale.x > 0 ){

                    transform.localScale = new Vector3( transform.localScale.x * (-1), transform.localScale.y, transform.localScale.z );

                }

            }

            tempo2 += Time.deltaTime;
            transform.Translate( Time.deltaTime * speed, 0, 0);
        }
        else
            tempo = 0.0f;   
    }
}