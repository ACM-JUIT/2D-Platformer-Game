using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slider3 : MonoBehaviour
{

    float movespeed = 1.6f;
    bool moveRight = true;

    private void Update()
    {
        if (transform.position.x > 8)
            moveRight = false;
        if (transform.position.x < -5)
            moveRight = true;

        if (moveRight)
            transform.position = new Vector2(transform.position.x + movespeed * Time.deltaTime, 2.85f); //-2 is transform.position.y

        else
            transform.position = new Vector2(transform.position.x - movespeed * Time.deltaTime, 2.85f);
    }
}
