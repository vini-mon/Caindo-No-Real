using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class detecção : MonoBehaviour
{
    Coroutine co;
    
    private void OnTriggerEnter2D(Collider2D other){
        if(transform.GetChild(0).gameObject.activeSelf)
            co = StartCoroutine(DetectionTime());
    }
    private void OnTriggerExit2D(Collider2D other){
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(false);
        StopCoroutine(co);
    }

    IEnumerator DetectionTime(){
        yield return new WaitForSecondsRealtime(0.5f);
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(0.5f);
        transform.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(0.5f);

        PlayerPrefs.SetInt("player_money", 0);
        SceneManager.LoadScene("Saida", LoadSceneMode.Single);
    }
}