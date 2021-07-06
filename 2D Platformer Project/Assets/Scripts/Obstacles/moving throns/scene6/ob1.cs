using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ob1 : MonoBehaviour
{
    float movespeed = 0.3f;
    bool moveRight = true;

    private void Update()
    {
        if (transform.position.x > -7)
            moveRight = false;
        if (transform.position.x < -10.5)
            moveRight = true;

        if (moveRight)
            transform.position = new Vector2(transform.position.x + movespeed * Time.deltaTime, 4f); 

        else
            transform.position = new Vector2(transform.position.x - movespeed * Time.deltaTime, 4f);
    }
}
