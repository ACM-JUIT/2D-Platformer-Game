using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_v : MonoBehaviour
{
    public float movespeed = 0.3f;
    bool moveup = true;
    public float y_up = -7f;
    public float y_down = -10.5f;
    public float x = 4f;

    private void Update()
    {
        if (transform.position.y > y_up)
            moveup = false;
        if (transform.position.y < y_down)
            moveup = true;

        if (moveup)
            transform.position = new Vector2(x,transform.position.y + movespeed * Time.deltaTime);

        else
            transform.position = new Vector2(x,transform.position.y - movespeed * Time.deltaTime);
    }
}
