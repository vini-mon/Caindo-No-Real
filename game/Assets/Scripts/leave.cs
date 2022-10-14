using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leave : MonoBehaviour
{
    public void Quit() {
        #if UNITY_STANDALONE
            Application.Quit();
        #endif
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

    private void OnTriggerEnter2D(Collider2D other){
        Quit();
    }
}
