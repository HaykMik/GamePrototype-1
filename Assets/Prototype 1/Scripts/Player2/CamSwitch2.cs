using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch2 : MonoBehaviour
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
        if (Input.GetButtonDown("SwitchCamera2"))
        {
            mainCamera.enabled = !mainCamera.enabled;
            extraCamera.enabled = !extraCamera.enabled;
        }
    }
}
