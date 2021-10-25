using System.Diagnostics.Tracing;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    public Interactable focus;
    public LayerMask movementMask;

    public LayerMask interactMask;
    Camera playerCamera;
    PlayerMotor motor;


    // Start is called before the first frame update
    void Start()
    {
        playerCamera = Camera.main;
        motor = GetComponent<PlayerMotor>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)) {
            Ray ray = playerCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Physics.Raycast(ray, out hit, 100, movementMask);
            // if() {
            //     motor.MoveToPoint(hit.point);
                
            // }
            Interactable interactable = hit.collider.GetComponent<Interactable>();
            if(interactable != null) {
                SetFocus(interactable);
            } else {
                RemoveFocus();
                motor.MoveToPoint(hit.point);
            }
            
        }
        // if(Input.GetMouseButton(0) && !EventSystem.current.IsPointerOverGameObject()) {
        //     Ray myRay = playerCamera.ScreenPointToRay(Input.mousePosition);
        //     RaycastHit myRayCastHit;

        //     if(Physics.Raycast(myRay, out myRayCastHit)) {
        //         playerNavMeshAgent.SetDestination(myRayCastHit.point);
        //     }
        // }
    }
    void SetFocus(Interactable interactable) {
        if(interactable != focus) {
            if(focus != null) {
                focus.OnDefocused();
            }
            
        }
        focus = interactable;
        interactable.OnFocused(transform);
        motor.FollowTarget(focus);
    }
    void RemoveFocus() {
        if(focus != null) {
            focus.OnDefocused();
        }
        focus = null;
        motor.StopFollowingTarget();
    }
}
