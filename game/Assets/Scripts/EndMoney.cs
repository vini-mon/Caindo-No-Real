using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndMoney : MonoBehaviour
{
    //public static EndMoney instance;
    public Text moneyText;
    public Text highscore;
    static int money = 0;
    int last_run_money = 0;
    int highscore_money = 0;

    // private void Awake(){
    //     instance = this;
    // }

    void Start(){
        last_run_money = PlayerPrefs.GetInt("player_money");
        highscore_money = PlayerPrefs.GetInt("player_highscore");
        if (last_run_money > highscore_money){
            PlayerPrefs.SetInt("player_highscore", last_run_money);
            highscore_money = last_run_money;
        }
        highscore.text = "Melhor Desempenho: R$ " + highscore_money.ToString();
        money = last_run_money;
        moneyText.text = "Dinheiro coletado: R$ " + money.ToString();
        PlayerPrefs.SetInt("player_money", 0);
    }
}
