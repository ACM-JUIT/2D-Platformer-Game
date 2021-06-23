using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sliding : MonoBehaviour
{
    float dirX, movespeed = 2f;
    bool moveRight = true;

    private void Update()
    {
        if (transform.position.x > 5.5)
            moveRight = false;
        if (transform.position.x < 1)
            moveRight = true;

        if (moveRight)
           transform.position = new Vector2(transform.position.x + movespeed * Time.deltaTime, -1.8f); //-2 is transform.position.y

        else
            transform.position = new Vector2(transform.position.x - movespeed * Time.deltaTime, -1.8f);
    }
}
