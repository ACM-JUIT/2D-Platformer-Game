using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class antirotate : MonoBehaviour
{
    float rotspeed = 30f;
    private void Update()
    {
        transform.Rotate(Vector3.back * rotspeed * Time.deltaTime);
    }
}
