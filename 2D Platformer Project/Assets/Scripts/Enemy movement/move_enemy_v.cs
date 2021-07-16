using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_enemy_v : MonoBehaviour
{
    public float movespeed = 2f;
    bool moveUp = true;
    public float y_up = 11f;
    public float y_down = 13.7f;
    public float x = 0.7f;
    private void Update()
    {
        if (transform.position.y > y_up)
            moveUp = false;
        if (transform.position.y < y_down)
            moveUp = true;

        if (moveUp)
            transform.position = new Vector2(x,transform.position.y + movespeed * Time.deltaTime);
        else
            transform.position = new Vector2(x,transform.position.y - movespeed * Time.deltaTime);
    }
}
