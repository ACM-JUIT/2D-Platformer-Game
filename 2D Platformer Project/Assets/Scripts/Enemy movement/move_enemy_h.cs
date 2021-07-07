using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_enemy_h : MonoBehaviour
{
    public float movespeed = 2f;
    bool moveRight = true;
    public float x_left = 11f;
    public float x_right = 13.7f;
    public float y = 0.7f;
    private void Update()
    {
        if (transform.position.x > x_right)
            moveRight = false;
        if (transform.position.x < x_left)
            moveRight = true;

        if (moveRight)
            transform.position = new Vector2( transform.position.x + movespeed * Time.deltaTime, y);
        else
            transform.position = new Vector2(transform.position.x - movespeed * Time.deltaTime, y);
    }
}
