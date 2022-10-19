using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class detecção : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other){
        PlayerPrefs.SetInt("player_money", 0);
        SceneManager.LoadScene("Saida", LoadSceneMode.Single);
    }
}
