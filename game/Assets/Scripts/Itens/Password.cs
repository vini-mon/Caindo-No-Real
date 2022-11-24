using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Password : MonoBehaviour, ICollectible
{   
    public static event HandlePasswordCollected OnPasswordCollected;
    public delegate void HandlePasswordCollected(ItemData itemData);
    public ItemData passwordData;

    public void Collect(){
        Destroy(gameObject);
        OnPasswordCollected?.Invoke(passwordData);
    }
}
