using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sliding_h : MonoBehaviour
{
    public float movespeed = 1.5f;
    bool moveRight = true;
    public float x_right = -7f;
    public float x_left = -10f;
    public float y = -1.5f;

    private void Update()
    {
        if (transform.position.x > x_right)
            moveRight = false;
        if (transform.position.x < x_left)
            moveRight = true;

        if (moveRight)
            transform.position = new Vector2(transform.position.x + movespeed * Time.deltaTime, y); //-2 is transform.position.y

        else
            transform.position = new Vector2(transform.position.x - movespeed * Time.deltaTime, y);
    }
}
