using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falha_camera : MonoBehaviour
{
    private GameObject myobject;
    public float timeElapsed = 0;
    public float delay = 3.0f;
    bool blink = true;

    void Start () {
        myobject = GameObject.Find("camera_door_2").gameObject;
    }

    void Update () {        
        timeElapsed += Time.deltaTime;

        if(timeElapsed >= delay && blink == true){
            timeElapsed = 0;
            blink = false;
            transform.GetChild(0).gameObject.SetActive(false);
        }
        else if(timeElapsed >= delay && blink == false){
            timeElapsed = 0;
            blink = true;
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}