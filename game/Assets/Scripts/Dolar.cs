using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dolar : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other){
        TotalMoney.instance.AddMoney();
        gameObject.SetActive(false);
    }
}
