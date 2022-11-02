using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class detecção : MonoBehaviour
{
    Coroutine co;
    
    private void OnTriggerEnter2D(Collider2D other){
        co = StartCoroutine(DetectionTime());
    }
    private void OnTriggerExit2D(Collider2D other){
        StopCoroutine(co);
    }

    IEnumerator DetectionTime(){
        yield return new WaitForSecondsRealtime(1);

        PlayerPrefs.SetInt("player_money", 0);
        SceneManager.LoadScene("Saida", LoadSceneMode.Single);
    }
}