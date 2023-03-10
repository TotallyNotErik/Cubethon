using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    public Transform player;
    public Vector3 cameraOffset = new Vector3(0, 3, -5);
    // Update is called once per frame
    void Update()
    {
        transform.position = (player.position + cameraOffset);
    }
}
