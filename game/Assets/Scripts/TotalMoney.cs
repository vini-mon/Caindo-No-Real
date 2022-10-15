using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalMoney : MonoBehaviour
{

    public static TotalMoney instance;
    public Text gameText;

    int money = 0;
    
    private void Awake(){
        instance = this;
    }

    void Start()
    {
        gameText.text = "R$ " + money.ToString();
    }

    public void AddMoney(){
        money += 100;
        gameText.text = "R$ " + money.ToString();
    }
}
