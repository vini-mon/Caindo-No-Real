using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalMoney : MonoBehaviour
{

    public static TotalMoney instance;
    public Text moneyText;

    int money = 0;
    
    private void Awake(){
        instance = this;
    }

    void Start()
    {
        moneyText.text = "R$ " + money.ToString();
    }

    public void AddMoney(){
        money += 100;
        moneyText.text = "R$ " + money.ToString();
    }
}
