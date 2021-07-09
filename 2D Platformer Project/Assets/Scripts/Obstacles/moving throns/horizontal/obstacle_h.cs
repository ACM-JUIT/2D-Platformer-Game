using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_h : MonoBehaviour
{
    public float movespeed = 0.3f;
    bool moveRight = true;
    public float x_right = -7f;
    public float x_left = -10.5f;
    public float y = 4f;

    private void Update()
    {
        if (transform.position.x > x_right)
            moveRight = false;
        if (transform.position.x < x_left)
            moveRight = true;

        if (moveRight)
            transform.position = new Vector2(transform.position.x + movespeed * Time.deltaTime, y); 

        else
            transform.position = new Vector2(transform.position.x - movespeed * Time.deltaTime, y);
    }
}
