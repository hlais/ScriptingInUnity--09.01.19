using UnityEngine;
using System;

public class MovementControls: MonoBehaviour
{
    float verticalInput;
    float horizontalInput;
    float speed = 50f;
    float turnSpeed = 50f;

    private void Update()
    {
        verticalInput = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
        horizontalInput = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;

        transform.Rotate(Vector3.up * horizontalInput);
        transform.Translate(Vector3.forward * verticalInput);
    }

}