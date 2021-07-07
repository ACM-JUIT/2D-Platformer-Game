using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_enemy3 : MonoBehaviour
{
    float movespeed = 3f;
    bool moveRight = true;
    private void Update()
    {
        if (transform.position.x > 0)
            moveRight = false;
        if (transform.position.x < -8.5)
            moveRight = true;

        if (moveRight)
            transform.position = new Vector2(transform.position.x + movespeed * Time.deltaTime, 6.5f);
        else
            transform.position = new Vector2(transform.position.x - movespeed * Time.deltaTime, 6.5f);
    }
}
