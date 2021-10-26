using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockInteractable : Interactable
{
    Transform player;
    public override void Interact() {
        Debug.Log("I'm a rock");
        Debug.Log(player);
    }
}
