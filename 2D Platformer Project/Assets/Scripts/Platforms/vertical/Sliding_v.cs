using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sliding_v : MonoBehaviour
{
    public float movespeed = 2f;
    bool moveup = true;
    public float y_up = 1f;
    public float y_down = -2f;
    public float x = 6.5f;

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
