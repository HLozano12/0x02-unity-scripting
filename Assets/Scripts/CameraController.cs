using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;

    ///<summary> intended to update once a frame </summary>
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}