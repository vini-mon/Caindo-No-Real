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

    private void OnEnable(){
        Dollar_99.OnMoneyCollected += AddMoney;
    }
    
    private void OnDisable(){
        Dollar_99.OnMoneyCollected -= AddMoney;
    }

    public void AddMoney(){
        money += 100;
        gameText.text = "R$ " + money.ToString();
        PlayerPrefs.SetInt("player_money", money);
    }
}
