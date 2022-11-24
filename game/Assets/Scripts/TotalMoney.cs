using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalMoney : MonoBehaviour
{

    public static TotalMoney instance;
    public Text gameText;
    [Header("Component")]
    public Text timer;

    [Header("Timer Settings")]
    public float currentTime;
    public bool countUp;

    int money = 0;
    
    private void Awake(){
        instance = this;
    }

    void Start()
    {
        gameText.text = "R$ " + money.ToString();
    }

    void Update(){
        currentTime = countUp ? currentTime += Time.deltaTime : currentTime += 0;
        timer.text = currentTime.ToString("000.00");
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
