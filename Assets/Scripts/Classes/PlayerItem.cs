using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerItem", menuName = "Inventory/PlayerItem", order = 1)]
public class PlayerItem : ScriptableObject {
    
    public int id;
    public int amount = 1;
    public float quality;
    new public string name = "New Item";
    public Sprite icon = null;
    public bool isStackable = false;
}
