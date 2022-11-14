using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Dollar_99 : MonoBehaviour, ICollectible
{
    public static event Action OnMoneyCollected;

    public void Collect(){
        Destroy(gameObject);
        OnMoneyCollected?.Invoke();
    }
}
