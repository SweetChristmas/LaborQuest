using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float movementSpeed = 1f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(new UnityEngine.Vector3((Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime), Input.GetAxis("Jump") * movementSpeed * Time.deltaTime, (Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime)));
    }
}
