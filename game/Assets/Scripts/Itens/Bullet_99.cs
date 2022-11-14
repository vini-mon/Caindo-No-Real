using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Bullet_99 : MonoBehaviour, ICollectible
{   
    public static event HandleBulletCollected OnBulletCollected;
    public delegate void HandleBulletCollected(ItemData itemData);
    public ItemData bulletData;

    public void Collect(){
        Destroy(gameObject);
        OnBulletCollected?.Invoke(bulletData);
    }
}
