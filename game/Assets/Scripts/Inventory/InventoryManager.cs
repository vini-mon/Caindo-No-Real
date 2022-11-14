using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public GameObject slotPrefab;
    public List<InventorySlot> inventorySlot = new List<InventorySlot>(4);

    private void OnEnable(){
        Inventory.OnInventoryChange += DrawInventory;
    }

    private void OnDisable(){
        Inventory.OnInventoryChange -= DrawInventory;
    }

    void ResetInventory(){
        foreach (Transform childTransform in transform){
            Destroy(childTransform.gameObject);
        }
        inventorySlot = new List<InventorySlot>(4);
    }

    void DrawInventory(List<InventoryItem> inventory){
        ResetInventory();

        for (int i = 0; i < inventorySlot.Capacity; i++){
            CreateInventorySlot();
        }

        for (int i = 0; i < inventory.Count; i++){
            inventorySlot[i].DrawSlot(inventory[i]);
        }
    }

    void CreateInventorySlot(){
        GameObject newSlot = Instantiate(slotPrefab);
        newSlot.transform.SetParent(transform, false);

        InventorySlot newSlotComponent = newSlot.GetComponent<InventorySlot>();
        newSlotComponent.ClearSlot();

        inventorySlot.Add(newSlotComponent);
    }
}
