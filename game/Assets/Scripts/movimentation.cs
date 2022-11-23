using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentation : MonoBehaviour
{
    
    public Animator animator;
    public AudioSource audioWalking;

    public int speed = 10;
    float tempoFootSteps = 0.1f;

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

            if( tempoFootSteps > 0.0f ){

                tempoFootSteps -= Time.deltaTime;

            }else{

                audioWalking.Play();

                tempoFootSteps = 0.3f;

            }


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

            if( ! Input.GetButton("Horizontal") ){
                if( tempoFootSteps > 0.0f ){

                    tempoFootSteps -= Time.deltaTime;

                }else{

                    audioWalking.Play();

                    tempoFootSteps = 0.3f;

                }
            }

            if( Input.GetAxis("Vertical") < 0 ){
                animator.SetBool("isWalkingFront", true);
            }else{
                animator.SetBool("isWalkingBack", true);
            }
            
        }

    }
}
