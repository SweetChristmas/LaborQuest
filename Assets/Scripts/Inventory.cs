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
    public List<PlayerItem> items = new List<PlayerItem>();
    // Start is called before the first frame update
    void Start() {
        inventorySlots = parentElement.GetComponentsInChildren<InventorySlot>();
    }
    public void Add (PlayerItem item) {
        for(var a = 0; a < inventorySlots.Length; a++) {
            var currentSlot = inventorySlots[a];
            if(item.isStackable) {
                if(currentSlot.GetItem().name == item.name) {
                    currentSlot.SetItemAmount(currentSlot.GetItem().amount + item.amount);
                    break;
                }
            }
            else if(currentSlot.GetItem() == null) {
                currentSlot.SetItem(item);
                break;
            }
        }

    }
    public void Remove(PlayerItem item) {
        items.Remove(item);
    }
}
