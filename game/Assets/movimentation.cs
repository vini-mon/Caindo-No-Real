using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentation : MonoBehaviour
{
    int speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
        

    }

    // Update is called once per frame
    void Update()
    {

        if( Input.GetButton("Horizontal") ){
            transform.Translate( Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0, 0);
        }

        if( Input.GetButton("Vertical") ){
            transform.Translate( 0, Input.GetAxis("Vertical") * Time.deltaTime * speed, 0);
        }

    }
}
