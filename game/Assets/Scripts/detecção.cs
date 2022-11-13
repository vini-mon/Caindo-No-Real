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
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(true);
        StopCoroutine(co);
    }

    IEnumerator DetectionTime(){
        transform.GetChild(2).gameObject.SetActive(false);
        transform.GetChild(0).gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(0.33f);
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(0.33f);
        transform.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(0.33f);

        PlayerPrefs.SetInt("player_money", 0);
        SceneManager.LoadScene("Saida", LoadSceneMode.Single);
    }
}