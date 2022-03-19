using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer2 : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 4.8f, -1);

    // Update is called once per frame
    void LateUpdate()
    {
        //Offset the camera behind the player by additing to the player's position
        transform.position = player.transform.position + offset;
    }
}
