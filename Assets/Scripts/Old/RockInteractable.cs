using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockInteractable : Interactable
{   Interactable interactable;
    Inventory playerInventory;
    public PlayerItem _item;
    void Start() {
        playerInventory = GameObject.Find("Player").GetComponent<Inventory>();

    }
    public override void Interact() {
        Debug.Log("I'm a rock");
        playerInventory.Add(_item);
    }
}
