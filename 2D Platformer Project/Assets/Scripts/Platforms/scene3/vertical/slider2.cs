using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slider2 : MonoBehaviour
{
    float movespeed = 1.16f;
    bool moveUp = true;

    private void Update()
    {
        if (transform.position.y > 2.85)
            moveUp = false;
        if (transform.position.y < -1.8)
            moveUp = true;

        if (moveUp)
            transform.position = new Vector2(-5, transform.position.y + movespeed * Time.deltaTime); 
        else
            transform.position = new Vector2(-5, transform.position.y - movespeed * Time.deltaTime);
    }
}
