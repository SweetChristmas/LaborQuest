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
        items.Add(item);
    }
    public void Remove(Item item) {
        items.Remove(item);
    }
}
