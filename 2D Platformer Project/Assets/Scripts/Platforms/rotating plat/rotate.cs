using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    float rotspeed = 30f; 
    private void Update()
    {
            transform.Rotate(Vector3.forward * rotspeed * Time.deltaTime);
    }
}
