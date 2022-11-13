using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentation : MonoBehaviour
{
    
    public Animator animator;

    int speed = 10;

    void Start()
    {

        animator = GetComponent<Animator>();

    }

    void Update()
    {

        animator.SetBool("isWalkingFront", false);
        animator.SetBool("isWalkingLateral", false);
        animator.SetBool("isWalkingBack", false);
        gameObject.GetComponent<SpriteRenderer>().flipX = false;

        if( Input.GetButton("Horizontal") ){

            Vector3 moviment = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);

            // transform.Translate( Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0, 0);
            transform.position += moviment * Time.deltaTime * speed;
            animator.SetBool("isWalkingLateral", true);

            if( Input.GetAxis("Horizontal") < 0 ){

                if( Input.GetButton("Vertical") ){
                    gameObject.GetComponent<SpriteRenderer>().flipX = false;
                }else{
                    gameObject.GetComponent<SpriteRenderer>().flipX = true;
                }
                
            }
        }

        if( Input.GetButton("Vertical") ){

            transform.Translate( 0, Input.GetAxis("Vertical") * Time.deltaTime * speed, 0);

            if( Input.GetAxis("Vertical") < 0 ){
                animator.SetBool("isWalkingFront", true);
            }else{
                animator.SetBool("isWalkingBack", true);
            }
            
        }

    }
}
