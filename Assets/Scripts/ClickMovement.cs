using System.Diagnostics.Tracing;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
public class ClickMovement : MonoBehaviour
{
    public NavMeshAgent playerNavMeshAgent;

    public Camera playerCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0) && !EventSystem.current.IsPointerOverGameObject()) {
            Ray myRay = playerCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit myRayCastHit;

            if(Physics.Raycast(myRay, out myRayCastHit)) {
                playerNavMeshAgent.SetDestination(myRayCastHit.point);
            }
        }
    }
}
