using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanesPropeller : MonoBehaviour
{
    private float speed = 2000f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * speed);
    }
}
