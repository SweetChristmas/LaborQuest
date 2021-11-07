using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Inventory/Item", order = 0)]
public class Item : ScriptableObject {
    
    public int id;
    public int amount = 1;
    public float quality;
    new public string name = "New Item";
    public Sprite icon = null;
    public bool isStackable = false;
}
