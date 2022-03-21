using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    private float speed = 12f;
    public float turnSpeed = 15f;
    private float horizontalInput;
    private float forwardInput;

    // Update is called once per frame
    void Update()
    {
        // Вызывает управление кнопкой из Input Manager
        horizontalInput = Input.GetAxis("Horizontal2");
        forwardInput = Input.GetAxis("Vertical2");

        // Move the vehicle forward base on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Rotates the vehicle based on horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
