using System.Linq.Expressions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class PlayerMotor : MonoBehaviour
{
    Transform target;
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    public void MoveToPoint(Vector3 point) {
        agent.SetDestination(point);
    }
    public void FollowTarget(Interactable _target) {
        agent.stoppingDistance = _target.radius * .5f;
        target = _target.interactionTransform;
    }
    public void StopFollowingTarget() {
        agent.stoppingDistance = 0f;
        target = null;
    }
    void FaceTarget() {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0f, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5);
    }
    // Update is called once per frame
    void Update()
    {
        if(target != null) {
            agent.SetDestination(target.position);
        }   
    }
}
