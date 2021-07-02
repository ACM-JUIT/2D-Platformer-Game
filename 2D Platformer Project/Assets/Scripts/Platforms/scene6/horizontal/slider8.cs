using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slider8 : MonoBehaviour
{
    float movespeed = 2f;
    bool moveRight = true;

    private void Update()
    {
        if (transform.position.x > 4.2)
            moveRight = false;
        if (transform.position.x < -5)
            moveRight = true;

        if (moveRight)
            transform.position = new Vector2(transform.position.x + movespeed * Time.deltaTime, 3.2f); 

        else
            transform.position = new Vector2(transform.position.x - movespeed * Time.deltaTime, 3.2f);
    }
}
