using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    Image image;
    Item item;

    void Start() {
        item = null;
        image = GetComponent<Image>();
    }

    public Item GetItem() {
        return item;
    }
    public void SetItem(Item _item) {
        var tempColor = image.color;
        tempColor.a = 1f;
        image.color = tempColor;
        item = _item;
        image.sprite = _item.icon;
    }
    public void SetItemAmount(int amount) {
        item.amount = amount;
    }
    public void RemoveItem() {
        item = null;
        image.sprite = null;
        var tempColor = image.color;
        tempColor.a = 0f;
        image.color = tempColor;
    }
    public void PrintItem() {
        if(item != null)
        Debug.Log(item.name);
    }
}
