using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ID_Card : MonoBehaviour, ICollectible
{
    public static event HandleCardCollected OnCardCollected;
    public delegate void HandleCardCollected(ItemData itemData);
    public ItemData cardData;

    public void Collect(){
        Destroy(gameObject);
        OnCardCollected?.Invoke(cardData);
    }
}
