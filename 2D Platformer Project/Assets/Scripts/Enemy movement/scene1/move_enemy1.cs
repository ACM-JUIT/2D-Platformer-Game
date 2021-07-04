using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_enemy1 : MonoBehaviour
{
    float movespeed = 2f;
    bool moveRight = true;
    private void Update()
    {
        if (transform.position.x > 13.4)
            moveRight = false;
        if (transform.position.x < 11)
            moveRight = true;

        if (moveRight)
            transform.position = new Vector2( transform.position.x + movespeed * Time.deltaTime, 0.78f);
        else
            transform.position = new Vector2(transform.position.x - movespeed * Time.deltaTime, 0.78f);
    }
}
