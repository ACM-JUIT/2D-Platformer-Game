using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;
    public Camera cam;
    private void Start()
    {
        cam = GetComponent<Camera>();
    }
    private void FixedUpdate()
    {
        cam.transform.position = player.transform.position + offset;
    }
}
