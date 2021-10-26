using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlot : MonoBehaviour
{
    Item item;

    void AddItem(Item _item) {
        item = _item;
    }
    void RemoveItem() {
        item = null;
    }
}
