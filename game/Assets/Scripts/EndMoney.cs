using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndMoney : MonoBehaviour
{
    //public static EndMoney instance;
    public Text moneyText;
    static int money = 0;
    int last_run_money = 0;

    // private void Awake(){
    //     instance = this;
    // }

    void Start(){
        last_run_money = PlayerPrefs.GetInt("player_money");
        money += last_run_money;
        moneyText.text = "DInheiro coletado\nR$ " + money.ToString();
    }
}
