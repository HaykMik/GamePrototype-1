using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 8.5f, -9);

    void LateUpdate()
    {
        //Offset the camera behind the player by additing to the player's position
        transform.position = player.transform.position + offset;
    }
}
