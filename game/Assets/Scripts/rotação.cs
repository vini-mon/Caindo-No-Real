using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotação : MonoBehaviour
{

    private GameObject myobject;
    public float timeElapsed =0;
    public float delay = 2.0f;
    float OO = 60.0f;
    bool rotate = true;

    void Start () {
        myobject = GameObject.Find ("camera").gameObject;
    }

    void Update () {        
        timeElapsed += Time.deltaTime;
        Debug.Log (timeElapsed);

        if(timeElapsed >= delay && rotate == true){
            timeElapsed = 0;
            rotate = false;

            myobject.transform.Rotate (0.0f, 0.0f, OO);
        }
        else if(timeElapsed >= delay && rotate == false){
            timeElapsed = 0;
            rotate = true;
            myobject.transform.Rotate (0.0f,0.0f, -OO);
        }
    }
}
