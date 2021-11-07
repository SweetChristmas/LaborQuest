using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;
    public GameObject player;

    private Vector3 offset;

    private float minZoom = 15f;
    private float maxZoom = 90f;

    private float sensitivity = 45f;

    private float speed = 3.5f;


    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
    }
    // Called after every Update
    void LateUpdate() {
        var fov = Camera.main.fieldOfView;
        fov += Input.GetAxis("Mouse ScrollWheel") *  -sensitivity;
        fov = Mathf.Clamp(fov, minZoom, maxZoom);
        Camera.main.fieldOfView = fov;
        if(Input.GetMouseButton(1)) {
             Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * speed, Vector3.up);

            offset = camTurnAngle  * offset;

        }
        Vector3 newPos = player.transform.position + offset;
        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);
        transform.position = player.transform.position + offset;

            transform.LookAt(player.transform.position);
    }
}
