using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class InventoryItem
{   
    public ItemData itemData;
    public int stackSize;

    public InventoryItem(ItemData item){
        itemData = item;
        stackSize = 0;
        AddToStack();
    }

    public void AddToStack(){
        stackSize++;
    }

    public void RemoveFromStack(){
        stackSize--;
    }
}