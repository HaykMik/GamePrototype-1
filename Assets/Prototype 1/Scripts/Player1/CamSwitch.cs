using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    public Camera mainCamera;
    public Camera extraCamera;

    void Start()
    {
        mainCamera.enabled = true;
        extraCamera.enabled = false;
    }
    void Update()
    {
        if (Input.GetButtonDown("SwitchCamera"))
        {
            mainCamera.enabled = !mainCamera.enabled;
            extraCamera.enabled = !extraCamera.enabled;
        }
    }
}
