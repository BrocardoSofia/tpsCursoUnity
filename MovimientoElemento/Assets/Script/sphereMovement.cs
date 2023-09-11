using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereMovement : MonoBehaviour
{
    // Velocidad
    public float velocity = 5f;

    Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float verticalMovement = Input.GetAxis("Vertical");
        float horizontalMovement = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(horizontalMovement, 0f, verticalMovement);

        rigidbody.velocity = movement * velocity;
    }
}
