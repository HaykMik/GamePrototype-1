using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed;
    public float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Вызывает управление кнопкой из Input Manager
        horizontalInput = Input.GetAxis("Horizontal");

        //transform.Translate(0, 0, 1);

        // Move the vehicle forward
        // deltaTime меняет action per frame на action per second, т.к. разные девайсы выдают разный фрейм
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
