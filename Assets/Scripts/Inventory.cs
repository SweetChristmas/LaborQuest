using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Transform parentElement;
    public InventorySlot[] inventorySlots;
    public List<Item> items = new List<Item>();
    // Start is called before the first frame update
    void Start() {
        inventorySlots = parentElement.GetComponentsInChildren<InventorySlot>();
    }
    public void Add (Item item) {
        // items.Add(item);
        Debug.Log("Adding");
        var hasGrabbed = false;
        for(var a = 0; a < inventorySlots.Length; a++) {
            var currentSlot = inventorySlots[a];
            Debug.Log("What is happening");
            Debug.Log(hasGrabbed);
            if(item.isStackable && hasGrabbed == false) {
                if(currentSlot.GetItem().name == item.name) {
                    currentSlot.SetItemAmount(currentSlot.GetItem().amount + item.amount);
                    hasGrabbed = true;
                    break;
                }
            }
            else if(currentSlot.GetItem() == null && hasGrabbed == false) {
                // Debug.Log(currentSlot);
                currentSlot.SetItem(item);
                hasGrabbed = true;
                Debug.Log("Closing");
                break;
            

            }
            Debug.Log(currentSlot);
        }

    }
    public void Remove(Item item) {
        items.Remove(item);
    }
}
