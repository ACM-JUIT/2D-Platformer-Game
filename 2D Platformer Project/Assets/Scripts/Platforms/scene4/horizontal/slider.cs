using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slider : MonoBehaviour
{
    float movespeed = 1f;
    bool moveRight = true;

    private void Update()
    {
        if (transform.position.x > 2.5)
            moveRight = false;
        if (transform.position.x < -2)
            moveRight = true;

        if (moveRight)
            transform.position = new Vector2(transform.position.x + movespeed * Time.deltaTime, -2); //-2 is transform.position.y

        else
            transform.position = new Vector2(transform.position.x - movespeed * Time.deltaTime, -2);
    }
}
