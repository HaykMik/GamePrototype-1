using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerExternal2 : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        //Offset the camera behind the player by additing to the player's position
        transform.position = player.transform.position + offset;
    }
}
