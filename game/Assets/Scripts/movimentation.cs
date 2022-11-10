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

        if( Input.GetButton("Horizontal") ){
            transform.Translate( Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0, 0);
        }

        if( Input.GetButton("Vertical") ){
            transform.Translate( 0, Input.GetAxis("Vertical") * Time.deltaTime * speed, 0);
            if( Input.GetAxis("Vertical") < 0 ){
                animator.SetBool("isWalkingFront", true);
            }
        }

    }
}
