using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sliding : MonoBehaviour
{
    float movespeed = 2f;
    bool moveup = true;

    private void Update()
    {
        if (transform.position.y > 1)
            moveup = false;
        if (transform.position.y < -2)
            moveup = true;

        if (moveup)
           transform.position = new Vector2(6.5f,transform.position.y + movespeed * Time.deltaTime); 
        else
            transform.position = new Vector2(6.5f,transform.position.y - movespeed * Time.deltaTime);
    }
}
