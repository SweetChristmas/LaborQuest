
using System.Collections;
using UnityEngine;
public class Interactable : MonoBehaviour
{
    public float radius = 3f;
    bool isFocus = false;
    bool hasInteracted = false;
    Transform _player;
    public Transform interactionTransform;
    void Update() {
        if(isFocus && hasInteracted == false) {
            float distance = Vector3.Distance(_player.position, transform.position);
            if(distance <= radius && hasInteracted == false) {
                StartCoroutine("Interaction");
            }
        }
    }
    void OnDrawGizmosSelected() {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(interactionTransform.position, radius);
    }
    public void OnFocused(Transform playerTransform) {
        isFocus = true;
        _player = playerTransform;
        hasInteracted = false;
    }

    public void OnDefocused() {
        Debug.Log("Defocused");
        hasInteracted = false;
        isFocus = false;
        _player = null;
    }
    public virtual void Interact() {
        // This method is meant to be overwritten
         Debug.Log("Interacting with " + transform.name);
    }
    IEnumerator Interaction() {
        Debug.Log("interacting now");
        hasInteracted = true;
        Interact();
        yield return null;
    }
}
